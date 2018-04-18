namespace POCS.Forms
{
    partial class frmViewOrderSummary
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewOrderSummary));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rblSO = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rblPO = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.vPOSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.vPOSummaryTableAdapter = new POCS.Ds.POCSTableAdapters.vPOSummaryTableAdapter();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vPOSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "POCS_vPOSummary";
            reportDataSource1.Value = this.vPOSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POCS.Reports.OrderSummary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(978, 580);
            this.reportViewer1.TabIndex = 4;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(213, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(121, 21);
            this.dtpFromDate.TabIndex = 3;
            // 
            // rblSO
            // 
            this.rblSO.AutoSize = true;
            this.rblSO.Location = new System.Drawing.Point(124, 7);
            this.rblSO.Name = "rblSO";
            this.rblSO.Size = new System.Drawing.Size(39, 17);
            this.rblSO.TabIndex = 2;
            this.rblSO.Text = "SO";
            this.rblSO.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Type:";
            // 
            // rblPO
            // 
            this.rblPO.AutoSize = true;
            this.rblPO.Checked = true;
            this.rblPO.Location = new System.Drawing.Point(79, 7);
            this.rblPO.Name = "rblPO";
            this.rblPO.Size = new System.Drawing.Size(39, 17);
            this.rblPO.TabIndex = 1;
            this.rblPO.TabStop = true;
            this.rblPO.Text = "PO";
            this.rblPO.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(351, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // vPOSummaryBindingSource
            // 
            this.vPOSummaryBindingSource.DataMember = "vPOSummary";
            this.vPOSummaryBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPOSummaryTableAdapter
            // 
            this.vPOSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataSource = typeof(POCS.Buyer);
            // 
            // frmViewOrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 693);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.rblSO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rblPO);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewOrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewOrderSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vPOSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.BindingSource vPOSummaryBindingSource;
        private POCS.Ds.POCSTableAdapters.vPOSummaryTableAdapter vPOSummaryTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton rblSO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rblPO;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.BindingSource buyerBindingSource;
    }
}