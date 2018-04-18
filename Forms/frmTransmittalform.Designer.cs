namespace POCS.Forms
{
    partial class frmTransmittalform
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
            System.Windows.Forms.Label AddressLabel;
            System.Windows.Forms.Label NameLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransmittalform));
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cblInvoices = new System.Windows.Forms.CheckedListBox();
            this.CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POCS = new POCS.Ds.POCS();
            this.CompanyTableAdapter = new POCS.Ds.POCSTableAdapters.CompanyTableAdapter();
            this.dtpTransmittalDate = new System.Windows.Forms.DateTimePicker();
            AddressLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POCS)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(13, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(110, 19);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Transmit to:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(13, 111);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 19);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Invoices:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(171, 61);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(423, 21);
            this.txtDepartment.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(423, 21);
            this.txtName.TabIndex = 3;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new System.Drawing.Point(80, 65);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new System.Drawing.Size(68, 13);
            AddressLabel.TabIndex = 4;
            AddressLabel.Text = "Department:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(80, 37);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(38, 13);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // viewReportButton
            // 
            this.viewReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewReportButton.Location = new System.Drawing.Point(470, 268);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(124, 23);
            this.viewReportButton.TabIndex = 1;
            this.viewReportButton.Text = "Generate Transmittal";
            this.viewReportButton.UseVisualStyleBackColor = true;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "POCS_Company";
            reportDataSource1.Value = this.CompanyBindingSource;
            this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer1.LocalReport.DisplayName = "Invoice";
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "POCS.Reports.rptTranmittalForm.rdlc";
            this.ReportViewer1.Location = new System.Drawing.Point(3, 307);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.Size = new System.Drawing.Size(700, 266);
            this.ReportViewer1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.AutoScroll = true;
            this.Panel2.Controls.Add(this.dtpTransmittalDate);
            this.Panel2.Controls.Add(this.cblInvoices);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(label3);
            this.Panel2.Controls.Add(AddressLabel);
            this.Panel2.Controls.Add(this.txtDepartment);
            this.Panel2.Controls.Add(NameLabel);
            this.Panel2.Controls.Add(this.txtName);
            this.Panel2.Controls.Add(this.viewReportButton);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(700, 298);
            this.Panel2.TabIndex = 2;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.ReportViewer1, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(706, 576);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // cblInvoices
            // 
            this.cblInvoices.FormattingEnabled = true;
            this.cblInvoices.Location = new System.Drawing.Point(171, 130);
            this.cblInvoices.Name = "cblInvoices";
            this.cblInvoices.Size = new System.Drawing.Size(423, 132);
            this.cblInvoices.TabIndex = 14;
            // 
            // CompanyBindingSource
            // 
            this.CompanyBindingSource.DataMember = "Company";
            this.CompanyBindingSource.DataSource = this.POCS;
            // 
            // POCS
            // 
            this.POCS.DataSetName = "POCS";
            this.POCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CompanyTableAdapter
            // 
            this.CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(80, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 13);
            label3.TabIndex = 4;
            label3.Text = "Transmittal Date:";
            // 
            // dtpTransmittalDate
            // 
            this.dtpTransmittalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTransmittalDate.Location = new System.Drawing.Point(171, 89);
            this.dtpTransmittalDate.Name = "dtpTransmittalDate";
            this.dtpTransmittalDate.Size = new System.Drawing.Size(94, 21);
            this.dtpTransmittalDate.TabIndex = 15;
            // 
            // frmTransmittalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 576);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransmittalform";
            this.Text = "Invoice Transmittal";
            this.Load += new System.EventHandler(this.frmTransmittalform_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDepartment;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Button viewReportButton;
        internal Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox cblInvoices;
        private System.Windows.Forms.BindingSource CompanyBindingSource;
        private POCS.Ds.POCS POCS;
        private POCS.Ds.POCSTableAdapters.CompanyTableAdapter CompanyTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpTransmittalDate;
    }
}