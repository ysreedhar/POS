namespace POCS.Forms
{
    partial class frmViewRptChargeCodeDis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewRptChargeCodeDis));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChooseReport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.crvPurchases = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.clbFilter = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.llselNone = new System.Windows.Forms.LinkLabel();
            this.llselAll = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Criteria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose a Report:";
            // 
            // cboChooseReport
            // 
            this.cboChooseReport.FormattingEnabled = true;
            this.cboChooseReport.Items.AddRange(new object[] {
            "-Select A Report-",
            "Purchases By Job Charge",
            "Purchases By Job",
            "Purchases By Sub-Job",
            "Purchases By Resource",
            "Purchases By Charge Type"});
            this.cboChooseReport.Location = new System.Drawing.Point(15, 50);
            this.cboChooseReport.Name = "cboChooseReport";
            this.cboChooseReport.Size = new System.Drawing.Size(180, 21);
            this.cboChooseReport.TabIndex = 1;
            this.cboChooseReport.Text = "-Select A Report-";
            this.cboChooseReport.SelectedIndexChanged += new System.EventHandler(this.cboChooseReport_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose a Date range:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(707, 51);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(93, 21);
            this.dtpFrom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(707, 78);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(93, 21);
            this.dtpTo.TabIndex = 2;
            // 
            // crvPurchases
            // 
            this.crvPurchases.ActiveViewIndex = -1;
            this.crvPurchases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPurchases.DisplayGroupTree = false;
            this.crvPurchases.Location = new System.Drawing.Point(15, 158);
            this.crvPurchases.Name = "crvPurchases";
            this.crvPurchases.SelectionFormula = "";
            this.crvPurchases.Size = new System.Drawing.Size(1001, 479);
            this.crvPurchases.TabIndex = 3;
            this.crvPurchases.ViewTimeSelectionFormula = "";
            // 
            // clbFilter
            // 
            this.clbFilter.CheckOnClick = true;
            this.clbFilter.FormattingEnabled = true;
            this.clbFilter.Location = new System.Drawing.Point(201, 50);
            this.clbFilter.Name = "clbFilter";
            this.clbFilter.Size = new System.Drawing.Size(459, 100);
            this.clbFilter.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose a Filter:";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(816, 50);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(129, 23);
            this.btnViewReport.TabIndex = 5;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // llselNone
            // 
            this.llselNone.AutoSize = true;
            this.llselNone.Location = new System.Drawing.Point(628, 34);
            this.llselNone.Name = "llselNone";
            this.llselNone.Size = new System.Drawing.Size(32, 13);
            this.llselNone.TabIndex = 7;
            this.llselNone.TabStop = true;
            this.llselNone.Text = "None";
            this.llselNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llselNone_LinkClicked);
            // 
            // llselAll
            // 
            this.llselAll.AutoSize = true;
            this.llselAll.Location = new System.Drawing.Point(607, 34);
            this.llselAll.Name = "llselAll";
            this.llselAll.Size = new System.Drawing.Size(18, 13);
            this.llselAll.TabIndex = 8;
            this.llselAll.TabStop = true;
            this.llselAll.Text = "All";
            this.llselAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llselAll_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select:";
            // 
            // frmViewRptChargeCodeDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 649);
            this.Controls.Add(this.llselNone);
            this.Controls.Add(this.llselAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.clbFilter);
            this.Controls.Add(this.crvPurchases);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cboChooseReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewRptChargeCodeDis";
            this.Text = "View Purchase Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewRptChargeCodeDis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChooseReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPurchases;
        private System.Windows.Forms.CheckedListBox clbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.LinkLabel llselNone;
        private System.Windows.Forms.LinkLabel llselAll;
        private System.Windows.Forms.Label label7;
    }
}