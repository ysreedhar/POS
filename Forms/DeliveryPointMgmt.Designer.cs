namespace POCS
{
    partial class DeliveryPointMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryPointMgmt));
            this.pOCS = new POCS.Ds.POCS();
            this.deliveryPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryPointsTableAdapter = new POCS.Ds.POCSTableAdapters.DeliveryPointsTableAdapter();
            this.btnDispDGrid = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrev = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeliveryPointAddress = new System.Windows.Forms.TextBox();
            this.txtDeliveryPointName = new System.Windows.Forms.TextBox();
            this.txtDeliveryPointId = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDeliveryPoints = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPointsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryPointsBindingSource
            // 
            this.deliveryPointsBindingSource.DataMember = "DeliveryPoints";
            this.deliveryPointsBindingSource.DataSource = this.pOCS;
            // 
            // deliveryPointsTableAdapter
            // 
            this.deliveryPointsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDispDGrid
            // 
            this.btnDispDGrid.Location = new System.Drawing.Point(417, 124);
            this.btnDispDGrid.Name = "btnDispDGrid";
            this.btnDispDGrid.Size = new System.Drawing.Size(224, 23);
            this.btnDispDGrid.TabIndex = 30;
            this.btnDispDGrid.Text = "Display All Records";
            this.btnDispDGrid.Click += new System.EventHandler(this.btnDispDGrid_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(585, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(529, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(473, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(417, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLast.Location = new System.Drawing.Point(555, 68);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(40, 23);
            this.btnMoveLast.TabIndex = 25;
            this.btnMoveLast.Text = ">>";
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveNext.Location = new System.Drawing.Point(515, 68);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(40, 23);
            this.btnMoveNext.TabIndex = 24;
            this.btnMoveNext.Text = ">";
            // 
            // btnMovePrev
            // 
            this.btnMovePrev.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovePrev.Location = new System.Drawing.Point(475, 68);
            this.btnMovePrev.Name = "btnMovePrev";
            this.btnMovePrev.Size = new System.Drawing.Size(40, 23);
            this.btnMovePrev.TabIndex = 23;
            this.btnMovePrev.Text = "<";
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFirst.Location = new System.Drawing.Point(435, 68);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(40, 23);
            this.btnMoveFirst.TabIndex = 22;
            this.btnMoveFirst.Text = "<<";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDeliveryPointAddress);
            this.groupBox1.Controls.Add(this.txtDeliveryPointName);
            this.groupBox1.Controls.Add(this.txtDeliveryPointId);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Controls.Add(this.lblEmpId);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 214);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Points";
            // 
            // txtDeliveryPointAddress
            // 
            this.txtDeliveryPointAddress.AcceptsReturn = true;
            this.txtDeliveryPointAddress.Location = new System.Drawing.Point(100, 68);
            this.txtDeliveryPointAddress.Multiline = true;
            this.txtDeliveryPointAddress.Name = "txtDeliveryPointAddress";
            this.txtDeliveryPointAddress.Size = new System.Drawing.Size(269, 120);
            this.txtDeliveryPointAddress.TabIndex = 27;
            // 
            // txtDeliveryPointName
            // 
            this.txtDeliveryPointName.Location = new System.Drawing.Point(100, 44);
            this.txtDeliveryPointName.Name = "txtDeliveryPointName";
            this.txtDeliveryPointName.Size = new System.Drawing.Size(269, 21);
            this.txtDeliveryPointName.TabIndex = 26;
            // 
            // txtDeliveryPointId
            // 
            this.txtDeliveryPointId.Location = new System.Drawing.Point(100, 20);
            this.txtDeliveryPointId.Name = "txtDeliveryPointId";
            this.txtDeliveryPointId.ReadOnly = true;
            this.txtDeliveryPointId.Size = new System.Drawing.Size(100, 21);
            this.txtDeliveryPointId.TabIndex = 25;
            // 
            // lblLName
            // 
            this.lblLName.Location = new System.Drawing.Point(12, 68);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(80, 16);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Address:";
            // 
            // lblFName
            // 
            this.lblFName.Location = new System.Drawing.Point(12, 44);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(80, 16);
            this.lblFName.TabIndex = 23;
            this.lblFName.Text = "Delivery Point:";
            // 
            // lblEmpId
            // 
            this.lblEmpId.Location = new System.Drawing.Point(12, 20);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(80, 16);
            this.lblEmpId.TabIndex = 22;
            this.lblEmpId.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDeliveryPoints);
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 192);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Available Delivery Points";
            // 
            // dgvDeliveryPoints
            // 
            this.dgvDeliveryPoints.CaptionText = "Delivery Points";
            this.dgvDeliveryPoints.DataMember = "";
            this.dgvDeliveryPoints.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDeliveryPoints.Location = new System.Drawing.Point(15, 20);
            this.dgvDeliveryPoints.Name = "dgvDeliveryPoints";
            this.dgvDeliveryPoints.Size = new System.Drawing.Size(679, 248);
            this.dgvDeliveryPoints.TabIndex = 1;
            // 
            // DeliveryPointMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDispDGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePrev);
            this.Controls.Add(this.btnMoveFirst);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeliveryPointMgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Delivery Points";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DeliveryPointMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPointsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.BindingSource deliveryPointsBindingSource;
        private Ds.POCSTableAdapters.DeliveryPointsTableAdapter deliveryPointsTableAdapter;
        private System.Windows.Forms.Button btnDispDGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrev;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDeliveryPointAddress;
        private System.Windows.Forms.TextBox txtDeliveryPointName;
        private System.Windows.Forms.TextBox txtDeliveryPointId;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGrid dgvDeliveryPoints;
        private POCS.Ds.POCS pOCS;
    }
}