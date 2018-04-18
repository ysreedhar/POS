namespace POCS.Forms
{
    partial class BuyerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerManagement));
            this.dgvBuyers = new System.Windows.Forms.DataGridView();
            this.buyerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerIntialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBuyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.tblBuyerTableAdapter = new POCS.Ds.POCSTableAdapters.tblBuyerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuyers
            // 
            this.dgvBuyers.AutoGenerateColumns = false;
            this.dgvBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyerIDDataGridViewTextBoxColumn,
            this.buyerIntialDataGridViewTextBoxColumn,
            this.buyerNameDataGridViewTextBoxColumn});
            this.dgvBuyers.DataSource = this.tblBuyerBindingSource;
            this.dgvBuyers.Location = new System.Drawing.Point(12, 41);
            this.dgvBuyers.Name = "dgvBuyers";
            this.dgvBuyers.Size = new System.Drawing.Size(478, 297);
            this.dgvBuyers.TabIndex = 0;
            this.dgvBuyers.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuyers_CellLeave);
            // 
            // buyerIDDataGridViewTextBoxColumn
            // 
            this.buyerIDDataGridViewTextBoxColumn.DataPropertyName = "BuyerID";
            this.buyerIDDataGridViewTextBoxColumn.HeaderText = "BuyerID";
            this.buyerIDDataGridViewTextBoxColumn.Name = "buyerIDDataGridViewTextBoxColumn";
            this.buyerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // buyerIntialDataGridViewTextBoxColumn
            // 
            this.buyerIntialDataGridViewTextBoxColumn.DataPropertyName = "BuyerIntial";
            this.buyerIntialDataGridViewTextBoxColumn.HeaderText = "Initials";
            this.buyerIntialDataGridViewTextBoxColumn.Name = "buyerIntialDataGridViewTextBoxColumn";
            // 
            // buyerNameDataGridViewTextBoxColumn
            // 
            this.buyerNameDataGridViewTextBoxColumn.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.HeaderText = "Buyer Name";
            this.buyerNameDataGridViewTextBoxColumn.Name = "buyerNameDataGridViewTextBoxColumn";
            this.buyerNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // tblBuyerBindingSource
            // 
            this.tblBuyerBindingSource.DataMember = "tblBuyer";
            this.tblBuyerBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBuyerTableAdapter
            // 
            this.tblBuyerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buyer Listing";
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
            // BuyerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 350);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuyers);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyerManagement";
            this.Text = "Add and Maintain Buyers";
            this.Load += new System.EventHandler(this.BuyerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuyers;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.BindingSource tblBuyerBindingSource;
        private POCS.Ds.POCSTableAdapters.tblBuyerTableAdapter tblBuyerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIntialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}