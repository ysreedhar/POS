namespace POCS.Forms
{
    partial class FrmMSRReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMSRReceipt));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSRNo = new POCS.Controls.NumericTextbox();
            this.dgvMSRListing = new System.Windows.Forms.DataGridView();
            this.mSRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSRNoDataGridViewTextBoxColumn = new  DataGridViewAutoFilterTextBoxColumn();
            this.mSRDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recvdDateDataGridViewTextBoxColumn = new DataGridViewAutoFilterTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestorDataGridViewTextBoxColumn = new DataGridViewAutoFilterTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approvedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerDataGridViewTextBoxColumn = new DataGridViewAutoFilterTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new DataGridViewAutoFilterTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSRClosedDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMSRReceiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.tblMSRReceiptsTableAdapter = new POCS.Ds.POCSTableAdapters.tblMSRReceiptsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpMSRDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNosofItems = new POCS.Controls.NumericTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequestor = new System.Windows.Forms.TextBox();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.tblBuyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBuyerTableAdapter = new POCS.Ds.POCSTableAdapters.tblBuyerTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.warningProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.filterStatusLabel = new System.Windows.Forms.Label();
            this.showAllLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMSRListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMSRReceiptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Msr No.";
            // 
            // txtMSRNo
            // 
            this.txtMSRNo.CommaFormat = false;
            this.txtMSRNo.CurrencyFormat = false;
            this.txtMSRNo.DecimalPrecision = 0;
            this.txtMSRNo.Location = new System.Drawing.Point(108, 15);
            this.txtMSRNo.Name = "txtMSRNo";
            this.txtMSRNo.PercentFormat = false;
            this.txtMSRNo.ReadOnly = false;
            this.txtMSRNo.Size = new System.Drawing.Size(99, 21);
            this.txtMSRNo.TabIndex = 1;
            // 
            // dgvMSRListing
            // 
            this.dgvMSRListing.AllowUserToAddRows = false;
            this.dgvMSRListing.AllowUserToDeleteRows = false;
            this.dgvMSRListing.AutoGenerateColumns = false;
            this.dgvMSRListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMSRListing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSRIDDataGridViewTextBoxColumn,
            this.mSRNoDataGridViewTextBoxColumn,
            this.mSRDateDataGridViewTextBoxColumn,
            this.recvdDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.nosItemsDataGridViewTextBoxColumn,
            this.requestorDataGridViewTextBoxColumn,
            this.Department,
            this.Approvedby,
            this.buyerDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.mSRClosedDtDataGridViewTextBoxColumn});
            this.dgvMSRListing.DataSource = this.tblMSRReceiptsBindingSource;
            this.dgvMSRListing.Location = new System.Drawing.Point(26, 202);
            this.dgvMSRListing.Name = "dgvMSRListing";
            this.dgvMSRListing.ReadOnly = true;
            this.dgvMSRListing.Size = new System.Drawing.Size(991, 270);
            this.dgvMSRListing.TabIndex = 2;
            this.dgvMSRListing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMSRListing_KeyDown);
            this.dgvMSRListing.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMSRListing_DataBindingComplete);
            this.dgvMSRListing.SelectionChanged += new System.EventHandler(this.dgvMSRListing_SelectionChanged);
            // 
            // mSRIDDataGridViewTextBoxColumn
            // 
            this.mSRIDDataGridViewTextBoxColumn.DataPropertyName = "MSRID";
            this.mSRIDDataGridViewTextBoxColumn.HeaderText = "MSRID";
            this.mSRIDDataGridViewTextBoxColumn.Name = "mSRIDDataGridViewTextBoxColumn";
            this.mSRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mSRNoDataGridViewTextBoxColumn
            // 
            this.mSRNoDataGridViewTextBoxColumn.DataPropertyName = "MSRNo";
            this.mSRNoDataGridViewTextBoxColumn.HeaderText = "MSR No.";
            this.mSRNoDataGridViewTextBoxColumn.Name = "mSRNoDataGridViewTextBoxColumn";
            this.mSRNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSRDateDataGridViewTextBoxColumn
            // 
            this.mSRDateDataGridViewTextBoxColumn.DataPropertyName = "MSRDate";
            this.mSRDateDataGridViewTextBoxColumn.HeaderText = "MSR Dt.";
            this.mSRDateDataGridViewTextBoxColumn.Name = "mSRDateDataGridViewTextBoxColumn";
            this.mSRDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recvdDateDataGridViewTextBoxColumn
            // 
            this.recvdDateDataGridViewTextBoxColumn.DataPropertyName = "RecvdDate";
            this.recvdDateDataGridViewTextBoxColumn.HeaderText = "Recvd. Dt.";
            this.recvdDateDataGridViewTextBoxColumn.Name = "recvdDateDataGridViewTextBoxColumn";
            this.recvdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requiredDateDataGridViewTextBoxColumn
            // 
            this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.HeaderText = "Req. Dt.";
            this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
            this.requiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nosItemsDataGridViewTextBoxColumn
            // 
            this.nosItemsDataGridViewTextBoxColumn.DataPropertyName = "NosItems";
            this.nosItemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.nosItemsDataGridViewTextBoxColumn.Name = "nosItemsDataGridViewTextBoxColumn";
            this.nosItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestorDataGridViewTextBoxColumn
            // 
            this.requestorDataGridViewTextBoxColumn.DataPropertyName = "Requestor";
            this.requestorDataGridViewTextBoxColumn.HeaderText = "Requestor";
            this.requestorDataGridViewTextBoxColumn.Name = "requestorDataGridViewTextBoxColumn";
            this.requestorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Approvedby
            // 
            this.Approvedby.DataPropertyName = "Approvedby";
            this.Approvedby.HeaderText = "Approved by";
            this.Approvedby.Name = "Approvedby";
            this.Approvedby.ReadOnly = true;
            // 
            // buyerDataGridViewTextBoxColumn
            // 
            this.buyerDataGridViewTextBoxColumn.DataPropertyName = "Buyer";
            this.buyerDataGridViewTextBoxColumn.HeaderText = "Buyer";
            this.buyerDataGridViewTextBoxColumn.Name = "buyerDataGridViewTextBoxColumn";
            this.buyerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSRClosedDtDataGridViewTextBoxColumn
            // 
            this.mSRClosedDtDataGridViewTextBoxColumn.DataPropertyName = "MSRClosedDt";
            this.mSRClosedDtDataGridViewTextBoxColumn.HeaderText = "MSRClosedDt";
            this.mSRClosedDtDataGridViewTextBoxColumn.Name = "mSRClosedDtDataGridViewTextBoxColumn";
            this.mSRClosedDtDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSRClosedDtDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblMSRReceiptsBindingSource
            // 
            this.tblMSRReceiptsBindingSource.DataMember = "tblMSRReceipts";
            this.tblMSRReceiptsBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMSRReceiptsTableAdapter
            // 
            this.tblMSRReceiptsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Msr Date";
            // 
            // dtpMSRDate
            // 
            this.dtpMSRDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMSRDate.Location = new System.Drawing.Point(108, 44);
            this.dtpMSRDate.Name = "dtpMSRDate";
            this.dtpMSRDate.Size = new System.Drawing.Size(99, 21);
            this.dtpMSRDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Received Date";
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceivedDate.Location = new System.Drawing.Point(108, 73);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(99, 21);
            this.dtpReceivedDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Required Date";
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(108, 102);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(99, 21);
            this.dtpRequiredDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "No. of Items";
            // 
            // txtNosofItems
            // 
            this.txtNosofItems.CommaFormat = false;
            this.txtNosofItems.CurrencyFormat = false;
            this.txtNosofItems.DecimalPrecision = 0;
            this.txtNosofItems.Location = new System.Drawing.Point(108, 131);
            this.txtNosofItems.Name = "txtNosofItems";
            this.txtNosofItems.PercentFormat = false;
            this.txtNosofItems.ReadOnly = false;
            this.txtNosofItems.Size = new System.Drawing.Size(99, 21);
            this.txtNosofItems.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Requestor";
            // 
            // txtRequestor
            // 
            this.txtRequestor.Location = new System.Drawing.Point(377, 15);
            this.txtRequestor.Name = "txtRequestor";
            this.txtRequestor.Size = new System.Drawing.Size(149, 21);
            this.txtRequestor.TabIndex = 6;
            // 
            // cboBuyer
            // 
            this.cboBuyer.DataSource = this.tblBuyerBindingSource;
            this.cboBuyer.DisplayMember = "BuyerIntial";
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(377, 102);
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(149, 21);
            this.cboBuyer.TabIndex = 9;
            this.cboBuyer.ValueMember = "BuyerID";
            // 
            // tblBuyerBindingSource
            // 
            this.tblBuyerBindingSource.DataMember = "tblBuyer";
            this.tblBuyerBindingSource.DataSource = this.pOCS;
            // 
            // tblBuyerTableAdapter
            // 
            this.tblBuyerTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Buyer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Project";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(377, 131);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(291, 21);
            this.txtProject.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(108, 158);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(560, 21);
            this.txtDescription.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(803, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(803, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(377, 44);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(149, 21);
            this.txtDepartment.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Approved By";
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Location = new System.Drawing.Point(377, 73);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(149, 21);
            this.txtApprovedBy.TabIndex = 8;
            // 
            // warningProvider
            // 
            this.warningProvider.ContainerControl = this;
            // 
            // filterStatusLabel
            // 
            this.filterStatusLabel.AutoSize = true;
            this.filterStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterStatusLabel.Location = new System.Drawing.Point(76, 474);
            this.filterStatusLabel.Name = "filterStatusLabel";
            this.filterStatusLabel.Size = new System.Drawing.Size(65, 13);
            this.filterStatusLabel.TabIndex = 15;
            this.filterStatusLabel.Text = "Filter Status";
            this.filterStatusLabel.Visible = false;
            // 
            // showAllLabel
            // 
            this.showAllLabel.AutoSize = true;
            this.showAllLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAllLabel.Location = new System.Drawing.Point(23, 475);
            this.showAllLabel.Name = "showAllLabel";
            this.showAllLabel.Size = new System.Drawing.Size(47, 13);
            this.showAllLabel.TabIndex = 14;
            this.showAllLabel.Text = "Show All";
            this.showAllLabel.Visible = false;
            this.showAllLabel.Click += new System.EventHandler(this.showAllLabel_Click);
            // 
            // FrmMSRReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 511);
            this.Controls.Add(this.filterStatusLabel);
            this.Controls.Add(this.showAllLabel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpReceivedDate);
            this.Controls.Add(this.dtpMSRDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMSRListing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNosofItems);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.txtApprovedBy);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtRequestor);
            this.Controls.Add(this.txtMSRNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMSRReceipt";
            this.Text = "MSR Receipt Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMSRReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMSRListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMSRReceiptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private POCS.Controls.NumericTextbox txtMSRNo;
        private System.Windows.Forms.DataGridView dgvMSRListing;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.BindingSource tblMSRReceiptsBindingSource;
        private POCS.Ds.POCSTableAdapters.tblMSRReceiptsTableAdapter tblMSRReceiptsTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mSRClosedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpMSRDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.Label label5;
        private POCS.Controls.NumericTextbox txtNosofItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRequestor;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.BindingSource tblBuyerBindingSource;
        private POCS.Ds.POCSTableAdapters.tblBuyerTableAdapter tblBuyerTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.ErrorProvider warningProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSRDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approvedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSRClosedDtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label filterStatusLabel;
        private System.Windows.Forms.Label showAllLabel;
        private DataGridViewAutoFilterTextBoxColumn  mSRNoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilterTextBoxColumn recvdDateDataGridViewTextBoxColumn;
        private DataGridViewAutoFilterTextBoxColumn requestorDataGridViewTextBoxColumn;
        private DataGridViewAutoFilterTextBoxColumn buyerDataGridViewTextBoxColumn;
        private DataGridViewAutoFilterTextBoxColumn projectDataGridViewTextBoxColumn;
    }
}