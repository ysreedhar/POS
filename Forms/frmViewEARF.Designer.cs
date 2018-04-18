namespace POCS
{
    partial class frmViewEARF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewEARF));
            this.vEARFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POCS = new POCS.Ds.POCS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vEARFTableAdapter = new POCS.Ds.POCSTableAdapters.vEARFTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrders = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.pOHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pO_HeaderTableAdapter = new POCS.Ds.POCSTableAdapters.PO_HeaderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vEARFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vEARFBindingSource
            // 
            this.vEARFBindingSource.DataMember = "vEARF";
            this.vEARFBindingSource.DataSource = this.POCS;
            // 
            // POCS
            // 
            this.POCS.DataSetName = "POCS";
            this.POCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "POCS_vEARF";
            reportDataSource1.Value = this.vEARFBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POCS.Reports.ExpenseAssets.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(954, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // vEARFTableAdapter
            // 
            this.vEARFTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Purchase Order Number";
            // 
            // cboOrders
            // 
            this.cboOrders.DataSource = this.pOHeaderBindingSource;
            this.cboOrders.DisplayMember = "PO_OrderNo";
            this.cboOrders.FormattingEnabled = true;
            this.cboOrders.Location = new System.Drawing.Point(152, 12);
            this.cboOrders.Name = "cboOrders";
            this.cboOrders.Size = new System.Drawing.Size(121, 21);
            this.cboOrders.TabIndex = 2;
            this.cboOrders.ValueMember = "POID";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(289, 10);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pOHeaderBindingSource
            // 
            this.pOHeaderBindingSource.DataMember = "PO_Header";
            this.pOHeaderBindingSource.DataSource = this.POCS;
            // 
            // pO_HeaderTableAdapter
            // 
            this.pO_HeaderTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewEARF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 603);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrders);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewEARF";
            this.Text = "View Expense Asset Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewEARF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vEARFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOHeaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vEARFBindingSource;
        private POCS.Ds.POCS POCS;
        private POCS.Ds.POCSTableAdapters.vEARFTableAdapter vEARFTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrders;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.BindingSource pOHeaderBindingSource;
        private POCS.Ds.POCSTableAdapters.PO_HeaderTableAdapter pO_HeaderTableAdapter;
    }
}