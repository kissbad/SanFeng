namespace YaoJian
{
    partial class CGRK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enterPriceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.djbh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineCodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bzggDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yxqzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djmxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.djbhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rqrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghqyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsdhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yssbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yskssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ysjssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ysjlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yjjqyjkcgrkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djmxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkcgrkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(185, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.djbhDataGridViewTextBoxColumn,
            this.rqrqDataGridViewTextBoxColumn,
            this.ghqyDataGridViewTextBoxColumn,
            this.enterPriceName,
            this.xsdhDataGridViewTextBoxColumn,
            this.yssbDataGridViewTextBoxColumn,
            this.yskssjDataGridViewTextBoxColumn,
            this.ysjssjDataGridViewTextBoxColumn,
            this.clrDataGridViewTextBoxColumn,
            this.ysjlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yjjqyjkcgrkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(722, 369);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enterPriceName
            // 
            this.enterPriceName.DataPropertyName = "enterPriceName";
            this.enterPriceName.HeaderText = "供货企业（药监）";
            this.enterPriceName.Name = "enterPriceName";
            this.enterPriceName.ReadOnly = true;
            this.enterPriceName.Width = 83;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.djbh,
            this.bwmDataGridViewTextBoxColumn,
            this.medicineCodeNumber,
            this.bzggDataGridViewTextBoxColumn,
            this.scphDataGridViewTextBoxColumn,
            this.scrqDataGridViewTextBoxColumn,
            this.yxqzDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.djmxBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(25, 438);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(722, 228);
            this.dataGridView2.TabIndex = 5;
            // 
            // djbh
            // 
            this.djbh.DataPropertyName = "djbh";
            this.djbh.HeaderText = "单据编号";
            this.djbh.Name = "djbh";
            this.djbh.ReadOnly = true;
            this.djbh.Width = 78;
            // 
            // bwmDataGridViewTextBoxColumn
            // 
            this.bwmDataGridViewTextBoxColumn.DataPropertyName = "bwm";
            this.bwmDataGridViewTextBoxColumn.HeaderText = "本位码";
            this.bwmDataGridViewTextBoxColumn.Name = "bwmDataGridViewTextBoxColumn";
            this.bwmDataGridViewTextBoxColumn.ReadOnly = true;
            this.bwmDataGridViewTextBoxColumn.Width = 66;
            // 
            // medicineCodeNumber
            // 
            this.medicineCodeNumber.DataPropertyName = "medicineCodeNumber";
            this.medicineCodeNumber.HeaderText = "本位码（药监）";
            this.medicineCodeNumber.Name = "medicineCodeNumber";
            this.medicineCodeNumber.ReadOnly = true;
            this.medicineCodeNumber.Width = 83;
            // 
            // bzggDataGridViewTextBoxColumn
            // 
            this.bzggDataGridViewTextBoxColumn.DataPropertyName = "bzgg";
            this.bzggDataGridViewTextBoxColumn.HeaderText = "包装规格";
            this.bzggDataGridViewTextBoxColumn.Name = "bzggDataGridViewTextBoxColumn";
            this.bzggDataGridViewTextBoxColumn.ReadOnly = true;
            this.bzggDataGridViewTextBoxColumn.Width = 61;
            // 
            // scphDataGridViewTextBoxColumn
            // 
            this.scphDataGridViewTextBoxColumn.DataPropertyName = "scph";
            this.scphDataGridViewTextBoxColumn.HeaderText = "生产批号";
            this.scphDataGridViewTextBoxColumn.Name = "scphDataGridViewTextBoxColumn";
            this.scphDataGridViewTextBoxColumn.ReadOnly = true;
            this.scphDataGridViewTextBoxColumn.Width = 61;
            // 
            // scrqDataGridViewTextBoxColumn
            // 
            this.scrqDataGridViewTextBoxColumn.DataPropertyName = "scrq";
            this.scrqDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.scrqDataGridViewTextBoxColumn.Name = "scrqDataGridViewTextBoxColumn";
            this.scrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.scrqDataGridViewTextBoxColumn.Width = 61;
            // 
            // yxqzDataGridViewTextBoxColumn
            // 
            this.yxqzDataGridViewTextBoxColumn.DataPropertyName = "yxqz";
            this.yxqzDataGridViewTextBoxColumn.HeaderText = "有效期至";
            this.yxqzDataGridViewTextBoxColumn.Name = "yxqzDataGridViewTextBoxColumn";
            this.yxqzDataGridViewTextBoxColumn.ReadOnly = true;
            this.yxqzDataGridViewTextBoxColumn.Width = 61;
            // 
            // slDataGridViewTextBoxColumn
            // 
            this.slDataGridViewTextBoxColumn.DataPropertyName = "sl";
            this.slDataGridViewTextBoxColumn.HeaderText = "数量";
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            this.slDataGridViewTextBoxColumn.ReadOnly = true;
            this.slDataGridViewTextBoxColumn.Width = 51;
            // 
            // djmxBindingSource
            // 
            this.djmxBindingSource.DataSource = typeof(YaoJian.Models.yjj_qyjk_cgrk.djmx);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "is_check";
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 5;
            // 
            // djbhDataGridViewTextBoxColumn
            // 
            this.djbhDataGridViewTextBoxColumn.DataPropertyName = "djbh";
            this.djbhDataGridViewTextBoxColumn.HeaderText = "单据编号";
            this.djbhDataGridViewTextBoxColumn.Name = "djbhDataGridViewTextBoxColumn";
            this.djbhDataGridViewTextBoxColumn.ReadOnly = true;
            this.djbhDataGridViewTextBoxColumn.Width = 78;
            // 
            // rqrqDataGridViewTextBoxColumn
            // 
            this.rqrqDataGridViewTextBoxColumn.DataPropertyName = "rqrq";
            this.rqrqDataGridViewTextBoxColumn.HeaderText = "日期";
            this.rqrqDataGridViewTextBoxColumn.Name = "rqrqDataGridViewTextBoxColumn";
            this.rqrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.rqrqDataGridViewTextBoxColumn.Width = 54;
            // 
            // ghqyDataGridViewTextBoxColumn
            // 
            this.ghqyDataGridViewTextBoxColumn.DataPropertyName = "ghqy";
            this.ghqyDataGridViewTextBoxColumn.HeaderText = "供货企业";
            this.ghqyDataGridViewTextBoxColumn.Name = "ghqyDataGridViewTextBoxColumn";
            this.ghqyDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghqyDataGridViewTextBoxColumn.Width = 78;
            // 
            // xsdhDataGridViewTextBoxColumn
            // 
            this.xsdhDataGridViewTextBoxColumn.DataPropertyName = "xsdh";
            this.xsdhDataGridViewTextBoxColumn.HeaderText = "销售单号（供货方）";
            this.xsdhDataGridViewTextBoxColumn.Name = "xsdhDataGridViewTextBoxColumn";
            this.xsdhDataGridViewTextBoxColumn.ReadOnly = true;
            this.xsdhDataGridViewTextBoxColumn.Width = 94;
            // 
            // yssbDataGridViewTextBoxColumn
            // 
            this.yssbDataGridViewTextBoxColumn.DataPropertyName = "yssb";
            this.yssbDataGridViewTextBoxColumn.HeaderText = "运输设备";
            this.yssbDataGridViewTextBoxColumn.Name = "yssbDataGridViewTextBoxColumn";
            this.yssbDataGridViewTextBoxColumn.ReadOnly = true;
            this.yssbDataGridViewTextBoxColumn.Width = 61;
            // 
            // yskssjDataGridViewTextBoxColumn
            // 
            this.yskssjDataGridViewTextBoxColumn.DataPropertyName = "yskssj";
            this.yskssjDataGridViewTextBoxColumn.HeaderText = "运输开始时间";
            this.yskssjDataGridViewTextBoxColumn.Name = "yskssjDataGridViewTextBoxColumn";
            this.yskssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.yskssjDataGridViewTextBoxColumn.Width = 72;
            // 
            // ysjssjDataGridViewTextBoxColumn
            // 
            this.ysjssjDataGridViewTextBoxColumn.DataPropertyName = "ysjssj";
            this.ysjssjDataGridViewTextBoxColumn.HeaderText = "运输结束时间";
            this.ysjssjDataGridViewTextBoxColumn.Name = "ysjssjDataGridViewTextBoxColumn";
            this.ysjssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.ysjssjDataGridViewTextBoxColumn.Width = 72;
            // 
            // clrDataGridViewTextBoxColumn
            // 
            this.clrDataGridViewTextBoxColumn.DataPropertyName = "clr";
            this.clrDataGridViewTextBoxColumn.HeaderText = "验收员名称";
            this.clrDataGridViewTextBoxColumn.Name = "clrDataGridViewTextBoxColumn";
            this.clrDataGridViewTextBoxColumn.ReadOnly = true;
            this.clrDataGridViewTextBoxColumn.Width = 72;
            // 
            // ysjlDataGridViewTextBoxColumn
            // 
            this.ysjlDataGridViewTextBoxColumn.DataPropertyName = "ysjl";
            this.ysjlDataGridViewTextBoxColumn.HeaderText = "购进结论";
            this.ysjlDataGridViewTextBoxColumn.Name = "ysjlDataGridViewTextBoxColumn";
            this.ysjlDataGridViewTextBoxColumn.ReadOnly = true;
            this.ysjlDataGridViewTextBoxColumn.Width = 61;
            // 
            // yjjqyjkcgrkBindingSource
            // 
            this.yjjqyjkcgrkBindingSource.DataSource = typeof(YaoJian.Models.yjj_qyjk_cgrk);
            // 
            // CGRK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 692);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "CGRK";
            this.Text = "采购入库";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djmxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkcgrkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource yjjqyjkcgrkBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource djmxBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn djbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn bwmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineCodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bzggDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yxqzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn djbhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rqrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghqyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterPriceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsdhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yssbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yskssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ysjssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ysjlDataGridViewTextBoxColumn;
    }
}