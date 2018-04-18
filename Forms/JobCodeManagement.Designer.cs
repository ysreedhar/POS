namespace POCS.Forms
{
    partial class JobCodeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobCodeManagement));
            this.dgvJobCode = new System.Windows.Forms.DataGridView();
            this.chIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnoDataGridViewTextBoxColumn = new DataGridViewAutoFilterTextBoxColumn();
            this.subjobnoDataGridViewTextBoxColumn = new DataGridViewAutoFilterTextBoxColumn();
            this.jobnodescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjobnodescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblJobChargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tblJobChargeTableAdapter = new POCS.Ds.POCSTableAdapters.tblJobChargeTableAdapter();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.filterStatusLabel = new System.Windows.Forms.Label();
            this.showAllLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobChargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobCode
            // 
            this.dgvJobCode.AutoGenerateColumns = false;
            this.dgvJobCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chIDDataGridViewTextBoxColumn,
            this.jobcodeDataGridViewTextBoxColumn,
            this.jobnoDataGridViewTextBoxColumn,
            this.subjobnoDataGridViewTextBoxColumn,
            this.jobnodescDataGridViewTextBoxColumn,
            this.subjobnodescDataGridViewTextBoxColumn});
            this.dgvJobCode.DataSource = this.tblJobChargeBindingSource;
            this.dgvJobCode.Location = new System.Drawing.Point(12, 38);
            this.dgvJobCode.Name = "dgvJobCode";
            this.dgvJobCode.Size = new System.Drawing.Size(1015, 610);
            this.dgvJobCode.TabIndex = 0;
            this.dgvJobCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOrders_KeyDown);
            this.dgvJobCode.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrders_DataBindingComplete);
            // 
            // chIDDataGridViewTextBoxColumn
            // 
            this.chIDDataGridViewTextBoxColumn.DataPropertyName = "ChID";
            this.chIDDataGridViewTextBoxColumn.HeaderText = "ChID";
            this.chIDDataGridViewTextBoxColumn.Name = "chIDDataGridViewTextBoxColumn";
            this.chIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.chIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // jobcodeDataGridViewTextBoxColumn
            // 
            this.jobcodeDataGridViewTextBoxColumn.DataPropertyName = "job_code";
            this.jobcodeDataGridViewTextBoxColumn.HeaderText = "Job Code";
            this.jobcodeDataGridViewTextBoxColumn.Name = "jobcodeDataGridViewTextBoxColumn";
            this.jobcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobnoDataGridViewTextBoxColumn
            // 
            this.jobnoDataGridViewTextBoxColumn.DataPropertyName = "jobno";
            this.jobnoDataGridViewTextBoxColumn.HeaderText = "Jobno";
            this.jobnoDataGridViewTextBoxColumn.Name = "jobnoDataGridViewTextBoxColumn";
            // 
            // subjobnoDataGridViewTextBoxColumn
            // 
            this.subjobnoDataGridViewTextBoxColumn.DataPropertyName = "subjobno";
            this.subjobnoDataGridViewTextBoxColumn.HeaderText = "Sub Job No.";
            this.subjobnoDataGridViewTextBoxColumn.Name = "subjobnoDataGridViewTextBoxColumn";
            // 
            // jobnodescDataGridViewTextBoxColumn
            // 
            this.jobnodescDataGridViewTextBoxColumn.DataPropertyName = "jobno_desc";
            this.jobnodescDataGridViewTextBoxColumn.HeaderText = "Job No. Desc.";
            this.jobnodescDataGridViewTextBoxColumn.Name = "jobnodescDataGridViewTextBoxColumn";
            this.jobnodescDataGridViewTextBoxColumn.Width = 300;
            // 
            // subjobnodescDataGridViewTextBoxColumn
            // 
            this.subjobnodescDataGridViewTextBoxColumn.DataPropertyName = "subjobno_desc";
            this.subjobnodescDataGridViewTextBoxColumn.HeaderText = "Sub Job No. Desc";
            this.subjobnodescDataGridViewTextBoxColumn.Name = "subjobnodescDataGridViewTextBoxColumn";
            this.subjobnodescDataGridViewTextBoxColumn.Width = 300;
            // 
            // tblJobChargeBindingSource
            // 
            this.tblJobChargeBindingSource.DataMember = "tblJobCharge";
            this.tblJobChargeBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Code Listing";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(945, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tblJobChargeTableAdapter
            // 
            this.tblJobChargeTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(864, 9);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // filterStatusLabel
            // 
            this.filterStatusLabel.AutoSize = true;
            this.filterStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterStatusLabel.Location = new System.Drawing.Point(62, 650);
            this.filterStatusLabel.Name = "filterStatusLabel";
            this.filterStatusLabel.Size = new System.Drawing.Size(65, 13);
            this.filterStatusLabel.TabIndex = 4;
            this.filterStatusLabel.Text = "Filter Status";
            this.filterStatusLabel.Visible = false;
            // 
            // showAllLabel
            // 
            this.showAllLabel.AutoSize = true;
            this.showAllLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAllLabel.Location = new System.Drawing.Point(9, 651);
            this.showAllLabel.Name = "showAllLabel";
            this.showAllLabel.Size = new System.Drawing.Size(47, 13);
            this.showAllLabel.TabIndex = 3;
            this.showAllLabel.Text = "Show All";
            this.showAllLabel.Visible = false;
            this.showAllLabel.Click += new System.EventHandler(this.showAllLabel_Click);
            // 
            // JobCodeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 708);
            this.Controls.Add(this.filterStatusLabel);
            this.Controls.Add(this.showAllLabel);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJobCode);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobCodeManagement";
            this.Text = "Add and Maintain Job Code";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JobCodeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobChargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobCode;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource tblJobChargeBindingSource;
        private POCS.Ds.POCSTableAdapters.tblJobChargeTableAdapter tblJobChargeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobcodeDataGridViewTextBoxColumn;
        private POCS.DataGridViewAutoFilterTextBoxColumn jobnoDataGridViewTextBoxColumn;
        private POCS.DataGridViewAutoFilterTextBoxColumn subjobnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnodescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjobnodescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label filterStatusLabel;
        private System.Windows.Forms.Label showAllLabel;
    }
}