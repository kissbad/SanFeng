namespace YaoJian
{
    partial class BHG
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
            this.yjjqyjkbhgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.djbhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bzggDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yxqzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfclDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkbhgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(172, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 21);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 21);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_check,
            this.djbhDataGridViewTextBoxColumn,
            this.bwmDataGridViewTextBoxColumn,
            this.bzggDataGridViewTextBoxColumn,
            this.scphDataGridViewTextBoxColumn,
            this.scrqDataGridViewTextBoxColumn,
            this.yxqzDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.yyDataGridViewTextBoxColumn,
            this.sfclDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yjjqyjkbhgBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(775, 398);
            this.dataGridView1.TabIndex = 17;
            // 
            // yjjqyjkbhgBindingSource
            // 
            this.yjjqyjkbhgBindingSource.DataSource = typeof(YaoJian.Models.yjj_qyjk_bhg);
            // 
            // is_check
            // 
            this.is_check.DataPropertyName = "is_check";
            this.is_check.HeaderText = "";
            this.is_check.Name = "is_check";
            // 
            // djbhDataGridViewTextBoxColumn
            // 
            this.djbhDataGridViewTextBoxColumn.DataPropertyName = "djbh";
            this.djbhDataGridViewTextBoxColumn.HeaderText = "单据编号";
            this.djbhDataGridViewTextBoxColumn.Name = "djbhDataGridViewTextBoxColumn";
            // 
            // bwmDataGridViewTextBoxColumn
            // 
            this.bwmDataGridViewTextBoxColumn.DataPropertyName = "bwm";
            this.bwmDataGridViewTextBoxColumn.HeaderText = "本位码";
            this.bwmDataGridViewTextBoxColumn.Name = "bwmDataGridViewTextBoxColumn";
            // 
            // bzggDataGridViewTextBoxColumn
            // 
            this.bzggDataGridViewTextBoxColumn.DataPropertyName = "bzgg";
            this.bzggDataGridViewTextBoxColumn.HeaderText = "包装规格";
            this.bzggDataGridViewTextBoxColumn.Name = "bzggDataGridViewTextBoxColumn";
            // 
            // scphDataGridViewTextBoxColumn
            // 
            this.scphDataGridViewTextBoxColumn.DataPropertyName = "scph";
            this.scphDataGridViewTextBoxColumn.HeaderText = "生产批号";
            this.scphDataGridViewTextBoxColumn.Name = "scphDataGridViewTextBoxColumn";
            // 
            // scrqDataGridViewTextBoxColumn
            // 
            this.scrqDataGridViewTextBoxColumn.DataPropertyName = "scrq";
            this.scrqDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.scrqDataGridViewTextBoxColumn.Name = "scrqDataGridViewTextBoxColumn";
            // 
            // yxqzDataGridViewTextBoxColumn
            // 
            this.yxqzDataGridViewTextBoxColumn.DataPropertyName = "yxqz";
            this.yxqzDataGridViewTextBoxColumn.HeaderText = "有效期至";
            this.yxqzDataGridViewTextBoxColumn.Name = "yxqzDataGridViewTextBoxColumn";
            // 
            // slDataGridViewTextBoxColumn
            // 
            this.slDataGridViewTextBoxColumn.DataPropertyName = "sl";
            this.slDataGridViewTextBoxColumn.HeaderText = "数量";
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            // 
            // yyDataGridViewTextBoxColumn
            // 
            this.yyDataGridViewTextBoxColumn.DataPropertyName = "yy";
            this.yyDataGridViewTextBoxColumn.HeaderText = "原因";
            this.yyDataGridViewTextBoxColumn.Name = "yyDataGridViewTextBoxColumn";
            // 
            // sfclDataGridViewTextBoxColumn
            // 
            this.sfclDataGridViewTextBoxColumn.DataPropertyName = "sfcl";
            this.sfclDataGridViewTextBoxColumn.HeaderText = "是否处理";
            this.sfclDataGridViewTextBoxColumn.Name = "sfclDataGridViewTextBoxColumn";
            // 
            // BHG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "BHG";
            this.Text = "不合格药品";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yjjqyjkbhgBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource yjjqyjkbhgBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn djbhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bwmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bzggDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yxqzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfclDataGridViewTextBoxColumn;
    }
}