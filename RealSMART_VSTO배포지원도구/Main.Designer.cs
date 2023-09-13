namespace RealSMART_VSTO배포지원도구
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_FolderCheck = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_SetManifest = new System.Windows.Forms.Button();
            this.btn_RunManifest = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_Cmd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_CertPwd = new System.Windows.Forms.TextBox();
            this.lbl_CertStatus = new System.Windows.Forms.Label();
            this.btn_SetCert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetDevCmd = new System.Windows.Forms.Button();
            this.btnRunDevCmd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_FolderCheck);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "경로 설정";
            // 
            // lbl_FolderCheck
            // 
            this.lbl_FolderCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_FolderCheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_FolderCheck.Location = new System.Drawing.Point(3, 111);
            this.lbl_FolderCheck.Name = "lbl_FolderCheck";
            this.lbl_FolderCheck.Size = new System.Drawing.Size(830, 28);
            this.lbl_FolderCheck.TabIndex = 4;
            this.lbl_FolderCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Path);
            this.panel2.Controls.Add(this.btn_SelectPath);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 44);
            this.panel2.TabIndex = 1;
            // 
            // lbl_Path
            // 
            this.lbl_Path.AllowDrop = true;
            this.lbl_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Path.Location = new System.Drawing.Point(63, 0);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(767, 44);
            this.lbl_Path.TabIndex = 1;
            this.lbl_Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl_Path_DragDrop);
            this.lbl_Path.DragOver += new System.Windows.Forms.DragEventHandler(this.lbl_Path_DragOver);
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SelectPath.Location = new System.Drawing.Point(0, 0);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(63, 44);
            this.btn_SelectPath.TabIndex = 0;
            this.btn_SelectPath.Text = "경로선택";
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            this.btn_SelectPath.Click += new System.EventHandler(this.btn_SelectPath_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "배포할 Application files 폴더를 선택하세요.\r\n예) D:\\VS Project\\SMART TEST (문제은행)\\SMART TEST v" +
    "2 한국간호과학회\\SMART TEST\\publish\\Application Files\\SMART TESTBANK 한국간호과학회_2_5_16344_" +
    "24181";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "배포 작업 진행";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.69388F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.30612F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_SetManifest);
            this.panel5.Controls.Add(this.btn_RunManifest);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 58);
            this.panel5.TabIndex = 8;
            // 
            // btn_SetManifest
            // 
            this.btn_SetManifest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_SetManifest.Location = new System.Drawing.Point(0, 34);
            this.btn_SetManifest.Name = "btn_SetManifest";
            this.btn_SetManifest.Size = new System.Drawing.Size(114, 24);
            this.btn_SetManifest.TabIndex = 1;
            this.btn_SetManifest.Text = "설정";
            this.btn_SetManifest.UseVisualStyleBackColor = true;
            this.btn_SetManifest.Click += new System.EventHandler(this.btn_SetManifest_Click);
            // 
            // btn_RunManifest
            // 
            this.btn_RunManifest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RunManifest.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_RunManifest.Location = new System.Drawing.Point(0, 0);
            this.btn_RunManifest.Name = "btn_RunManifest";
            this.btn_RunManifest.Size = new System.Drawing.Size(114, 28);
            this.btn_RunManifest.TabIndex = 0;
            this.btn_RunManifest.Text = "실행";
            this.btn_RunManifest.UseVisualStyleBackColor = true;
            this.btn_RunManifest.Click += new System.EventHandler(this.btn_RunManifest_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "manifest 수정";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb_Cmd);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_Run);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(393, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 58);
            this.panel4.TabIndex = 6;
            // 
            // tb_Cmd
            // 
            this.tb_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cmd.Location = new System.Drawing.Point(56, 0);
            this.tb_Cmd.Multiline = true;
            this.tb_Cmd.Name = "tb_Cmd";
            this.tb_Cmd.Size = new System.Drawing.Size(378, 58);
            this.tb_Cmd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(51, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(5, 58);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Run
            // 
            this.btn_Run.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Run.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Run.Location = new System.Drawing.Point(0, 0);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(51, 58);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.Text = "내용 생성 &&복사";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_CertPwd);
            this.panel3.Controls.Add(this.lbl_CertStatus);
            this.panel3.Controls.Add(this.btn_SetCert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(243, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 58);
            this.panel3.TabIndex = 5;
            // 
            // tb_CertPwd
            // 
            this.tb_CertPwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RealSMART_VSTO배포지원도구.Properties.Settings.Default, "CertFilePwd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_CertPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CertPwd.Location = new System.Drawing.Point(38, 0);
            this.tb_CertPwd.Name = "tb_CertPwd";
            this.tb_CertPwd.Size = new System.Drawing.Size(106, 21);
            this.tb_CertPwd.TabIndex = 4;
            this.tb_CertPwd.Text = global::RealSMART_VSTO배포지원도구.Properties.Settings.Default.CertFilePwd;
            this.tb_CertPwd.TextChanged += new System.EventHandler(this.tb_CertPwd_TextChanged);
            // 
            // lbl_CertStatus
            // 
            this.lbl_CertStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_CertStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_CertStatus.Location = new System.Drawing.Point(0, 0);
            this.lbl_CertStatus.Name = "lbl_CertStatus";
            this.lbl_CertStatus.Size = new System.Drawing.Size(38, 34);
            this.lbl_CertStatus.TabIndex = 3;
            this.lbl_CertStatus.Text = "정상";
            this.lbl_CertStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SetCert
            // 
            this.btn_SetCert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_SetCert.Location = new System.Drawing.Point(0, 34);
            this.btn_SetCert.Name = "btn_SetCert";
            this.btn_SetCert.Size = new System.Drawing.Size(144, 24);
            this.btn_SetCert.TabIndex = 2;
            this.btn_SetCert.Text = "설정";
            this.btn_SetCert.UseVisualStyleBackColor = true;
            this.btn_SetCert.Click += new System.EventHandler(this.btn_SetCert_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(390, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(440, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "실행 커맨드";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(240, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "인증서 파일 및 암호";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(120, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "VS DevCmd";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSetDevCmd);
            this.panel1.Controls.Add(this.btnRunDevCmd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(123, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 58);
            this.panel1.TabIndex = 4;
            // 
            // btnSetDevCmd
            // 
            this.btnSetDevCmd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetDevCmd.Location = new System.Drawing.Point(0, 34);
            this.btnSetDevCmd.Name = "btnSetDevCmd";
            this.btnSetDevCmd.Size = new System.Drawing.Size(114, 24);
            this.btnSetDevCmd.TabIndex = 1;
            this.btnSetDevCmd.Text = "설정";
            this.btnSetDevCmd.UseVisualStyleBackColor = true;
            this.btnSetDevCmd.Click += new System.EventHandler(this.btnSetDevCmd_Click);
            // 
            // btnRunDevCmd
            // 
            this.btnRunDevCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRunDevCmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRunDevCmd.Location = new System.Drawing.Point(0, 0);
            this.btnRunDevCmd.Name = "btnRunDevCmd";
            this.btnRunDevCmd.Size = new System.Drawing.Size(114, 28);
            this.btnRunDevCmd.TabIndex = 0;
            this.btnRunDevCmd.Text = "실행";
            this.btnRunDevCmd.UseVisualStyleBackColor = true;
            this.btnRunDevCmd.Click += new System.EventHandler(this.btnRunDevCmd_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(836, 10);
            this.label4.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealSMART - VSTO 배포 지원 도구";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_Cmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_CertPwd;
        private System.Windows.Forms.Label lbl_CertStatus;
        private System.Windows.Forms.Button btn_SetCert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetDevCmd;
        private System.Windows.Forms.Button btnRunDevCmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_SetManifest;
        private System.Windows.Forms.Button btn_RunManifest;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_FolderCheck;
    }
}

