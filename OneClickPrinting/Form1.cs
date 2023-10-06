using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneClickPrinting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var s = pf_ckmx.getList("2023-08-31");
            DataTable b = pf_ckmx.getdt("2023-08-31");
            PrintHelper3 a = new PrintHelper3();

            a.LoadFile("Report1.rdlc", "mx", b);
            a.Print("KONICA MINOLTA 206");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            WQH.Print.PDF pdf = new WQH.Print.PDF();
            pdf.file_path = "http://183.237.98.131:7001/public_file/qd_pdf/914452223980834079/2023-08-30/23442000000181390393.pdf";
            WQH.Print.Printer printer = new WQH.Print.Printer("KONICA MINOLTA 206");
            pdf.Print(printer);
        }
    }
}
