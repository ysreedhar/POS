namespace POCS
{
    partial class frmPrintOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintOrder));
            this.PO_HeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PO_HeaderTableAdapter = new POCS.Ds.POCSTableAdapters.PO_HeaderTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrders = new System.Windows.Forms.ComboBox();
            this.pOHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.vPOdetailsCalculationTableAdapter = new POCS.Ds.POCSTableAdapters.vPOdetailsCalculationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PO_HeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PO_HeaderBindingSource
            // 
            this.PO_HeaderBindingSource.DataMember = "PO_Header";
            this.PO_HeaderBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "pOCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "PO_header";
            this.OrdersBindingSource.DataSource = this.pOCS;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "POCS_PO_Header";
            reportDataSource1.Value = this.PO_HeaderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POCS.Reports.Orders.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 610);
            this.reportViewer1.TabIndex = 0;
            // 
            // OrderDetailsBindingSource
            // 
            this.OrderDetailsBindingSource.DataMember = "vPOdetailsCalculation";
            this.OrderDetailsBindingSource.DataSource = this.pOCS;
            // 
            // PO_HeaderTableAdapter
            // 
            this.PO_HeaderTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
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
            this.cboOrders.Location = new System.Drawing.Point(150, 13);
            this.cboOrders.Name = "cboOrders";
            this.cboOrders.Size = new System.Drawing.Size(121, 21);
            this.cboOrders.TabIndex = 2;
            this.cboOrders.ValueMember = "POID";
            // 
            // pOHeaderBindingSource
            // 
            this.pOHeaderBindingSource.DataMember = "PO_Header";
            this.pOHeaderBindingSource.DataSource = this.pOCS;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(278, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "View";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // vPOdetailsCalculationTableAdapter
            // 
            this.vPOdetailsCalculationTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 746);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrders);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PO_HeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOHeaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POCS.Ds.POCS pOCS;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private System.Windows.Forms.BindingSource OrderDetailsBindingSource;
        private System.Windows.Forms.BindingSource PO_HeaderBindingSource;
        private POCS.Ds.POCSTableAdapters.PO_HeaderTableAdapter PO_HeaderTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrders;
        private System.Windows.Forms.Button btnShow;
        private POCS.Ds.POCSTableAdapters.vPOdetailsCalculationTableAdapter vPOdetailsCalculationTableAdapter;
        private System.Windows.Forms.BindingSource pOHeaderBindingSource;
        
    }
}

