namespace YaoJian
{
    partial class FileDeal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dowloadFileDealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowloadFileDealBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdDataGridViewTextBoxColumn,
            this.dealStatusDataGridViewTextBoxColumn,
            this.dealResultDataGridViewTextBoxColumn,
            this.dealDescDataGridViewTextBoxColumn,
            this.dealTimeDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dowloadFileDealBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // dowloadFileDealBindingSource
            // 
            this.dowloadFileDealBindingSource.DataSource = typeof(YaoJian.Models.DowloadFileDeal);
            // 
            // fileIdDataGridViewTextBoxColumn
            // 
            this.fileIdDataGridViewTextBoxColumn.DataPropertyName = "fileId";
            this.fileIdDataGridViewTextBoxColumn.HeaderText = "文件ID";
            this.fileIdDataGridViewTextBoxColumn.Name = "fileIdDataGridViewTextBoxColumn";
            this.fileIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealStatusDataGridViewTextBoxColumn
            // 
            this.dealStatusDataGridViewTextBoxColumn.DataPropertyName = "dealStatus";
            this.dealStatusDataGridViewTextBoxColumn.HeaderText = "处理状态";
            this.dealStatusDataGridViewTextBoxColumn.Name = "dealStatusDataGridViewTextBoxColumn";
            this.dealStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealResultDataGridViewTextBoxColumn
            // 
            this.dealResultDataGridViewTextBoxColumn.DataPropertyName = "dealResult";
            this.dealResultDataGridViewTextBoxColumn.HeaderText = "处理结果代码";
            this.dealResultDataGridViewTextBoxColumn.Name = "dealResultDataGridViewTextBoxColumn";
            this.dealResultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealDescDataGridViewTextBoxColumn
            // 
            this.dealDescDataGridViewTextBoxColumn.DataPropertyName = "dealDesc";
            this.dealDescDataGridViewTextBoxColumn.HeaderText = "处理结果描述";
            this.dealDescDataGridViewTextBoxColumn.Name = "dealDescDataGridViewTextBoxColumn";
            this.dealDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealTimeDataGridViewTextBoxColumn
            // 
            this.dealTimeDataGridViewTextBoxColumn.DataPropertyName = "dealTime";
            this.dealTimeDataGridViewTextBoxColumn.HeaderText = "处理时间";
            this.dealTimeDataGridViewTextBoxColumn.Name = "dealTimeDataGridViewTextBoxColumn";
            this.dealTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FileDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FileDeal";
            this.Text = "FileDeal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowloadFileDealBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dowloadFileDealBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
    }
}