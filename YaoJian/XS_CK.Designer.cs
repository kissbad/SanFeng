namespace YaoJian
{
    partial class XS_CK
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yjjqyjkpfckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.djmxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.djbhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgqyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dwmchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ysfsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yskssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ysjssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djbhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterPriceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bzggDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yxqzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkpfckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djmxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 21);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 21);
            this.dateTimePicker1.TabIndex = 5;
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
            this.is_check,
            this.djbhDataGridViewTextBoxColumn,
            this.ckrqDataGridViewTextBoxColumn,
            this.cgqyDataGridViewTextBoxColumn,
            this.dwmchDataGridViewTextBoxColumn,
            this.ysfsDataGridViewTextBoxColumn,
            this.yskssjDataGridViewTextBoxColumn,
            this.ysjssjDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yjjqyjkpfckBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 309);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yjjqyjkpfckBindingSource
            // 
            this.yjjqyjkpfckBindingSource.DataSource = typeof(YaoJian.Models.yjj_qyjk_pfck);
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
            this.djbhDataGridViewTextBoxColumn1,
            this.bwmDataGridViewTextBoxColumn,
            this.enterPriceNameDataGridViewTextBoxColumn,
            this.bzggDataGridViewTextBoxColumn,
            this.scphDataGridViewTextBoxColumn,
            this.scrqDataGridViewTextBoxColumn,
            this.yxqzDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.bzDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.djmxBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(28, 389);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(760, 217);
            this.dataGridView2.TabIndex = 10;
            // 
            // djmxBindingSource
            // 
            this.djmxBindingSource.DataSource = typeof(YaoJian.Models.yjj_qyjk_pfck.djmx);
            // 
            // is_check
            // 
            this.is_check.DataPropertyName = "is_check";
            this.is_check.HeaderText = "";
            this.is_check.Name = "is_check";
            this.is_check.Width = 5;
            // 
            // djbhDataGridViewTextBoxColumn
            // 
            this.djbhDataGridViewTextBoxColumn.DataPropertyName = "djbh";
            this.djbhDataGridViewTextBoxColumn.HeaderText = "单据编号";
            this.djbhDataGridViewTextBoxColumn.Name = "djbhDataGridViewTextBoxColumn";
            this.djbhDataGridViewTextBoxColumn.ReadOnly = true;
            this.djbhDataGridViewTextBoxColumn.Width = 78;
            // 
            // ckrqDataGridViewTextBoxColumn
            // 
            this.ckrqDataGridViewTextBoxColumn.DataPropertyName = "ckrq";
            this.ckrqDataGridViewTextBoxColumn.HeaderText = "出库日期";
            this.ckrqDataGridViewTextBoxColumn.Name = "ckrqDataGridViewTextBoxColumn";
            this.ckrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.ckrqDataGridViewTextBoxColumn.Width = 78;
            // 
            // cgqyDataGridViewTextBoxColumn
            // 
            this.cgqyDataGridViewTextBoxColumn.DataPropertyName = "cgqy";
            this.cgqyDataGridViewTextBoxColumn.HeaderText = "采购企业";
            this.cgqyDataGridViewTextBoxColumn.Name = "cgqyDataGridViewTextBoxColumn";
            this.cgqyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cgqyDataGridViewTextBoxColumn.Width = 78;
            // 
            // dwmchDataGridViewTextBoxColumn
            // 
            this.dwmchDataGridViewTextBoxColumn.DataPropertyName = "enterPriceName";
            this.dwmchDataGridViewTextBoxColumn.HeaderText = "采购企业（药监）";
            this.dwmchDataGridViewTextBoxColumn.Name = "dwmchDataGridViewTextBoxColumn";
            this.dwmchDataGridViewTextBoxColumn.ReadOnly = true;
            this.dwmchDataGridViewTextBoxColumn.Width = 83;
            // 
            // ysfsDataGridViewTextBoxColumn
            // 
            this.ysfsDataGridViewTextBoxColumn.DataPropertyName = "ysfs";
            this.ysfsDataGridViewTextBoxColumn.HeaderText = "运输方式";
            this.ysfsDataGridViewTextBoxColumn.Name = "ysfsDataGridViewTextBoxColumn";
            this.ysfsDataGridViewTextBoxColumn.ReadOnly = true;
            this.ysfsDataGridViewTextBoxColumn.Width = 61;
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
            // djbhDataGridViewTextBoxColumn1
            // 
            this.djbhDataGridViewTextBoxColumn1.DataPropertyName = "djbh";
            this.djbhDataGridViewTextBoxColumn1.HeaderText = "单据编号";
            this.djbhDataGridViewTextBoxColumn1.Name = "djbhDataGridViewTextBoxColumn1";
            this.djbhDataGridViewTextBoxColumn1.ReadOnly = true;
            this.djbhDataGridViewTextBoxColumn1.Width = 78;
            // 
            // bwmDataGridViewTextBoxColumn
            // 
            this.bwmDataGridViewTextBoxColumn.DataPropertyName = "bwm";
            this.bwmDataGridViewTextBoxColumn.HeaderText = "本位码";
            this.bwmDataGridViewTextBoxColumn.Name = "bwmDataGridViewTextBoxColumn";
            this.bwmDataGridViewTextBoxColumn.ReadOnly = true;
            this.bwmDataGridViewTextBoxColumn.Width = 66;
            // 
            // enterPriceNameDataGridViewTextBoxColumn
            // 
            this.enterPriceNameDataGridViewTextBoxColumn.DataPropertyName = "medicineCodeNumber";
            this.enterPriceNameDataGridViewTextBoxColumn.HeaderText = "本位码（药监）";
            this.enterPriceNameDataGridViewTextBoxColumn.Name = "enterPriceNameDataGridViewTextBoxColumn";
            this.enterPriceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.enterPriceNameDataGridViewTextBoxColumn.Width = 83;
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
            // bzDataGridViewTextBoxColumn
            // 
            this.bzDataGridViewTextBoxColumn.DataPropertyName = "bz";
            this.bzDataGridViewTextBoxColumn.HeaderText = "备注";
            this.bzDataGridViewTextBoxColumn.Name = "bzDataGridViewTextBoxColumn";
            this.bzDataGridViewTextBoxColumn.ReadOnly = true;
            this.bzDataGridViewTextBoxColumn.Width = 51;
            // 
            // XS_CK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "XS_CK";
            this.Text = "销售出库上传";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkpfckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djmxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource yjjqyjkpfckBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource djmxBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn djbhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgqyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dwmchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ysfsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yskssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ysjssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djbhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bwmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterPriceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bzggDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yxqzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bzDataGridViewTextBoxColumn;
    }
}