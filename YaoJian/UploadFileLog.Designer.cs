namespace YaoJian
{
    partial class UploadFileLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.query_results = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wqhyjUploadFileLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wqhyjUploadFileLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.uploadtimeDataGridViewTextBoxColumn,
            this.uploadtypeDataGridViewTextBoxColumn,
            this.uploadstateDataGridViewTextBoxColumn,
            this.fidDataGridViewTextBoxColumn,
            this.query_results});
            this.dataGridView1.DataSource = this.wqhyjUploadFileLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // query_results
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "查询结果";
            this.query_results.DefaultCellStyle = dataGridViewCellStyle2;
            this.query_results.HeaderText = "查询结果";
            this.query_results.Name = "query_results";
            this.query_results.ReadOnly = true;
            this.query_results.Text = "";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.NullValue = "查询结果";
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // uploadtimeDataGridViewTextBoxColumn
            // 
            this.uploadtimeDataGridViewTextBoxColumn.DataPropertyName = "upload_time";
            this.uploadtimeDataGridViewTextBoxColumn.HeaderText = "上传时间";
            this.uploadtimeDataGridViewTextBoxColumn.Name = "uploadtimeDataGridViewTextBoxColumn";
            this.uploadtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uploadtypeDataGridViewTextBoxColumn
            // 
            this.uploadtypeDataGridViewTextBoxColumn.DataPropertyName = "upload_type";
            this.uploadtypeDataGridViewTextBoxColumn.HeaderText = "业务类型";
            this.uploadtypeDataGridViewTextBoxColumn.Name = "uploadtypeDataGridViewTextBoxColumn";
            this.uploadtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uploadstateDataGridViewTextBoxColumn
            // 
            this.uploadstateDataGridViewTextBoxColumn.DataPropertyName = "upload_state";
            this.uploadstateDataGridViewTextBoxColumn.HeaderText = "上传状态";
            this.uploadstateDataGridViewTextBoxColumn.Name = "uploadstateDataGridViewTextBoxColumn";
            this.uploadstateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "fid";
            this.fidDataGridViewTextBoxColumn.HeaderText = "文件ID";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wqhyjUploadFileLogBindingSource
            // 
            this.wqhyjUploadFileLogBindingSource.DataSource = typeof(YaoJian.Models.wqh_yj_UploadFileLog);
            // 
            // UploadFileLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UploadFileLog";
            this.Text = "上传历史";
            this.Load += new System.EventHandler(this.get_data);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wqhyjUploadFileLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wqhyjUploadFileLogBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn query_results;
    }
}