namespace POCS
{
    partial class VendorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorManagement));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.vendorTableAdapter = new POCS.Ds.POCSTableAdapters.VendorTableAdapter();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.txtVendorEmail = new System.Windows.Forms.TextBox();
            this.txtVendorFirmName = new System.Windows.Forms.TextBox();
            this.txtVendorAdd = new System.Windows.Forms.TextBox();
            this.txtVendorPh = new System.Windows.Forms.TextBox();
            this.txtVendorMob = new System.Windows.Forms.TextBox();
            this.txtVendorZip = new System.Windows.Forms.TextBox();
            this.txtVendorFax = new System.Windows.Forms.TextBox();
            this.txtVendorCnctPerson = new System.Windows.Forms.TextBox();
            this.txtVendorCity = new System.Windows.Forms.TextBox();
            this.txtVendorCountry = new System.Windows.Forms.TextBox();
            this.TxtRegNo = new System.Windows.Forms.TextBox();
            this.chkAVL = new System.Windows.Forms.CheckBox();
            this.txtVendorCode = new System.Windows.Forms.TextBox();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvVendors = new System.Windows.Forms.DataGridView();
            this.vendoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcontactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vmobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vzipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vregnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGdATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVLDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdPrintListing = new System.Windows.Forms.Button();
            this.btnShowEditDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(870, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(870, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.pOCS;
            this.vendorBindingSource.PositionChanged += new System.EventHandler(this.vendorBindingSource_PositionChanged);
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POS_DBDataSet";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(1345, -14);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAll.TabIndex = 14;
            this.btnUpdateAll.Text = "Update";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.dtpRegDate);
            this.Frame1.Controls.Add(this.btnReset);
            this.Frame1.Controls.Add(this.btnSave);
            this.Frame1.Controls.Add(this.txtVendorEmail);
            this.Frame1.Controls.Add(this.txtVendorFirmName);
            this.Frame1.Controls.Add(this.txtVendorAdd);
            this.Frame1.Controls.Add(this.txtVendorPh);
            this.Frame1.Controls.Add(this.txtVendorMob);
            this.Frame1.Controls.Add(this.txtVendorZip);
            this.Frame1.Controls.Add(this.txtVendorFax);
            this.Frame1.Controls.Add(this.txtVendorCnctPerson);
            this.Frame1.Controls.Add(this.txtVendorCity);
            this.Frame1.Controls.Add(this.txtVendorCountry);
            this.Frame1.Controls.Add(this.TxtRegNo);
            this.Frame1.Controls.Add(this.chkAVL);
            this.Frame1.Controls.Add(this.txtVendorCode);
            this.Frame1.Controls.Add(this.txtVendorId);
            this.Frame1.Controls.Add(this.Label7);
            this.Frame1.Controls.Add(this.Label24);
            this.Frame1.Controls.Add(this.Label23);
            this.Frame1.Controls.Add(this.Label17);
            this.Frame1.Controls.Add(this.Label19);
            this.Frame1.Controls.Add(this.Label18);
            this.Frame1.Controls.Add(this.Label8);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.Color.Black;
            this.Frame1.Location = new System.Drawing.Point(32, 23);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(967, 279);
            this.Frame1.TabIndex = 34;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Add/ Edit Vendor Details  ";
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegDate.Location = new System.Drawing.Point(567, 246);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(105, 21);
            this.dtpRegDate.TabIndex = 12;
            // 
            // txtVendorEmail
            // 
            this.txtVendorEmail.AcceptsReturn = true;
            this.txtVendorEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorEmail.Location = new System.Drawing.Point(137, 246);
            this.txtVendorEmail.MaxLength = 35;
            this.txtVendorEmail.Name = "txtVendorEmail";
            this.txtVendorEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorEmail.Size = new System.Drawing.Size(192, 21);
            this.txtVendorEmail.TabIndex = 11;
            // 
            // txtVendorFirmName
            // 
            this.txtVendorFirmName.AcceptsReturn = true;
            this.txtVendorFirmName.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorFirmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorFirmName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendorFirmName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorFirmName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorFirmName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorFirmName.Location = new System.Drawing.Point(137, 18);
            this.txtVendorFirmName.MaxLength = 75;
            this.txtVendorFirmName.Name = "txtVendorFirmName";
            this.txtVendorFirmName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorFirmName.Size = new System.Drawing.Size(295, 21);
            this.txtVendorFirmName.TabIndex = 1;
            // 
            // txtVendorAdd
            // 
            this.txtVendorAdd.AcceptsReturn = true;
            this.txtVendorAdd.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendorAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorAdd.Location = new System.Drawing.Point(137, 52);
            this.txtVendorAdd.MaxLength = 255;
            this.txtVendorAdd.Multiline = true;
            this.txtVendorAdd.Name = "txtVendorAdd";
            this.txtVendorAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorAdd.Size = new System.Drawing.Size(192, 45);
            this.txtVendorAdd.TabIndex = 4;
            // 
            // txtVendorPh
            // 
            this.txtVendorPh.AcceptsReturn = true;
            this.txtVendorPh.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorPh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorPh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorPh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorPh.Location = new System.Drawing.Point(137, 178);
            this.txtVendorPh.MaxLength = 20;
            this.txtVendorPh.Name = "txtVendorPh";
            this.txtVendorPh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorPh.Size = new System.Drawing.Size(193, 21);
            this.txtVendorPh.TabIndex = 7;
            // 
            // txtVendorMob
            // 
            this.txtVendorMob.AcceptsReturn = true;
            this.txtVendorMob.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorMob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorMob.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorMob.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorMob.Location = new System.Drawing.Point(567, 212);
            this.txtVendorMob.MaxLength = 20;
            this.txtVendorMob.Name = "txtVendorMob";
            this.txtVendorMob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorMob.Size = new System.Drawing.Size(193, 21);
            this.txtVendorMob.TabIndex = 10;
            // 
            // txtVendorZip
            // 
            this.txtVendorZip.AcceptsReturn = true;
            this.txtVendorZip.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorZip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorZip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorZip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorZip.Location = new System.Drawing.Point(567, 110);
            this.txtVendorZip.MaxLength = 15;
            this.txtVendorZip.Name = "txtVendorZip";
            this.txtVendorZip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorZip.Size = new System.Drawing.Size(105, 21);
            this.txtVendorZip.TabIndex = 6;
            // 
            // txtVendorFax
            // 
            this.txtVendorFax.AcceptsReturn = true;
            this.txtVendorFax.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorFax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorFax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorFax.Location = new System.Drawing.Point(567, 180);
            this.txtVendorFax.MaxLength = 20;
            this.txtVendorFax.Name = "txtVendorFax";
            this.txtVendorFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorFax.Size = new System.Drawing.Size(193, 21);
            this.txtVendorFax.TabIndex = 8;
            // 
            // txtVendorCnctPerson
            // 
            this.txtVendorCnctPerson.AcceptsReturn = true;
            this.txtVendorCnctPerson.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorCnctPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorCnctPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendorCnctPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorCnctPerson.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorCnctPerson.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorCnctPerson.Location = new System.Drawing.Point(137, 212);
            this.txtVendorCnctPerson.MaxLength = 75;
            this.txtVendorCnctPerson.Name = "txtVendorCnctPerson";
            this.txtVendorCnctPerson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorCnctPerson.Size = new System.Drawing.Size(193, 21);
            this.txtVendorCnctPerson.TabIndex = 9;
            // 
            // txtVendorCity
            // 
            this.txtVendorCity.AcceptsReturn = true;
            this.txtVendorCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendorCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorCity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorCity.Location = new System.Drawing.Point(137, 110);
            this.txtVendorCity.MaxLength = 25;
            this.txtVendorCity.Name = "txtVendorCity";
            this.txtVendorCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorCity.Size = new System.Drawing.Size(193, 21);
            this.txtVendorCity.TabIndex = 4;
            // 
            // txtVendorCountry
            // 
            this.txtVendorCountry.AcceptsReturn = true;
            this.txtVendorCountry.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendorCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorCountry.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorCountry.Location = new System.Drawing.Point(137, 144);
            this.txtVendorCountry.MaxLength = 25;
            this.txtVendorCountry.Name = "txtVendorCountry";
            this.txtVendorCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorCountry.Size = new System.Drawing.Size(193, 21);
            this.txtVendorCountry.TabIndex = 5;
            // 
            // TxtRegNo
            // 
            this.TxtRegNo.AcceptsReturn = true;
            this.TxtRegNo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRegNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRegNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRegNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtRegNo.Location = new System.Drawing.Point(567, 18);
            this.TxtRegNo.MaxLength = 30;
            this.TxtRegNo.Name = "TxtRegNo";
            this.TxtRegNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtRegNo.Size = new System.Drawing.Size(105, 21);
            this.TxtRegNo.TabIndex = 2;
            // 
            // chkAVL
            // 
            this.chkAVL.AutoSize = true;
            this.chkAVL.BackColor = System.Drawing.SystemColors.Control;
            this.chkAVL.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAVL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAVL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAVL.Location = new System.Drawing.Point(679, 19);
            this.chkAVL.Name = "chkAVL";
            this.chkAVL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAVL.Size = new System.Drawing.Size(48, 18);
            this.chkAVL.TabIndex = 13;
            this.chkAVL.Text = "AVL";
            this.chkAVL.UseVisualStyleBackColor = false;
            // 
            // txtVendorCode
            // 
            this.txtVendorCode.AcceptsReturn = true;
            this.txtVendorCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendorCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorCode.Location = new System.Drawing.Point(567, 64);
            this.txtVendorCode.MaxLength = 30;
            this.txtVendorCode.Name = "txtVendorCode";
            this.txtVendorCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorCode.Size = new System.Drawing.Size(105, 21);
            this.txtVendorCode.TabIndex = 10;
            // 
            // txtVendorId
            // 
            this.txtVendorId.AcceptsReturn = true;
            this.txtVendorId.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorId.Enabled = false;
            this.txtVendorId.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorId.Location = new System.Drawing.Point(920, 207);
            this.txtVendorId.MaxLength = 0;
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorId.Size = new System.Drawing.Size(25, 20);
            this.txtVendorId.TabIndex = 33;
            this.txtVendorId.Visible = false;
            this.txtVendorId.TextChanged += new System.EventHandler(this.txtVendorId_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(6, 250);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(31, 13);
            this.Label7.TabIndex = 65;
            this.Label7.Text = "Email";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label24.Location = new System.Drawing.Point(456, 68);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(69, 13);
            this.Label24.TabIndex = 50;
            this.Label24.Text = "Vendor Code";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label23.Location = new System.Drawing.Point(456, 250);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label23.Size = new System.Drawing.Size(73, 13);
            this.Label23.TabIndex = 48;
            this.Label23.Text = "Supplier Since";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label17.Location = new System.Drawing.Point(456, 22);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(105, 13);
            this.Label17.TabIndex = 47;
            this.Label17.Text = "Biz. Registration No.";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label19.Location = new System.Drawing.Point(6, 148);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(46, 13);
            this.Label19.TabIndex = 46;
            this.Label19.Text = "Country";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label18.Location = new System.Drawing.Point(6, 114);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(26, 13);
            this.Label18.TabIndex = 45;
            this.Label18.Text = "City";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(6, 22);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(112, 13);
            this.Label8.TabIndex = 44;
            this.Label8.Text = "Company / Firm Name";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(456, 182);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(25, 13);
            this.Label6.TabIndex = 43;
            this.Label6.Text = "Fax";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(456, 114);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(64, 13);
            this.Label5.TabIndex = 42;
            this.Label5.Text = "Postal Code";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(456, 216);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(37, 13);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Mobile";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(6, 182);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "Phone";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(6, 68);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "Address";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(6, 216);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(81, 13);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Contact Person";
            // 
            // dgvVendors
            // 
            this.dgvVendors.AllowUserToAddRows = false;
            this.dgvVendors.AutoGenerateColumns = false;
            this.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendoridDataGridViewTextBoxColumn,
            this.vnameDataGridViewTextBoxColumn,
            this.vcontactpersonDataGridViewTextBoxColumn,
            this.vaddressDataGridViewTextBoxColumn,
            this.vphoneDataGridViewTextBoxColumn,
            this.vmobileDataGridViewTextBoxColumn,
            this.vzipDataGridViewTextBoxColumn,
            this.vfaxDataGridViewTextBoxColumn,
            this.vemailDataGridViewTextBoxColumn,
            this.vstatusDataGridViewTextBoxColumn,
            this.vcityDataGridViewTextBoxColumn,
            this.vcountryDataGridViewTextBoxColumn,
            this.vregnoDataGridViewTextBoxColumn,
            this.rEGdATEDataGridViewTextBoxColumn,
            this.vendorCodeDataGridViewTextBoxColumn,
            this.aVLDataGridViewCheckBoxColumn});
            this.dgvVendors.DataSource = this.vendorBindingSource;
            this.dgvVendors.Location = new System.Drawing.Point(32, 334);
            this.dgvVendors.Name = "dgvVendors";
            this.dgvVendors.Size = new System.Drawing.Size(967, 277);
            this.dgvVendors.TabIndex = 37;
            this.dgvVendors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendors_CellDoubleClick);
            this.dgvVendors.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendors_CellContentDoubleClick);
            this.dgvVendors.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dgvVendors.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // vendoridDataGridViewTextBoxColumn
            // 
            this.vendoridDataGridViewTextBoxColumn.DataPropertyName = "vendor_id";
            this.vendoridDataGridViewTextBoxColumn.HeaderText = "VID";
            this.vendoridDataGridViewTextBoxColumn.Name = "vendoridDataGridViewTextBoxColumn";
            this.vendoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendoridDataGridViewTextBoxColumn.Visible = false;
            // 
            // vnameDataGridViewTextBoxColumn
            // 
            this.vnameDataGridViewTextBoxColumn.DataPropertyName = "v_name";
            this.vnameDataGridViewTextBoxColumn.HeaderText = "Vendor Name";
            this.vnameDataGridViewTextBoxColumn.Name = "vnameDataGridViewTextBoxColumn";
            // 
            // vcontactpersonDataGridViewTextBoxColumn
            // 
            this.vcontactpersonDataGridViewTextBoxColumn.DataPropertyName = "v_contactperson";
            this.vcontactpersonDataGridViewTextBoxColumn.HeaderText = "Contact Person";
            this.vcontactpersonDataGridViewTextBoxColumn.Name = "vcontactpersonDataGridViewTextBoxColumn";
            // 
            // vaddressDataGridViewTextBoxColumn
            // 
            this.vaddressDataGridViewTextBoxColumn.DataPropertyName = "v_address";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vaddressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vaddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.vaddressDataGridViewTextBoxColumn.Name = "vaddressDataGridViewTextBoxColumn";
            // 
            // vphoneDataGridViewTextBoxColumn
            // 
            this.vphoneDataGridViewTextBoxColumn.DataPropertyName = "v_phone";
            this.vphoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.vphoneDataGridViewTextBoxColumn.Name = "vphoneDataGridViewTextBoxColumn";
            // 
            // vmobileDataGridViewTextBoxColumn
            // 
            this.vmobileDataGridViewTextBoxColumn.DataPropertyName = "v_mobile";
            this.vmobileDataGridViewTextBoxColumn.HeaderText = "H/Phone";
            this.vmobileDataGridViewTextBoxColumn.Name = "vmobileDataGridViewTextBoxColumn";
            // 
            // vzipDataGridViewTextBoxColumn
            // 
            this.vzipDataGridViewTextBoxColumn.DataPropertyName = "v_zip";
            this.vzipDataGridViewTextBoxColumn.HeaderText = "Poscode";
            this.vzipDataGridViewTextBoxColumn.Name = "vzipDataGridViewTextBoxColumn";
            // 
            // vfaxDataGridViewTextBoxColumn
            // 
            this.vfaxDataGridViewTextBoxColumn.DataPropertyName = "v_fax";
            this.vfaxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.vfaxDataGridViewTextBoxColumn.Name = "vfaxDataGridViewTextBoxColumn";
            // 
            // vemailDataGridViewTextBoxColumn
            // 
            this.vemailDataGridViewTextBoxColumn.DataPropertyName = "v_email";
            this.vemailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.vemailDataGridViewTextBoxColumn.Name = "vemailDataGridViewTextBoxColumn";
            // 
            // vstatusDataGridViewTextBoxColumn
            // 
            this.vstatusDataGridViewTextBoxColumn.DataPropertyName = "v_status";
            this.vstatusDataGridViewTextBoxColumn.HeaderText = "v_status";
            this.vstatusDataGridViewTextBoxColumn.Name = "vstatusDataGridViewTextBoxColumn";
            this.vstatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // vcityDataGridViewTextBoxColumn
            // 
            this.vcityDataGridViewTextBoxColumn.DataPropertyName = "v_city";
            this.vcityDataGridViewTextBoxColumn.HeaderText = "City";
            this.vcityDataGridViewTextBoxColumn.Name = "vcityDataGridViewTextBoxColumn";
            // 
            // vcountryDataGridViewTextBoxColumn
            // 
            this.vcountryDataGridViewTextBoxColumn.DataPropertyName = "v_country";
            this.vcountryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.vcountryDataGridViewTextBoxColumn.Name = "vcountryDataGridViewTextBoxColumn";
            // 
            // vregnoDataGridViewTextBoxColumn
            // 
            this.vregnoDataGridViewTextBoxColumn.DataPropertyName = "v_regno";
            this.vregnoDataGridViewTextBoxColumn.HeaderText = "Biz. Reg.  No.";
            this.vregnoDataGridViewTextBoxColumn.Name = "vregnoDataGridViewTextBoxColumn";
            // 
            // rEGdATEDataGridViewTextBoxColumn
            // 
            this.rEGdATEDataGridViewTextBoxColumn.DataPropertyName = "rEGdATE";
            this.rEGdATEDataGridViewTextBoxColumn.HeaderText = "Registration Date";
            this.rEGdATEDataGridViewTextBoxColumn.Name = "rEGdATEDataGridViewTextBoxColumn";
            // 
            // vendorCodeDataGridViewTextBoxColumn
            // 
            this.vendorCodeDataGridViewTextBoxColumn.DataPropertyName = "VendorCode";
            this.vendorCodeDataGridViewTextBoxColumn.HeaderText = "Vendor Code";
            this.vendorCodeDataGridViewTextBoxColumn.Name = "vendorCodeDataGridViewTextBoxColumn";
            // 
            // aVLDataGridViewCheckBoxColumn
            // 
            this.aVLDataGridViewCheckBoxColumn.DataPropertyName = "AVL";
            this.aVLDataGridViewCheckBoxColumn.HeaderText = "AVL";
            this.aVLDataGridViewCheckBoxColumn.Name = "aVLDataGridViewCheckBoxColumn";
            // 
            // cmdPrintListing
            // 
            this.cmdPrintListing.Location = new System.Drawing.Point(1133, -14);
            this.cmdPrintListing.Name = "cmdPrintListing";
            this.cmdPrintListing.Size = new System.Drawing.Size(100, 23);
            this.cmdPrintListing.TabIndex = 14;
            this.cmdPrintListing.Text = "Print Listing";
            this.cmdPrintListing.UseVisualStyleBackColor = true;
            this.cmdPrintListing.Click += new System.EventHandler(this.cmdPrintListing_Click);
            // 
            // btnShowEditDetail
            // 
            this.btnShowEditDetail.Location = new System.Drawing.Point(1239, -14);
            this.btnShowEditDetail.Name = "btnShowEditDetail";
            this.btnShowEditDetail.Size = new System.Drawing.Size(100, 23);
            this.btnShowEditDetail.TabIndex = 14;
            this.btnShowEditDetail.Text = "Show / Edit Detail";
            this.btnShowEditDetail.UseVisualStyleBackColor = true;
            this.btnShowEditDetail.Click += new System.EventHandler(this.btnShowEditDetail_Click);
            // 
            // VendorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 623);
            this.Controls.Add(this.dgvVendors);
            this.Controls.Add(this.cmdPrintListing);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.btnShowEditDetail);
            this.Controls.Add(this.btnUpdateAll);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VendorManagement";
            this.Text = "Vendor Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private POCS.Ds.POCS pOCS;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private POCS.Ds.POCSTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.Button btnUpdateAll;
        public System.Windows.Forms.GroupBox Frame1;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        public System.Windows.Forms.TextBox txtVendorEmail;
        public System.Windows.Forms.TextBox txtVendorFirmName;
        public System.Windows.Forms.TextBox txtVendorAdd;
        public System.Windows.Forms.TextBox txtVendorPh;
        public System.Windows.Forms.TextBox txtVendorMob;
        public System.Windows.Forms.TextBox txtVendorZip;
        public System.Windows.Forms.TextBox txtVendorFax;
        public System.Windows.Forms.TextBox txtVendorCnctPerson;
        public System.Windows.Forms.TextBox txtVendorCity;
        public System.Windows.Forms.TextBox txtVendorCountry;
        public System.Windows.Forms.TextBox TxtRegNo;
        public System.Windows.Forms.CheckBox chkAVL;
        public System.Windows.Forms.TextBox txtVendorCode;
        public System.Windows.Forms.TextBox txtVendorId;
        public System.Windows.Forms.Label Label7;
        public System.Windows.Forms.Label Label24;
        public System.Windows.Forms.Label Label23;
        public System.Windows.Forms.Label Label17;
        public System.Windows.Forms.Label Label19;
        public System.Windows.Forms.Label Label18;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label Label6;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dgvVendors;
        private System.Windows.Forms.Button btnShowEditDetail;
        private System.Windows.Forms.Button cmdPrintListing;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcontactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vmobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vzipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vregnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGdATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aVLDataGridViewCheckBoxColumn;
    }
}