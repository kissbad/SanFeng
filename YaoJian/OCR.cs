using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaoJian
{
    public partial class OCR : Form
    {
        public OCR()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = fileDialog.FileName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                textBox1.Text = "";
                var r = Models.BaiDu.OCR.Recognition(textBox2.Text);
                foreach (var i in r.words_result)
                {
                    textBox1.Text += string.Format("{0}\r\n", i.words);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "程序错误");
            }
            finally {
                button1.Enabled = true;
            }
        }
    }
}
