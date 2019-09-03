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
    public partial class XS_TH : Form
    {
        public XS_TH()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void get_data()
        {
            var start_rq = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var end_rq = this.dateTimePicker2.Value.ToString("yyyy-MM-dd");
            List<yjj_qyjk_pfthrk> data = yjj_qyjk_pfthrk.GetData(start_rq, end_rq);
            if (data.Count == 0)
            {
                MessageBox.Show("查无数据");
            }
            this.dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 1)
            {
                return;
            }
            var djbh = dataGridView1.Rows[e.RowIndex].Cells["djbhDataGridViewTextBoxColumn"].Value.ToString();
            List<yjj_qyjk_pfthrk> data = this.dataGridView1.DataSource as List<yjj_qyjk_pfthrk>;
            var mx = (from i in data where i.djbh == djbh select i.tm).ToList();
            dataGridView2.DataSource = mx[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<yjj_qyjk_pfthrk> data = this.dataGridView1.DataSource as List<yjj_qyjk_pfthrk>;
                if (data == null || data?.Count == 0)
                {
                    MessageBox.Show("未选择上传数据");
                    return;
                }
                List<yjj_qyjk_pfthrk> uplond_data = (from i in data where i.is_check == true select i).ToList();
                if (uplond_data.Count == 0)
                {
                    MessageBox.Show("未选择上传数据");
                    return;
                }
                var djbhs = (from i in uplond_data select i.djbh).ToList();
                
                Uplond uplond = new Uplond();
                uplond.xml_name = "218";
                uplond.xml_Validate = "yjj_qyjk_pfthrk.xsd";
                uplond.upload_type = "销售退货";
                var xml = uplond.GetXml<yjj_qyjk_pfthrk>(uplond_data);
                if (uplond.doUplond(xml, djbhs))
                {
                    MessageBox.Show("上传成功");
                    get_data();
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "程序错误");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }
    }
}
