using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using POCS.UI;

namespace POCS
{
	public class WelcomePage : POCS.UI.ExternalWizardPage
	{
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label introductionLabel;
		private System.Windows.Forms.Label promptLabel;
        public GroupBox Frame1;
        public ComboBox cboChargeType;
        public ComboBox cboDeliveryPoint;
        public ComboBox cboVendorName;
        public TextBox txtCurrency;
        public TextBox txtDeliveryTerms;
        public TextBox txtRemarks;
        public TextBox txtApprovedBy;
        public TextBox txtOrderedBy;
        public TextBox txtCostCenter;
        public TextBox txtReqOrderNo;
        public TextBox txtPONumber;
        public TextBox txtAddress;
        public Label Label14;
        public Label Label13;
        public Label Label12;
        public Label Label10;
        public Label Label9;
        public Label Label8;
        public Label Label7;
        public Label Label6;
        public Label Label5;
        public Label Label4;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        private DateTimePicker dateTimePicker1;
		private System.ComponentModel.IContainer components = null;

		public WelcomePage()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.titleLabel = new System.Windows.Forms.Label();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.cboChargeType = new System.Windows.Forms.ComboBox();
            this.cboDeliveryPoint = new System.Windows.Forms.ComboBox();
            this.cboVendorName = new System.Windows.Forms.ComboBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtDeliveryTerms = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.txtOrderedBy = new System.Windows.Forms.TextBox();
            this.txtCostCenter = new System.Windows.Forms.TextBox();
            this.txtReqOrderNo = new System.Windows.Forms.TextBox();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.Size = new System.Drawing.Size(165, 541);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(176, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(694, 28);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Issue New PO";
            // 
            // introductionLabel
            // 
            this.introductionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.introductionLabel.Location = new System.Drawing.Point(176, 40);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(694, 44);
            this.introductionLabel.TabIndex = 2;
            this.introductionLabel.Text = "Please Key in the Purchase Order Information.";
            // 
            // promptLabel
            // 
            this.promptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.promptLabel.Location = new System.Drawing.Point(176, 517);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(694, 16);
            this.promptLabel.TabIndex = 3;
            this.promptLabel.Text = "Press Next to continue.";
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.dateTimePicker1);
            this.Frame1.Controls.Add(this.cboChargeType);
            this.Frame1.Controls.Add(this.cboDeliveryPoint);
            this.Frame1.Controls.Add(this.cboVendorName);
            this.Frame1.Controls.Add(this.txtCurrency);
            this.Frame1.Controls.Add(this.txtDeliveryTerms);
            this.Frame1.Controls.Add(this.txtRemarks);
            this.Frame1.Controls.Add(this.txtApprovedBy);
            this.Frame1.Controls.Add(this.txtOrderedBy);
            this.Frame1.Controls.Add(this.txtCostCenter);
            this.Frame1.Controls.Add(this.txtReqOrderNo);
            this.Frame1.Controls.Add(this.txtPONumber);
            this.Frame1.Controls.Add(this.txtAddress);
            this.Frame1.Controls.Add(this.Label14);
            this.Frame1.Controls.Add(this.Label13);
            this.Frame1.Controls.Add(this.Label12);
            this.Frame1.Controls.Add(this.Label10);
            this.Frame1.Controls.Add(this.Label9);
            this.Frame1.Controls.Add(this.Label8);
            this.Frame1.Controls.Add(this.Label7);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(180, 55);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(689, 449);
            this.Frame1.TabIndex = 4;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Purchase Order";
            // 
            // cboChargeType
            // 
            this.cboChargeType.BackColor = System.Drawing.SystemColors.Window;
            this.cboChargeType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboChargeType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChargeType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboChargeType.Items.AddRange(new object[] {
            "NA",
            "DR",
            "LS",
            "AC",
            "CP"});
            this.cboChargeType.Location = new System.Drawing.Point(472, 256);
            this.cboChargeType.Name = "cboChargeType";
            this.cboChargeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChargeType.Size = new System.Drawing.Size(49, 22);
            this.cboChargeType.TabIndex = 30;
            this.cboChargeType.Text = "NA";
            // 
            // cboDeliveryPoint
            // 
            this.cboDeliveryPoint.BackColor = System.Drawing.SystemColors.Window;
            this.cboDeliveryPoint.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboDeliveryPoint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeliveryPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboDeliveryPoint.Location = new System.Drawing.Point(472, 220);
            this.cboDeliveryPoint.Name = "cboDeliveryPoint";
            this.cboDeliveryPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboDeliveryPoint.Size = new System.Drawing.Size(209, 22);
            this.cboDeliveryPoint.TabIndex = 28;
            // 
            // cboVendorName
            // 
            this.cboVendorName.BackColor = System.Drawing.SystemColors.Window;
            this.cboVendorName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVendorName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendorName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVendorName.Location = new System.Drawing.Point(80, 24);
            this.cboVendorName.Name = "cboVendorName";
            this.cboVendorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVendorName.Size = new System.Drawing.Size(305, 22);
            this.cboVendorName.TabIndex = 27;
            // 
            // txtCurrency
            // 
            this.txtCurrency.AcceptsReturn = true;
            this.txtCurrency.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrency.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurrency.Location = new System.Drawing.Point(472, 176);
            this.txtCurrency.MaxLength = 0;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrency.Size = new System.Drawing.Size(33, 20);
            this.txtCurrency.TabIndex = 25;
            this.txtCurrency.Text = "RM";
            // 
            // txtDeliveryTerms
            // 
            this.txtDeliveryTerms.AcceptsReturn = true;
            this.txtDeliveryTerms.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeliveryTerms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryTerms.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryTerms.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDeliveryTerms.Location = new System.Drawing.Point(11, 349);
            this.txtDeliveryTerms.MaxLength = 0;
            this.txtDeliveryTerms.Multiline = true;
            this.txtDeliveryTerms.Name = "txtDeliveryTerms";
            this.txtDeliveryTerms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeliveryTerms.Size = new System.Drawing.Size(670, 94);
            this.txtDeliveryTerms.TabIndex = 18;
            // 
            // txtRemarks
            // 
            this.txtRemarks.AcceptsReturn = true;
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRemarks.Location = new System.Drawing.Point(80, 184);
            this.txtRemarks.MaxLength = 0;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemarks.Size = new System.Drawing.Size(305, 20);
            this.txtRemarks.TabIndex = 16;
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.AcceptsReturn = true;
            this.txtApprovedBy.BackColor = System.Drawing.SystemColors.Window;
            this.txtApprovedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApprovedBy.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApprovedBy.Location = new System.Drawing.Point(472, 144);
            this.txtApprovedBy.MaxLength = 0;
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApprovedBy.Size = new System.Drawing.Size(209, 20);
            this.txtApprovedBy.TabIndex = 14;
            // 
            // txtOrderedBy
            // 
            this.txtOrderedBy.AcceptsReturn = true;
            this.txtOrderedBy.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderedBy.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderedBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOrderedBy.Location = new System.Drawing.Point(472, 112);
            this.txtOrderedBy.MaxLength = 0;
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOrderedBy.Size = new System.Drawing.Size(209, 20);
            this.txtOrderedBy.TabIndex = 12;
            // 
            // txtCostCenter
            // 
            this.txtCostCenter.AcceptsReturn = true;
            this.txtCostCenter.BackColor = System.Drawing.SystemColors.Window;
            this.txtCostCenter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostCenter.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostCenter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCostCenter.Location = new System.Drawing.Point(472, 80);
            this.txtCostCenter.MaxLength = 0;
            this.txtCostCenter.Name = "txtCostCenter";
            this.txtCostCenter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCostCenter.Size = new System.Drawing.Size(209, 20);
            this.txtCostCenter.TabIndex = 10;
            // 
            // txtReqOrderNo
            // 
            this.txtReqOrderNo.AcceptsReturn = true;
            this.txtReqOrderNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtReqOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReqOrderNo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqOrderNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReqOrderNo.Location = new System.Drawing.Point(472, 48);
            this.txtReqOrderNo.MaxLength = 0;
            this.txtReqOrderNo.Name = "txtReqOrderNo";
            this.txtReqOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReqOrderNo.Size = new System.Drawing.Size(89, 20);
            this.txtReqOrderNo.TabIndex = 8;
            // 
            // txtPONumber
            // 
            this.txtPONumber.AcceptsReturn = true;
            this.txtPONumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPONumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPONumber.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPONumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPONumber.Location = new System.Drawing.Point(80, 144);
            this.txtPONumber.MaxLength = 0;
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPONumber.Size = new System.Drawing.Size(305, 20);
            this.txtPONumber.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(80, 56);
            this.txtAddress.MaxLength = 0;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(305, 81);
            this.txtAddress.TabIndex = 3;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.SystemColors.Control;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(400, 260);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(69, 14);
            this.Label14.TabIndex = 31;
            this.Label14.Text = "Charge Type";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.SystemColors.Control;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(400, 224);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(72, 14);
            this.Label13.TabIndex = 29;
            this.Label13.Text = "Delivery Point";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.SystemColors.Control;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(400, 184);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(52, 14);
            this.Label12.TabIndex = 26;
            this.Label12.Text = "Currency";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.SystemColors.Control;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(8, 332);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(79, 14);
            this.Label10.TabIndex = 17;
            this.Label10.Text = "Delivery Terms";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.SystemColors.Control;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(8, 192);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(49, 14);
            this.Label9.TabIndex = 15;
            this.Label9.Text = "Remarks";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(400, 152);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(71, 14);
            this.Label8.TabIndex = 13;
            this.Label8.Text = "Approved By";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.SystemColors.Control;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(400, 120);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(63, 14);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Ordered By";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(400, 88);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(64, 14);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Cost Center";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(400, 56);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(72, 14);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Req. Order # ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(400, 24);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(29, 14);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Date";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(8, 152);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(64, 14);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "PO. Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(8, 64);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(49, 14);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Address";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(73, 14);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Vendor Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(472, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 21);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // WelcomePage
            // 
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(871, 541);
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.WelcomePage_SetActive);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.introductionLabel, 0);
            this.Controls.SetChildIndex(this.promptLabel, 0);
            this.Controls.SetChildIndex(this.Sidebar, 0);
            this.Controls.SetChildIndex(this.Frame1, 0);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void WelcomePage_SetActive(object sender, System.ComponentModel.CancelEventArgs e)
		{
			SetWizardButtons(WizardButtons.Next);
		}

		private void WelcomePage_Load(object sender, System.EventArgs e)
		{
			//this.Sidebar.BackgroundImage = new Bitmap(this.GetType(), "Bitmaps.Sidebar.bmp");
		}
	}
}

