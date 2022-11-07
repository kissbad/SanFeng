using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarningTool
{
    public partial class Form1 : Form
    {
        Thread thread;
        Thread thread2;
        private Icon i;
        private Icon bulb;
        private bool is_shining = false;
        private string LastUpdateTime;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private SoundPlayer simpleSound;

        public Form1()
        {
            InitializeComponent();
            i = this.notifyIcon1.Icon;
            bulb = new Icon(@".\other\bulb.ico");
            simpleSound = new SoundPlayer(@".\other\msg.wav");

            //托盘菜单
            MenuItem[] mnuItms = new MenuItem[1];
            mnuItms[0] = new MenuItem("退出");
            mnuItms[0].Click += new System.EventHandler(this.ExitSelect);
            mnuItms[0].DefaultItem = true;
            notifyIcon1.ContextMenu = new ContextMenu(mnuItms);
        }


        private void start_Thread()
        {
            while (true)
            {
                Thread.Sleep(10 * 1000);
                LastUpdateTime = config.AppSettings.Settings["LastUpdateTime"]?.Value;
                List<Models.wkpdj> wkpdjs = Models.wkpdj.getList(LastUpdateTime);
                if (wkpdjs.Count > 0)
                {
                    Warning();
                }
            }
        }

        private void Warning()
        {
            Action action = () =>
            {
                if (!is_shining /*&& this.WindowState == FormWindowState.Minimized*/)
                {
                    thread2 = new Thread(shining);
                    thread2.Start();
                    is_shining = true;
                    simpleSound.Play();
                }
            };
            button1.BeginInvoke(action);
        }

        private void shining()
        {
            while (true)
            {
                Thread.Sleep(500);
                Action action = () =>
                {
                    if (this.notifyIcon1.Icon == bulb)
                    {
                        this.notifyIcon1.Icon = i;
                    }
                    else
                    {
                        this.notifyIcon1.Icon = bulb;
                    }
                };
                this.BeginInvoke(action);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.ShowInTaskbar = true;
                    this.WindowState = FormWindowState.Normal;
                }
                if (is_shining)
                {
                    this.notifyIcon1.Icon = i;
                    thread2.Abort();
                    is_shining = false;
                    PromptContent();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始提示")
            {
                thread = new Thread(start_Thread);
                thread.IsBackground = true;
                thread.Start();
                button1.Text = "停止提示";
            }
            else
            {
                button1.Text = "开始提示";
                thread.Abort();
            }

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            e.Cancel = true;
        }


        private void PromptContent()
        {
            List<Models.wkpdj> wkpdjs = Models.wkpdj.getList(LastUpdateTime);
            write("-------------------- " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --------------------------------");
            write(ShowDj<Models.wkpdj>(wkpdjs));
            config.AppSettings.Settings["LastUpdateTime"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            config.Save(ConfigurationSaveMode.Modified);
        }


        private string ShowDj<T>(List<T> djs)
        {
            string s = "";
            foreach (Models.dj i in djs)
            {
                s += i.djbh + " | " + i.rq + " | " + i.dwmch + " | " + i.je + "\r\n";
            }
            return s;
        }

        private void write(string s)
        {
            textBox1.Text += s + "\r\n";
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }


        //进入窗体
        private void Form_MouseEnter(object sender, EventArgs e)
        {
            if (is_shining)
            {
                this.notifyIcon1.Icon = i;
                thread2.Abort();
                is_shining = false;
                PromptContent();
            }
        }


        //关闭系统
        public void ExitSelect(object sender, System.EventArgs e)
        {
            if (is_shining)
            {
                thread2.Abort();
                is_shining = false;
            }
            if (button1.Text == "停止提示" && thread.ThreadState != ThreadState.Unstarted)
            {
                thread.Abort();
            }
            this.Close();
            this.Dispose(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
