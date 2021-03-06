namespace POCS
{
    partial class frmReportMSRbyRequestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportMSRbyRequestor));
            this.vMSR_POIssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.vMSRPOIssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vMSR_POIssuedTableAdapter = new POCS.Ds.POCSTableAdapters.vMSR_POIssuedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vMSR_POIssuedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMSRPOIssuedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vMSR_POIssuedBindingSource
            // 
            this.vMSR_POIssuedBindingSource.DataMember = "vMSR_POIssued";
            this.vMSR_POIssuedBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vMSRPOIssuedBindingSource
            // 
            this.vMSRPOIssuedBindingSource.DataMember = "vMSR_POIssued";
            this.vMSRPOIssuedBindingSource.DataSource = this.pOCS;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapCollapsed = true;
            reportDataSource1.Name = "POCS_vMSR_POIssued";
            reportDataSource1.Value = this.vMSR_POIssuedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DisplayName = "MSR by Buyer";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POCS.Reports.MSRsByRequestor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(976, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "vMSR_POIssued";
            this.tableBindingSource.DataSource = this.pOCS;
            // 
            // vMSR_POIssuedTableAdapter
            // 
            this.vMSR_POIssuedTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportMSRbyRequestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 596);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportMSRbyRequestor";
            this.Text = "MSR Report by Requestor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vMSR_POIssuedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMSRPOIssuedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private POCS.Ds.POCS pOCS;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private POCS.Ds.POCSTableAdapters.vMSR_POIssuedTableAdapter vMSR_POIssuedTableAdapter;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.BindingSource vMSRPOIssuedBindingSource;
        private System.Windows.Forms.BindingSource vMSR_POIssuedBindingSource;
    }
}

