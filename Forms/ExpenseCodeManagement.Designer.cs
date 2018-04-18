namespace POCS
{
    partial class ExpenseCodeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseCodeManagement));
            this.dgvExpenseCodes = new System.Windows.Forms.DataGridView();
            this.exCodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseCodeDataGridViewTextBoxColumn = new POCS.DataGridViewAutoFilterTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblExpenseCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tblExpenseCodeTableAdapter = new POCS.Ds.POCSTableAdapters.tblExpenseCodeTableAdapter();
            this.filterStatusLabel = new System.Windows.Forms.Label();
            this.showAllLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpenseCodes
            // 
            this.dgvExpenseCodes.AutoGenerateColumns = false;
            this.dgvExpenseCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseCodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exCodeIDDataGridViewTextBoxColumn,
            this.expenseCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvExpenseCodes.DataSource = this.tblExpenseCodeBindingSource;
            this.dgvExpenseCodes.Location = new System.Drawing.Point(12, 41);
            this.dgvExpenseCodes.Name = "dgvExpenseCodes";
            this.dgvExpenseCodes.Size = new System.Drawing.Size(478, 297);
            this.dgvExpenseCodes.TabIndex = 0;
            this.dgvExpenseCodes.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseCodes_CellLeave);
            this.dgvExpenseCodes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOrders_KeyDown);
            this.dgvExpenseCodes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrders_DataBindingComplete);
            // 
            // exCodeIDDataGridViewTextBoxColumn
            // 
            this.exCodeIDDataGridViewTextBoxColumn.DataPropertyName = "ExCodeID";
            this.exCodeIDDataGridViewTextBoxColumn.HeaderText = "ExCodeID";
            this.exCodeIDDataGridViewTextBoxColumn.Name = "exCodeIDDataGridViewTextBoxColumn";
            this.exCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.exCodeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // expenseCodeDataGridViewTextBoxColumn
            // 
            this.expenseCodeDataGridViewTextBoxColumn.DataPropertyName = "Expense Code";
            this.expenseCodeDataGridViewTextBoxColumn.HeaderText = "Expense Code";
            this.expenseCodeDataGridViewTextBoxColumn.Name = "expenseCodeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tblExpenseCodeBindingSource
            // 
            this.tblExpenseCodeBindingSource.DataMember = "tblExpenseCode";
            this.tblExpenseCodeBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Code Listing";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(415, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tblExpenseCodeTableAdapter
            // 
            this.tblExpenseCodeTableAdapter.ClearBeforeFill = true;
            // 
            // filterStatusLabel
            // 
            this.filterStatusLabel.AutoSize = true;
            this.filterStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterStatusLabel.Location = new System.Drawing.Point(65, 341);
            this.filterStatusLabel.Name = "filterStatusLabel";
            this.filterStatusLabel.Size = new System.Drawing.Size(65, 13);
            this.filterStatusLabel.TabIndex = 4;
            this.filterStatusLabel.Text = "Filter Status";
            this.filterStatusLabel.Visible = false;
            // 
            // showAllLabel
            // 
            this.showAllLabel.AutoSize = true;
            this.showAllLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAllLabel.Location = new System.Drawing.Point(12, 342);
            this.showAllLabel.Name = "showAllLabel";
            this.showAllLabel.Size = new System.Drawing.Size(47, 13);
            this.showAllLabel.TabIndex = 3;
            this.showAllLabel.Text = "Show All";
            this.showAllLabel.Visible = false;
            this.showAllLabel.Click += new System.EventHandler(this.showAllLabel_Click);
            // 
            // ExpenseCodeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 375);
            this.Controls.Add(this.filterStatusLabel);
            this.Controls.Add(this.showAllLabel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExpenseCodes);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpenseCodeManagement";
            this.Text = "Add and Maintain Expense Codes";
            this.Load += new System.EventHandler(this.BuyerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpenseCodes;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource tblExpenseCodeBindingSource;
        private POCS.Ds.POCSTableAdapters.tblExpenseCodeTableAdapter tblExpenseCodeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exCodeIDDataGridViewTextBoxColumn;
        private POCS.DataGridViewAutoFilterTextBoxColumn expenseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label filterStatusLabel;
        private System.Windows.Forms.Label showAllLabel;
    }
}