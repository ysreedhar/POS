namespace POCS
{
    partial class FrmInvoiceEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceEntry));
            this.rblPO = new System.Windows.Forms.RadioButton();
            this.rblSO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSupplyQuantity = new POCS.Controls.NumericTextbox();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cboOrders = new System.Windows.Forms.ComboBox();
            this.orderNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInvoiceEntry = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.orderNumbersTableAdapter = new POCS.Ds.POCSTableAdapters.OrderNumbersTableAdapter();
            this.vPODetSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPODetSummaryTableAdapter = new POCS.Ds.POCSTableAdapters.vPODetSummaryTableAdapter();
            this.pODetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nETVALUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrentSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPODetSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rblPO
            // 
            this.rblPO.AutoSize = true;
            this.rblPO.Checked = true;
            this.rblPO.Location = new System.Drawing.Point(104, 29);
            this.rblPO.Name = "rblPO";
            this.rblPO.Size = new System.Drawing.Size(39, 17);
            this.rblPO.TabIndex = 0;
            this.rblPO.TabStop = true;
            this.rblPO.Text = "PO";
            this.rblPO.UseVisualStyleBackColor = true;
            this.rblPO.CheckedChanged += new System.EventHandler(this.rblPO_CheckedChanged);
            // 
            // rblSO
            // 
            this.rblSO.AutoSize = true;
            this.rblSO.Location = new System.Drawing.Point(149, 29);
            this.rblSO.Name = "rblSO";
            this.rblSO.Size = new System.Drawing.Size(39, 17);
            this.rblSO.TabIndex = 0;
            this.rblSO.Text = "SO";
            this.rblSO.UseVisualStyleBackColor = true;
            this.rblSO.CheckedChanged += new System.EventHandler(this.rblSO_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSupplyQuantity);
            this.groupBox1.Controls.Add(this.dtpReceivedDate);
            this.groupBox1.Controls.Add(this.dtpSupplyDate);
            this.groupBox1.Controls.Add(this.dtpInvoiceDate);
            this.groupBox1.Controls.Add(this.cboOrders);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rblSO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rblPO);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Entry";
            // 
            // txtSupplyQuantity
            // 
            this.txtSupplyQuantity.CommaFormat = false;
            this.txtSupplyQuantity.CurrencyFormat = false;
            this.txtSupplyQuantity.DecimalPrecision = 0;
            this.txtSupplyQuantity.Location = new System.Drawing.Point(104, 145);
            this.txtSupplyQuantity.Name = "txtSupplyQuantity";
            this.txtSupplyQuantity.PercentFormat = false;
            this.txtSupplyQuantity.ReadOnly = false;
            this.txtSupplyQuantity.Size = new System.Drawing.Size(121, 24);
            this.txtSupplyQuantity.TabIndex = 4;
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceivedDate.Location = new System.Drawing.Point(345, 87);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(121, 21);
            this.dtpReceivedDate.TabIndex = 3;
            // 
            // dtpSupplyDate
            // 
            this.dtpSupplyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSupplyDate.Location = new System.Drawing.Point(104, 118);
            this.dtpSupplyDate.Name = "dtpSupplyDate";
            this.dtpSupplyDate.Size = new System.Drawing.Size(121, 21);
            this.dtpSupplyDate.TabIndex = 3;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(104, 91);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(121, 21);
            this.dtpInvoiceDate.TabIndex = 3;
            // 
            // cboOrders
            // 
            this.cboOrders.DataSource = this.orderNumbersBindingSource;
            this.cboOrders.DisplayMember = "PO_OrderNo";
            this.cboOrders.FormattingEnabled = true;
            this.cboOrders.Location = new System.Drawing.Point(104, 58);
            this.cboOrders.Name = "cboOrders";
            this.cboOrders.Size = new System.Drawing.Size(121, 21);
            this.cboOrders.TabIndex = 2;
            this.cboOrders.ValueMember = "POID";
            this.cboOrders.SelectedIndexChanged += new System.EventHandler(this.cboOrders_SelectedIndexChanged);
            // 
            // orderNumbersBindingSource
            // 
            this.orderNumbersBindingSource.DataMember = "OrderNumbers";
            this.orderNumbersBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Supply Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Received Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Supply Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Invoice Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Order Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vendor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Number:";
            // 
            // dgvInvoiceEntry
            // 
            this.dgvInvoiceEntry.AllowUserToAddRows = false;
            this.dgvInvoiceEntry.AllowUserToDeleteRows = false;
            this.dgvInvoiceEntry.AutoGenerateColumns = false;
            this.dgvInvoiceEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pODetailIDDataGridViewTextBoxColumn,
            this.pOIDDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.uOMDataGridViewTextBoxColumn,
            this.nETVALUEDataGridViewTextBoxColumn,
            this.clmTotalSupply,
            this.clmCurrentSupply});
            this.dgvInvoiceEntry.DataSource = this.vPODetSummaryBindingSource;
            this.dgvInvoiceEntry.Location = new System.Drawing.Point(12, 234);
            this.dgvInvoiceEntry.Name = "dgvInvoiceEntry";
            this.dgvInvoiceEntry.ReadOnly = true;
            this.dgvInvoiceEntry.Size = new System.Drawing.Size(796, 174);
            this.dgvInvoiceEntry.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Order Details:";
            // 
            // orderNumbersTableAdapter
            // 
            this.orderNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // vPODetSummaryBindingSource
            // 
            this.vPODetSummaryBindingSource.DataMember = "vPODetSummary";
            this.vPODetSummaryBindingSource.DataSource = this.pOCS;
            // 
            // vPODetSummaryTableAdapter
            // 
            this.vPODetSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // pODetailIDDataGridViewTextBoxColumn
            // 
            this.pODetailIDDataGridViewTextBoxColumn.DataPropertyName = "PO_DetailID";
            this.pODetailIDDataGridViewTextBoxColumn.HeaderText = "PO_DetailID";
            this.pODetailIDDataGridViewTextBoxColumn.Name = "pODetailIDDataGridViewTextBoxColumn";
            this.pODetailIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pODetailIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOIDDataGridViewTextBoxColumn
            // 
            this.pOIDDataGridViewTextBoxColumn.DataPropertyName = "POID";
            this.pOIDDataGridViewTextBoxColumn.HeaderText = "POID";
            this.pOIDDataGridViewTextBoxColumn.Name = "pOIDDataGridViewTextBoxColumn";
            this.pOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uOMDataGridViewTextBoxColumn
            // 
            this.uOMDataGridViewTextBoxColumn.DataPropertyName = "UOM";
            this.uOMDataGridViewTextBoxColumn.HeaderText = "UOM";
            this.uOMDataGridViewTextBoxColumn.Name = "uOMDataGridViewTextBoxColumn";
            this.uOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nETVALUEDataGridViewTextBoxColumn
            // 
            this.nETVALUEDataGridViewTextBoxColumn.DataPropertyName = "NETVALUE";
            this.nETVALUEDataGridViewTextBoxColumn.HeaderText = "NETT Price";
            this.nETVALUEDataGridViewTextBoxColumn.Name = "nETVALUEDataGridViewTextBoxColumn";
            this.nETVALUEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clmTotalSupply
            // 
            this.clmTotalSupply.HeaderText = "Total Supply";
            this.clmTotalSupply.Name = "clmTotalSupply";
            this.clmTotalSupply.ReadOnly = true;
            // 
            // clmCurrentSupply
            // 
            this.clmCurrentSupply.HeaderText = "Current Supply";
            this.clmCurrentSupply.Name = "clmCurrentSupply";
            this.clmCurrentSupply.ReadOnly = true;
            // 
            // FrmInvoiceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 501);
            this.Controls.Add(this.dgvInvoiceEntry);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInvoiceEntry";
            this.Text = "Invoice Entry";
            this.Load += new System.EventHandler(this.FrmEnterInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPODetSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rblPO;
        private System.Windows.Forms.RadioButton rblSO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInvoiceEntry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSupplyDate;
        private System.Windows.Forms.Label label8;
        private POCS.Controls.NumericTextbox txtSupplyQuantity;
        private System.Windows.Forms.Label label9;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.BindingSource orderNumbersBindingSource;
        private POCS.Ds.POCSTableAdapters.OrderNumbersTableAdapter orderNumbersTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource vPODetSummaryBindingSource;
        private POCS.Ds.POCSTableAdapters.vPODetSummaryTableAdapter vPODetSummaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pODetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nETVALUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrentSupply;
    }
}