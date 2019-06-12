namespace YaoJian
{
    partial class CG_CK
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
            this.ischeckDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.djbhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghqyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterPriceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yjjqyjkthckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.djbhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineCodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bzggDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yxqzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsdhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djmxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkthckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djmxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(177, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 21);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ischeckDataGridViewCheckBoxColumn,
            this.djbhDataGridViewTextBoxColumn,
            this.ckrqDataGridViewTextBoxColumn,
            this.ghqyDataGridViewTextBoxColumn,
            this.enterPriceName});
            this.dataGridView1.DataSource = this.yjjqyjkthckBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(771, 285);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ischeckDataGridViewCheckBoxColumn
            // 
            this.ischeckDataGridViewCheckBoxColumn.DataPropertyName = "is_check";
            this.ischeckDataGridViewCheckBoxColumn.HeaderText = "";
            this.ischeckDataGridViewCheckBoxColumn.Name = "ischeckDataGridViewCheckBoxColumn";
            // 
            // djbhDataGridViewTextBoxColumn
            // 
            this.djbhDataGridViewTextBoxColumn.DataPropertyName = "djbh";
            this.djbhDataGridViewTextBoxColumn.HeaderText = "单据编号";
            this.djbhDataGridViewTextBoxColumn.Name = "djbhDataGridViewTextBoxColumn";
            // 
            // ckrqDataGridViewTextBoxColumn
            // 
            this.ckrqDataGridViewTextBoxColumn.DataPropertyName = "ckrq";
            this.ckrqDataGridViewTextBoxColumn.HeaderText = "退货日期";
            this.ckrqDataGridViewTextBoxColumn.Name = "ckrqDataGridViewTextBoxColumn";
            // 
            // ghqyDataGridViewTextBoxColumn
            // 
            this.ghqyDataGridViewTextBoxColumn.DataPropertyName = "ghqy";
            this.ghqyDataGridViewTextBoxColumn.HeaderText = "供货企业";
            this.ghqyDataGridViewTextBoxColumn.Name = "ghqyDataGridViewTextBoxColumn";
            // 
            // enterPriceName
            // 
            this.enterPriceName.DataPropertyName = "enterPriceName";
            this.enterPriceName.HeaderText = "供货企业（药监）";
            this.enterPriceName.Name = "enterPriceName";
            // 
            // yjjqyjkthckBindingSource
            // 
            this.yjjqyjkthckBindingSource.DataSource = typeof(YaoJian.Models.yjj_qyjk_thck);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.djbhDataGridViewTextBoxColumn1,
            this.bwmDataGridViewTextBoxColumn,
            this.medicineCodeNumberDataGridViewTextBoxColumn,
            this.bzggDataGridViewTextBoxColumn,
            this.scphDataGridViewTextBoxColumn,
            this.scrqDataGridViewTextBoxColumn,
            this.yxqzDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.xsdhDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.djmxBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(17, 341);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(771, 224);
            this.dataGridView2.TabIndex = 14;
            // 
            // djbhDataGridViewTextBoxColumn1
            // 
            this.djbhDataGridViewTextBoxColumn1.DataPropertyName = "djbh";
            this.djbhDataGridViewTextBoxColumn1.HeaderText = "单据编号";
            this.djbhDataGridViewTextBoxColumn1.Name = "djbhDataGridViewTextBoxColumn1";
            this.djbhDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bwmDataGridViewTextBoxColumn
            // 
            this.bwmDataGridViewTextBoxColumn.DataPropertyName = "bwm";
            this.bwmDataGridViewTextBoxColumn.HeaderText = "本位码";
            this.bwmDataGridViewTextBoxColumn.Name = "bwmDataGridViewTextBoxColumn";
            this.bwmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicineCodeNumberDataGridViewTextBoxColumn
            // 
            this.medicineCodeNumberDataGridViewTextBoxColumn.DataPropertyName = "medicineCodeNumber";
            this.medicineCodeNumberDataGridViewTextBoxColumn.HeaderText = "本位码（药监）";
            this.medicineCodeNumberDataGridViewTextBoxColumn.Name = "medicineCodeNumberDataGridViewTextBoxColumn";
            this.medicineCodeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bzggDataGridViewTextBoxColumn
            // 
            this.bzggDataGridViewTextBoxColumn.DataPropertyName = "bzgg";
            this.bzggDataGridViewTextBoxColumn.HeaderText = "包装规格";
            this.bzggDataGridViewTextBoxColumn.Name = "bzggDataGridViewTextBoxColumn";
            this.bzggDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scphDataGridViewTextBoxColumn
            // 
            this.scphDataGridViewTextBoxColumn.DataPropertyName = "scph";
            this.scphDataGridViewTextBoxColumn.HeaderText = "生产批号";
            this.scphDataGridViewTextBoxColumn.Name = "scphDataGridViewTextBoxColumn";
            this.scphDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scrqDataGridViewTextBoxColumn
            // 
            this.scrqDataGridViewTextBoxColumn.DataPropertyName = "scrq";
            this.scrqDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.scrqDataGridViewTextBoxColumn.Name = "scrqDataGridViewTextBoxColumn";
            this.scrqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yxqzDataGridViewTextBoxColumn
            // 
            this.yxqzDataGridViewTextBoxColumn.DataPropertyName = "yxqz";
            this.yxqzDataGridViewTextBoxColumn.HeaderText = "有效期至";
            this.yxqzDataGridViewTextBoxColumn.Name = "yxqzDataGridViewTextBoxColumn";
            this.yxqzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slDataGridViewTextBoxColumn
            // 
            this.slDataGridViewTextBoxColumn.DataPropertyName = "sl";
            this.slDataGridViewTextBoxColumn.HeaderText = "数量";
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            this.slDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xsdhDataGridViewTextBoxColumn
            // 
            this.xsdhDataGridViewTextBoxColumn.DataPropertyName = "xsdh";
            this.xsdhDataGridViewTextBoxColumn.HeaderText = "销售单号";
            this.xsdhDataGridViewTextBoxColumn.Name = "xsdhDataGridViewTextBoxColumn";
            this.xsdhDataGridViewTextBoxColumn.ReadOnly = true;
            this.xsdhDataGridViewTextBoxColumn.ToolTipText = "供货企业随货单号";
            // 
            // djmxBindingSource
            // 
            this.djmxBindingSource.DataSource = typeof(YaoJian.Models.yjj_qyjk_thck.djmx);
            // 
            // CG_CK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "CG_CK";
            this.Text = "采购退货";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkthckBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource yjjqyjkthckBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ischeckDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djbhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghqyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterPriceName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn djbhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bwmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineCodeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bzggDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yxqzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsdhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource djmxBindingSource;
    }
}