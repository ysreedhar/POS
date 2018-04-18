namespace POCS.Forms
{
    partial class frmUpdateMsrStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMsrStatus));
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.tblMSRStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboMsrNo = new System.Windows.Forms.ComboBox();
            this.mSRStatusDescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblMSRStatusTableAdapter = new POCS.Ds.POCSTableAdapters.tblMSRStatusTableAdapter();
            this.mSRStatusDescTableAdapter = new POCS.Ds.POCSTableAdapters.MSRStatusDescTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblMSRStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSRStatusDescBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboStatus
            // 
            this.cboStatus.DataSource = this.tblMSRStatusBindingSource;
            this.cboStatus.DisplayMember = "StatusDesc";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(93, 51);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(131, 21);
            this.cboStatus.TabIndex = 1;
            this.cboStatus.ValueMember = "MSRStatus";
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // tblMSRStatusBindingSource
            // 
            this.tblMSRStatusBindingSource.DataMember = "tblMSRStatus";
            this.tblMSRStatusBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboMsrNo
            // 
            this.cboMsrNo.DataSource = this.mSRStatusDescBindingSource;
            this.cboMsrNo.DisplayMember = "MSRNo";
            this.cboMsrNo.FormattingEnabled = true;
            this.cboMsrNo.Location = new System.Drawing.Point(93, 19);
            this.cboMsrNo.Name = "cboMsrNo";
            this.cboMsrNo.Size = new System.Drawing.Size(131, 21);
            this.cboMsrNo.TabIndex = 0;
            this.cboMsrNo.ValueMember = "StatusDesc";
            this.cboMsrNo.SelectedIndexChanged += new System.EventHandler(this.cboMsrNo_SelectedIndexChanged);
            // 
            // mSRStatusDescBindingSource
            // 
            this.mSRStatusDescBindingSource.DataMember = "MSRStatusDesc";
            this.mSRStatusDescBindingSource.DataSource = this.pOCS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MSR No.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 91);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tblMSRStatusTableAdapter
            // 
            this.tblMSRStatusTableAdapter.ClearBeforeFill = true;
            // 
            // mSRStatusDescTableAdapter
            // 
            this.mSRStatusDescTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpdateMsrStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 132);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMsrNo);
            this.Controls.Add(this.cboStatus);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateMsrStatus";
            this.Text = "Update MSR Status";
            this.Load += new System.EventHandler(this.frmUpdateMsrStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMSRStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSRStatusDescBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboMsrNo;
        private System.Windows.Forms.Label label3;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource tblMSRStatusBindingSource;
        private POCS.Ds.POCSTableAdapters.tblMSRStatusTableAdapter tblMSRStatusTableAdapter;
        private System.Windows.Forms.BindingSource mSRStatusDescBindingSource;
        private POCS.Ds.POCSTableAdapters.MSRStatusDescTableAdapter mSRStatusDescTableAdapter;
    }
}