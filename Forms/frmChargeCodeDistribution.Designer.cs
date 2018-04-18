namespace POCS.Forms
{
    partial class frmChargeCodeDistribution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChargeCodeDistribution));
            this.dgvChargeCodeDist = new System.Windows.Forms.DataGridView();
            this.cboOrders = new System.Windows.Forms.ComboBox();
            this.pOHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.pOdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rblSO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rblPO = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpenseCodeDesc = new System.Windows.Forms.Label();
            this.lblSubJobNoDesc = new System.Windows.Forms.Label();
            this.lblJobnoDesc = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.pO_HeaderTableAdapter = new POCS.Ds.POCSTableAdapters.PO_HeaderTableAdapter();
            this.pO_detailsTableAdapter = new POCS.Ds.POCSTableAdapters.PO_detailsTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tblItemCostDistributionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblItemCostDistributionTableAdapter = new POCS.Ds.POCSTableAdapters.tblItemCostDistributionTableAdapter();
            this.distIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOdetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmExpenseCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDistPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDistValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubJobDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpenseCodeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeCodeDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemCostDistributionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChargeCodeDist
            // 
            this.dgvChargeCodeDist.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChargeCodeDist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChargeCodeDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChargeCodeDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distIDDataGridViewTextBoxColumn,
            this.pOdetailIDDataGridViewTextBoxColumn,
            this.clmJobCode,
            this.clmExpenseCode,
            this.clm,
            this.clmDistPercentage,
            this.clmDistValue,
            this.clmJobDesc,
            this.clmSubJobDesc,
            this.clmExpenseCodeDesc});
            this.dgvChargeCodeDist.DataSource = this.tblItemCostDistributionBindingSource;
            this.dgvChargeCodeDist.Location = new System.Drawing.Point(12, 90);
            this.dgvChargeCodeDist.Name = "dgvChargeCodeDist";
            this.dgvChargeCodeDist.Size = new System.Drawing.Size(484, 174);
            this.dgvChargeCodeDist.TabIndex = 52;
            // 
            // cboOrders
            // 
            this.cboOrders.DataSource = this.pOHeaderBindingSource;
            this.cboOrders.DisplayMember = "PO_OrderNo";
            this.cboOrders.FormattingEnabled = true;
            this.cboOrders.Location = new System.Drawing.Point(105, 30);
            this.cboOrders.Name = "cboOrders";
            this.cboOrders.Size = new System.Drawing.Size(121, 21);
            this.cboOrders.TabIndex = 53;
            this.cboOrders.ValueMember = "POID";
            this.cboOrders.SelectedIndexChanged += new System.EventHandler(this.cboOrders_SelectedIndexChanged);
            // 
            // pOHeaderBindingSource
            // 
            this.pOHeaderBindingSource.DataMember = "PO_Header";
            this.pOHeaderBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboItems
            // 
            this.cboItems.DataSource = this.pOdetailsBindingSource;
            this.cboItems.DisplayMember = "ItemDescription";
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Location = new System.Drawing.Point(105, 56);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(262, 21);
            this.cboItems.TabIndex = 53;
            this.cboItems.ValueMember = "PO_DetailID";
            // 
            // pOdetailsBindingSource
            // 
            this.pOdetailsBindingSource.DataMember = "PO_details";
            this.pOdetailsBindingSource.DataSource = this.pOCS;
            // 
            // rblSO
            // 
            this.rblSO.AutoSize = true;
            this.rblSO.Location = new System.Drawing.Point(148, 7);
            this.rblSO.Name = "rblSO";
            this.rblSO.Size = new System.Drawing.Size(39, 17);
            this.rblSO.TabIndex = 55;
            this.rblSO.Text = "SO";
            this.rblSO.UseVisualStyleBackColor = true;
            this.rblSO.CheckedChanged += new System.EventHandler(this.rblSO_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Order Type:";
            // 
            // rblPO
            // 
            this.rblPO.AutoSize = true;
            this.rblPO.Location = new System.Drawing.Point(105, 7);
            this.rblPO.Name = "rblPO";
            this.rblPO.Size = new System.Drawing.Size(39, 17);
            this.rblPO.TabIndex = 54;
            this.rblPO.Text = "PO";
            this.rblPO.UseVisualStyleBackColor = true;
            this.rblPO.CheckedChanged += new System.EventHandler(this.rblPO_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Order Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Item:";
            // 
            // lblExpenseCodeDesc
            // 
            this.lblExpenseCodeDesc.AutoSize = true;
            this.lblExpenseCodeDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblExpenseCodeDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExpenseCodeDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseCodeDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExpenseCodeDesc.Location = new System.Drawing.Point(95, 313);
            this.lblExpenseCodeDesc.Name = "lblExpenseCodeDesc";
            this.lblExpenseCodeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExpenseCodeDesc.Size = new System.Drawing.Size(11, 13);
            this.lblExpenseCodeDesc.TabIndex = 60;
            this.lblExpenseCodeDesc.Text = "-";
            // 
            // lblSubJobNoDesc
            // 
            this.lblSubJobNoDesc.AutoSize = true;
            this.lblSubJobNoDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubJobNoDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSubJobNoDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJobNoDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubJobNoDesc.Location = new System.Drawing.Point(95, 295);
            this.lblSubJobNoDesc.Name = "lblSubJobNoDesc";
            this.lblSubJobNoDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubJobNoDesc.Size = new System.Drawing.Size(11, 13);
            this.lblSubJobNoDesc.TabIndex = 61;
            this.lblSubJobNoDesc.Text = "-";
            // 
            // lblJobnoDesc
            // 
            this.lblJobnoDesc.AutoSize = true;
            this.lblJobnoDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblJobnoDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblJobnoDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobnoDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJobnoDesc.Location = new System.Drawing.Point(95, 277);
            this.lblJobnoDesc.Name = "lblJobnoDesc";
            this.lblJobnoDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblJobnoDesc.Size = new System.Drawing.Size(11, 13);
            this.lblJobnoDesc.TabIndex = 62;
            this.lblJobnoDesc.Text = "-";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.SystemColors.Control;
            this.label38.Cursor = System.Windows.Forms.Cursors.Default;
            this.label38.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label38.Location = new System.Drawing.Point(12, 313);
            this.label38.Name = "label38";
            this.label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label38.Size = new System.Drawing.Size(78, 13);
            this.label38.TabIndex = 57;
            this.label38.Text = "Expense Desc.";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.SystemColors.Control;
            this.label37.Cursor = System.Windows.Forms.Cursors.Default;
            this.label37.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label37.Location = new System.Drawing.Point(12, 295);
            this.label37.Name = "label37";
            this.label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label37.Size = new System.Drawing.Size(76, 13);
            this.label37.TabIndex = 58;
            this.label37.Text = "Sub-Job Desc.";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.SystemColors.Control;
            this.label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.label36.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label36.Location = new System.Drawing.Point(12, 277);
            this.label36.Name = "label36";
            this.label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label36.Size = new System.Drawing.Size(54, 13);
            this.label36.TabIndex = 59;
            this.label36.Text = "Job Desc.";
            // 
            // pO_HeaderTableAdapter
            // 
            this.pO_HeaderTableAdapter.ClearBeforeFill = true;
            // 
            // pO_detailsTableAdapter
            // 
            this.pO_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(374, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 23);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tblItemCostDistributionBindingSource
            // 
            this.tblItemCostDistributionBindingSource.DataMember = "tblItemCostDistribution";
            this.tblItemCostDistributionBindingSource.DataSource = this.pOCS;
            // 
            // tblItemCostDistributionTableAdapter
            // 
            this.tblItemCostDistributionTableAdapter.ClearBeforeFill = true;
            // 
            // distIDDataGridViewTextBoxColumn
            // 
            this.distIDDataGridViewTextBoxColumn.DataPropertyName = "DistID";
            this.distIDDataGridViewTextBoxColumn.HeaderText = "DistID";
            this.distIDDataGridViewTextBoxColumn.Name = "distIDDataGridViewTextBoxColumn";
            this.distIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.distIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOdetailIDDataGridViewTextBoxColumn
            // 
            this.pOdetailIDDataGridViewTextBoxColumn.DataPropertyName = "PO_detailID";
            this.pOdetailIDDataGridViewTextBoxColumn.HeaderText = "PO_detailID";
            this.pOdetailIDDataGridViewTextBoxColumn.Name = "pOdetailIDDataGridViewTextBoxColumn";
            this.pOdetailIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clmJobCode
            // 
            this.clmJobCode.HeaderText = "JobCode";
            this.clmJobCode.Name = "clmJobCode";
            // 
            // clmExpenseCode
            // 
            this.clmExpenseCode.HeaderText = "Exp. Code";
            this.clmExpenseCode.Name = "clmExpenseCode";
            this.clmExpenseCode.Width = 75;
            // 
            // clm
            // 
            this.clm.DataPropertyName = "ChargeCode";
            this.clm.HeaderText = "Charge Code";
            this.clm.Name = "clm";
            this.clm.Width = 150;
            // 
            // clmDistPercentage
            // 
            this.clmDistPercentage.DataPropertyName = "DistPercentage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmDistPercentage.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDistPercentage.HeaderText = "%";
            this.clmDistPercentage.Name = "clmDistPercentage";
            this.clmDistPercentage.Width = 50;
            // 
            // clmDistValue
            // 
            this.clmDistValue.DataPropertyName = "DistValue";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmDistValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmDistValue.HeaderText = "Value";
            this.clmDistValue.Name = "clmDistValue";
            this.clmDistValue.Visible = false;
            // 
            // clmJobDesc
            // 
            this.clmJobDesc.HeaderText = "Job Code Desc.";
            this.clmJobDesc.Name = "clmJobDesc";
            this.clmJobDesc.Visible = false;
            // 
            // clmSubJobDesc
            // 
            this.clmSubJobDesc.HeaderText = "Sub Job Desc";
            this.clmSubJobDesc.Name = "clmSubJobDesc";
            this.clmSubJobDesc.Visible = false;
            // 
            // clmExpenseCodeDesc
            // 
            this.clmExpenseCodeDesc.HeaderText = "Exp. Code Desc";
            this.clmExpenseCodeDesc.Name = "clmExpenseCodeDesc";
            this.clmExpenseCodeDesc.Visible = false;
            // 
            // frmChargeCodeDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 334);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblExpenseCodeDesc);
            this.Controls.Add(this.lblSubJobNoDesc);
            this.Controls.Add(this.lblJobnoDesc);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.rblSO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rblPO);
            this.Controls.Add(this.cboItems);
            this.Controls.Add(this.cboOrders);
            this.Controls.Add(this.dgvChargeCodeDist);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChargeCodeDistribution";
            this.Text = "Distribute Charge Code";
            this.Load += new System.EventHandler(this.frmChargeCodeDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeCodeDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemCostDistributionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChargeCodeDist;
        private System.Windows.Forms.ComboBox cboOrders;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.RadioButton rblSO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rblPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblExpenseCodeDesc;
        public System.Windows.Forms.Label lblSubJobNoDesc;
        public System.Windows.Forms.Label lblJobnoDesc;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label label36;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.BindingSource pOHeaderBindingSource;
        private POCS.Ds.POCSTableAdapters.PO_HeaderTableAdapter pO_HeaderTableAdapter;
        private System.Windows.Forms.BindingSource pOdetailsBindingSource;
        private POCS.Ds.POCSTableAdapters.PO_detailsTableAdapter pO_detailsTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource tblItemCostDistributionBindingSource;
        private POCS.Ds.POCSTableAdapters.tblItemCostDistributionTableAdapter tblItemCostDistributionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn distIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOdetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmJobCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmExpenseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDistPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDistValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJobDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubJobDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpenseCodeDesc;
    }
}