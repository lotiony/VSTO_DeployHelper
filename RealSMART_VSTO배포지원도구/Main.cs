using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealSMART_VSTO배포지원도구
{
    public partial class Main : Form
    {
        string selectedPath = "";
        public string AppFolder { get; set; } = "";     // KMIQ_1_0_18214_727
        public string AppName { get; set; } = "";       // KMIQ

        bool EnableDeploy { get { return (AppFolder != "" && AppName != ""); } }

        public Main()
        {
            InitializeComponent();
        }

        private void lbl_Path_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbl_Path_DragDrop(object sender, DragEventArgs e)
        {
            string[] DropLists = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FolderDrop(DropLists);
        }

        private void FolderDrop(string[] dropLists)
        {
            selectedPath = "";

            foreach (string fname in dropLists)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fname);

                if (dirInfo.Exists)
                {
                    CheckFolder(dirInfo);

                }
            }
        }

        private void CheckFolder(DirectoryInfo dirInfo)
        {
            var subf = dirInfo.GetFiles().ToList();

            if (subf.Where(x => x.Name.Contains(".dll.manifest")).Count() > 0)
            {
                lbl_Path.Text = dirInfo.FullName;
                selectedPath = dirInfo.FullName;

                AppFolder = GetAppFolder();
                AppName = GetAppName();

                lbl_FolderCheck.Text = $@"하위폴더 : \{AppFolder}\    App Name : {AppName}";
                return;
            }
            else
            {
                var subs = dirInfo.GetDirectories().ToList();

                foreach (DirectoryInfo dir in subs)
                {
                    CheckFolder(dir);
                }
            }
        }

        private string GetAppFolder()
        {
            if (selectedPath != "")
            {
                var dirInfo = new DirectoryInfo(selectedPath);
                return dirInfo.Name;
            }
            return "";
        }

        private string GetAppName()
        {
            if (selectedPath != "")
            {
                var dirInfo = new DirectoryInfo(selectedPath);
                var mfiles = dirInfo.GetFiles("*.manifest");
                if (mfiles.Count() > 0)
                {
                    return mfiles[0].Name.Replace(".dll.manifest", "");
                }
            }
            return "";
        }

        /// <summary>
        /// ~~.dll.manifest 파일에 내용을 추가한다.
        /// </summary>
        private void ApplyManifest()
        {
            string menifestFileName = "";
            var dirInfo = new DirectoryInfo(selectedPath);
            var mfiles = dirInfo.GetFiles("*.manifest");
            if (mfiles.Count() > 0)
            {
                menifestFileName = mfiles[0].FullName;

                List<string> fileLine = readFile(menifestFileName);

                if (fileLine.Count > 0)
                {
                    try
                    {
                        var sItems = fileLine.Where(x => x.Contains("<vstav3:update enabled=\"true\" />")).Select(x => x).ToList();
                        if (sItems.Count > 0)
                        {
                            int sIdx = fileLine.IndexOf(sItems[0]);
                            Console.WriteLine(sIdx);

                            if (sIdx > 0)
                            {
                                Console.WriteLine(fileLine[sIdx]);

                                if (fileLine[sIdx + 1] != "<vstav3:postActions>")
                                {

                                    //List<string> newInsert = new List<string>();
                                    //newInsert.Add("<vstav3:postActions>");
                                    //newInsert.Add("  <vstav3:postAction>");
                                    //newInsert.Add("    <vstav3:entryPoint class=\"VSTOInstaller.VSTOInstaller\">");
                                    //newInsert.Add("      <assemblyIdentity name=\"VSTOInstaller\" version=\"1.2015.12.24\" language=\"neutral\" processorArchitecture=\"msil\" />");
                                    //newInsert.Add("    </vstav3:entryPoint>");
                                    //newInsert.Add("    <vstav3:postActionData>");
                                    //newInsert.Add("    </vstav3:postActionData>");
                                    //newInsert.Add("  </vstav3:postAction>");
                                    //newInsert.Add("</vstav3:postActions> ");

                                    //fileLine.InsertRange(sIdx + 1, newInsert);
                                    var addstring = Properties.Settings.Default.ManifestValue.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                                    addstring.ForEach(x => {
                                        fileLine.Insert(sIdx + 1, x);
                                        sIdx++;
                                    });
                                    //Console.WriteLine(string.Join(Environment.NewLine, fileLine));
                                }
                            }
                            File.WriteAllLines(mfiles[0].FullName, fileLine, Encoding.UTF8);
                        }

                        MessageBox.Show("manifest 파일 수정 완료.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("manifest 파일 편집 오류. 직접 수정하시기 바랍니다. " + ex.Message);
                    }
                }
            }
        }



        /// <summary>
        /// rss파일로부터 문자열을 한 라인씩 읽어들여 List<String> 형태로 반환
        /// </summary>
        private List<string> readFile(string fileName)
        {
            List<string> Rtn = new List<string>();
            try
            {
                System.IO.StreamReader oReadFile = null;
                string sLine = null;

                using (oReadFile = new System.IO.StreamReader(fileName, Encoding.UTF8))
                {
                    while (true)
                    {
                        sLine = oReadFile.ReadLine();
                        if (sLine != null)
                        {
                            Rtn.Add(sLine);
                        }
                        else
                        {
                            break;
                        }
                    }
                    oReadFile.Close();
                }
            }
            catch (Exception ex)
            {
                
            }

            return Rtn;
        }

        private void btn_RunManifest_Click(object sender, EventArgs e)
        {
            if (EnableDeploy)
            {
                ApplyManifest();
            }
            else
            {
                MessageBox.Show("경로선택을 정확히 해주세요");
            }
        }

        private void btn_SetManifest_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.EditType = "ManifestValue";
            edit.SetEditText(Properties.Settings.Default.ManifestValue);
            edit.Show();
        }

        private void btnRunDevCmd_Click(object sender, EventArgs e)
        {
            var process = new Process();
            process.StartInfo.FileName = Properties.Settings.Default.VsDevCmdPath;
            process.StartInfo.Arguments = "";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            if (6 <= Environment.OSVersion.Version.Major)
                process.StartInfo.Verb = "runas";
            process.Start();
        }

        private void btnSetDevCmd_Click(object sender, EventArgs e)
        {
            string newFile = "";

            //***** 저장시킬 파일명을 만들어 받아온다.
            System.Windows.Forms.OpenFileDialog oFO = new System.Windows.Forms.OpenFileDialog();

            var _with1 = oFO;
            _with1.Multiselect = false;
            _with1.Filter = "VS DevCmd 실행파일(*.bat)|*.bat";
            _with1.Title = "VisualStudio DevCmd실행파일을 선택하세요.";
            _with1.InitialDirectory = @"C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\Tools\";

            if (oFO.ShowDialog() == DialogResult.OK)
            {
                newFile = oFO.FileName;
            }
            
            
            if (newFile != "")
            {
                Properties.Settings.Default.VsDevCmdPath = newFile;
                Properties.Settings.Default.Save();

                MessageBox.Show("실행파일 지정이 완료되었습니다.");
            }
        }

        private void btn_SetCert_Click(object sender, EventArgs e)
        {
            string newFile = "";

            //***** 저장시킬 파일명을 만들어 받아온다.
            System.Windows.Forms.OpenFileDialog oFO = new System.Windows.Forms.OpenFileDialog();

            var _with1 = oFO;
            _with1.Multiselect = false;
            _with1.Filter = "인증서 파일(*.pfx)|*.pfx";
            _with1.Title = "인증서 파일을 선택하세요.";
            _with1.InitialDirectory = @"G:\";

            if (oFO.ShowDialog() == DialogResult.OK)
            {
                newFile = oFO.FileName;
            }


            if (newFile != "")
            {
                Properties.Settings.Default.CertFilePath = newFile;
                Properties.Settings.Default.Save();
                lbl_CertStatus.Text = "정상";

                MessageBox.Show("인증서 파일 지정이 완료되었습니다.");
            }

        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (EnableDeploy && tb_CertPwd.Text != "")
            {
                tb_Cmd.Text = string.Format(Properties.Settings.Default.WorkString, selectedPath, AppName, Properties.Settings.Default.CertFilePath, tb_CertPwd.Text, AppFolder);

                Clipboard.SetData(DataFormats.Text, tb_Cmd.Text);
                MessageBox.Show("클립보드에 복사되었습니다.");
            }
        }

        private void btn_SelectPath_Click(object sender, EventArgs e)
        {

        }

        private void Main_Shown(object sender, EventArgs e)
        {
            lbl_CertStatus.Text = (File.Exists(Properties.Settings.Default.CertFilePath)) ? "정상" : "없음";
        }

        private void tb_CertPwd_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CertFilePwd = tb_CertPwd.Text;
            Properties.Settings.Default.Save();
        }
    }
}
