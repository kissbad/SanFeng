using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YaoJian.Models;

namespace YaoJian
{
    public partial class UploadFileLog : Form
    {
        public UploadFileLog()
        {
            InitializeComponent();
        }

        private void get_data(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wqh_yj_UploadFileLog.Get_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dataGridView1.Columns["query_results"].Index) return;

            string fid = dataGridView1[dataGridView1.Columns["fidDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString();
            string upload_state = dataGridView1[dataGridView1.Columns["uploadstateDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString();

            FileDeal fd = new FileDeal(fid, upload_state);

            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                //MessageBox.Show(fd.fid);
            }
            else
            {
                //MessageBox.Show(fd.fid);
                //this.txtResult.Text = "Cancelled";
            }
            fd.Dispose();
            dataGridView1.DataSource = wqh_yj_UploadFileLog.Get_data();
        }
    }
}
