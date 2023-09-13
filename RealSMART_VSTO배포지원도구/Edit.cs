using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealSMART_VSTO배포지원도구
{
    public partial class Edit : Form
    {
        public string EditType { get; set; }

        public Edit()
        {
            InitializeComponent();
        }

        public void SetEditText(string text)
        {
            this.tb_Content.Text = text;
        }

        public void SaveText()
        {
            if (MessageBox.Show("저장할까요?", "저장확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                switch (EditType)
                {
                    case "ManifestValue":
                        Properties.Settings.Default.ManifestValue = this.tb_Content.Text;
                        break;
                    case "WorkString":
                        Properties.Settings.Default.WorkString = this.tb_Content.Text;
                        break;
                }
                Properties.Settings.Default.Save();

                MessageBox.Show("저장되었습니다.");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("수정을 취소할까요?","취소 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

