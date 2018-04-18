namespace POCS
{
    partial class frmMaintainJobCharge
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainJobCharge));
            this.jobchargeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.jobchargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTxtFindOrderNumber = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindOrderNumber = new System.Windows.Forms.ToolStripButton();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.txtJobCharge = new System.Windows.Forms.TextBox();
            this.txtJobDesc = new System.Windows.Forms.TextBox();
            this.txtSubJobNo = new System.Windows.Forms.TextBox();
            this.txtSubJobDesc = new System.Windows.Forms.TextBox();
            this.cHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjobnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnodescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjobnodescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customerIDLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobchargeBindingNavigator)).BeginInit();
            this.jobchargeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobchargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(668, 81);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(66, 13);
            customerIDLabel.TabIndex = 4;
            customerIDLabel.Text = "Job Charge:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderIDLabel.Location = new System.Drawing.Point(668, 55);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(22, 13);
            orderIDLabel.TabIndex = 2;
            orderIDLabel.Text = "ID:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(668, 107);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(48, 13);
            employeeIDLabel.TabIndex = 6;
            employeeIDLabel.Text = "Job No.:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(667, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 13);
            label1.TabIndex = 4;
            label1.Text = "Sub-Job No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(667, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 6;
            label2.Text = "Job Desc.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(667, 187);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 13);
            label3.TabIndex = 4;
            label3.Text = "Sub-Job Desc:";
            // 
            // jobchargeBindingNavigator
            // 
            this.jobchargeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jobchargeBindingNavigator.BindingSource = this.jobchargeBindingSource;
            this.jobchargeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobchargeBindingNavigator.DeleteItem = null;
            this.jobchargeBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.jobchargeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolTxtFindOrderNumber,
            this.toolBtnFindOrderNumber});
            this.jobchargeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jobchargeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobchargeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobchargeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobchargeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobchargeBindingNavigator.Name = "jobchargeBindingNavigator";
            this.jobchargeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jobchargeBindingNavigator.Size = new System.Drawing.Size(965, 25);
            this.jobchargeBindingNavigator.TabIndex = 0;
            this.jobchargeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // jobchargeBindingSource
            // 
            this.jobchargeBindingSource.DataSource = typeof(POCS.JobCharge);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderBindingNavigatorSaveItem.Text = "Save Data";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolTxtFindOrderNumber
            // 
            this.toolTxtFindOrderNumber.CausesValidation = false;
            this.toolTxtFindOrderNumber.MaxLength = 10;
            this.toolTxtFindOrderNumber.Name = "toolTxtFindOrderNumber";
            this.toolTxtFindOrderNumber.Size = new System.Drawing.Size(100, 25);
            this.toolTxtFindOrderNumber.ToolTipText = "Search for an User ID";
            this.toolTxtFindOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolTxtFindOrderNumber_KeyPress);
            // 
            // toolBtnFindOrderNumber
            // 
            this.toolBtnFindOrderNumber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindOrderNumber.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnFindOrderNumber.Image")));
            this.toolBtnFindOrderNumber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindOrderNumber.Name = "toolBtnFindOrderNumber";
            this.toolBtnFindOrderNumber.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindOrderNumber.Text = "Search for an User ID";
            this.toolBtnFindOrderNumber.Click += new System.EventHandler(this.toolBtnFindOrderNumber_Click);
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobchargeBindingSource, "CHID", true));
            this.orderIDTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTextBox.Location = new System.Drawing.Point(746, 52);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 21);
            this.orderIDTextBox.TabIndex = 4;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cHIDDataGridViewTextBoxColumn,
            this.jobCodeDataGridViewTextBoxColumn,
            this.jobnoDataGridViewTextBoxColumn,
            this.subjobnoDataGridViewTextBoxColumn,
            this.jobnodescDataGridViewTextBoxColumn,
            this.subjobnodescDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.jobchargeBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(12, 28);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.Size = new System.Drawing.Size(649, 422);
            this.orderDataGridView.TabIndex = 20;
            // 
            // txtJobNo
            // 
            this.txtJobNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobchargeBindingSource, "Jobno", true));
            this.txtJobNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobNo.Location = new System.Drawing.Point(746, 104);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(200, 21);
            this.txtJobNo.TabIndex = 0;
            this.txtJobNo.Validated += new System.EventHandler(this.txtJobNo_Validated);
            // 
            // txtJobCharge
            // 
            this.txtJobCharge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobchargeBindingSource, "Job_Code", true));
            this.txtJobCharge.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobCharge.Location = new System.Drawing.Point(746, 78);
            this.txtJobCharge.Name = "txtJobCharge";
            this.txtJobCharge.Size = new System.Drawing.Size(200, 21);
            this.txtJobCharge.TabIndex = 4;
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobchargeBindingSource, "Jobno_desc", true));
            this.txtJobDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDesc.Location = new System.Drawing.Point(745, 157);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(200, 21);
            this.txtJobDesc.TabIndex = 2;
            this.txtJobDesc.Validated += new System.EventHandler(this.txtJobDesc_Validated);
            // 
            // txtSubJobNo
            // 
            this.txtSubJobNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobchargeBindingSource, "Subjobno", true));
            this.txtSubJobNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubJobNo.Location = new System.Drawing.Point(745, 131);
            this.txtSubJobNo.Name = "txtSubJobNo";
            this.txtSubJobNo.Size = new System.Drawing.Size(200, 21);
            this.txtSubJobNo.TabIndex = 1;
            this.txtSubJobNo.Validated += new System.EventHandler(this.txtSubJobNo_Validated);
            // 
            // txtSubJobDesc
            // 
            this.txtSubJobDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobchargeBindingSource, "Subjobno_desc", true));
            this.txtSubJobDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubJobDesc.Location = new System.Drawing.Point(745, 184);
            this.txtSubJobDesc.Name = "txtSubJobDesc";
            this.txtSubJobDesc.Size = new System.Drawing.Size(200, 21);
            this.txtSubJobDesc.TabIndex = 3;
            this.txtSubJobDesc.Validated += new System.EventHandler(this.txtSubJobDesc_Validated);
            // 
            // cHIDDataGridViewTextBoxColumn
            // 
            this.cHIDDataGridViewTextBoxColumn.DataPropertyName = "CHID";
            this.cHIDDataGridViewTextBoxColumn.HeaderText = "CHID";
            this.cHIDDataGridViewTextBoxColumn.Name = "cHIDDataGridViewTextBoxColumn";
            this.cHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // jobCodeDataGridViewTextBoxColumn
            // 
            this.jobCodeDataGridViewTextBoxColumn.DataPropertyName = "Job_Code";
            this.jobCodeDataGridViewTextBoxColumn.HeaderText = "Job Code";
            this.jobCodeDataGridViewTextBoxColumn.Name = "jobCodeDataGridViewTextBoxColumn";
            this.jobCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobnoDataGridViewTextBoxColumn
            // 
            this.jobnoDataGridViewTextBoxColumn.DataPropertyName = "Jobno";
            this.jobnoDataGridViewTextBoxColumn.HeaderText = "Job No.";
            this.jobnoDataGridViewTextBoxColumn.Name = "jobnoDataGridViewTextBoxColumn";
            this.jobnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjobnoDataGridViewTextBoxColumn
            // 
            this.subjobnoDataGridViewTextBoxColumn.DataPropertyName = "Subjobno";
            this.subjobnoDataGridViewTextBoxColumn.HeaderText = "Sub-Job No.";
            this.subjobnoDataGridViewTextBoxColumn.Name = "subjobnoDataGridViewTextBoxColumn";
            this.subjobnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjobnoDataGridViewTextBoxColumn.Width = 75;
            // 
            // jobnodescDataGridViewTextBoxColumn
            // 
            this.jobnodescDataGridViewTextBoxColumn.DataPropertyName = "Jobno_desc";
            this.jobnodescDataGridViewTextBoxColumn.HeaderText = "Job Desc.";
            this.jobnodescDataGridViewTextBoxColumn.Name = "jobnodescDataGridViewTextBoxColumn";
            this.jobnodescDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobnodescDataGridViewTextBoxColumn.Width = 250;
            // 
            // subjobnodescDataGridViewTextBoxColumn
            // 
            this.subjobnodescDataGridViewTextBoxColumn.DataPropertyName = "Subjobno_desc";
            this.subjobnodescDataGridViewTextBoxColumn.HeaderText = "Sub-Job Desc.";
            this.subjobnodescDataGridViewTextBoxColumn.Name = "subjobnodescDataGridViewTextBoxColumn";
            this.subjobnodescDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjobnodescDataGridViewTextBoxColumn.Width = 250;
            // 
            // frmMaintainJobCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 572);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.txtSubJobDesc);
            this.Controls.Add(this.txtSubJobNo);
            this.Controls.Add(this.txtJobDesc);
            this.Controls.Add(this.txtJobCharge);
            this.Controls.Add(this.txtJobNo);
            this.Controls.Add(this.jobchargeBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintainJobCharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create and Maintain Job Charge Codes";
            ((System.ComponentModel.ISupportInitialize)(this.jobchargeBindingNavigator)).EndInit();
            this.jobchargeBindingNavigator.ResumeLayout(false);
            this.jobchargeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobchargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource jobchargeBindingSource;
        private System.Windows.Forms.BindingNavigator jobchargeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.ToolStripTextBox toolTxtFindOrderNumber;
        private System.Windows.Forms.ToolStripButton toolBtnFindOrderNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.TextBox txtJobCharge;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtSubJobNo;
        private System.Windows.Forms.TextBox txtSubJobDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjobnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnodescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjobnodescDataGridViewTextBoxColumn;

    }
}