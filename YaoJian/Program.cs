using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaoJian
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MDI_Home MDI_Form = new MDI_Home();
            MDI_Form.WindowState = FormWindowState.Maximized;
            Application.Run(MDI_Form);
        }
    }
}
