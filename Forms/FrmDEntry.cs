using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using POCS.Ds.POCSTableAdapters;
using POCS.Classes;

namespace POCS
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class FrmDEntry : System.Windows.Forms.Form
    {
        #region Declarations
        private decimal decPOID;
        public bool IsEditMode;
        private DataSet dsDetails;
        private DateTimePicker dtpPODate;
        public ComboBox cboVendorName;
        public Label Label12;
        public Label Label4;
        public Label label11;
        private GroupBox groupBox1;
        public TextBox txtPONumber;
        public Label Label3;
        private POCS.Ds.POCS pOCS;
        private BindingSource vendorBindingSource;
        private POCS.Ds.POCSTableAdapters.VendorTableAdapter vendorTableAdapter;
        public Label label1;
        public Label lblPOValue;
        public TextBox txtPODescription;
        private OpenFileDialog openFileDialog1;
        private Button btnSaveOrder;
        public Label label25;
        public TextBox txtVendorRef;
        public Label label26;
        public TextBox txtEndUser;
        public Label label28;
        public ComboBox cmbCurrency;
        private BindingSource deliveryPointsBindingSource;
        private DeliveryPointsTableAdapter deliveryPointsTableAdapter;
        public ComboBox cboOrderType;
        public TextBox textBox1;
        public Label label34;
        private Button btnReset;
        private BindingSource tblUOMBindingSource;
        private tblUOMTableAdapter tblUOMTableAdapter;
        private BindingSource tblChargetypeBindingSource;
        private tblChargetypeTableAdapter tblChargetypeTableAdapter;
        private BindingSource tblOrderTypeBindingSource;
        private tblOrderTypeTableAdapter tblOrderTypeTableAdapter;
        private tblJobChargeTableAdapter tblJobChargeTableAdapter;
        private BindingSource tblExpenseCodeBindingSource;
        private tblExpenseCodeTableAdapter tblExpenseCodeTableAdapter;
        private BindingSource tblJobChargeBindingSource;
        private ErrorProvider warningProvider;
        private BindingSource tblCurrencyBindingSource;
        private tblCurrencyTableAdapter tblCurrencyTableAdapter;
        public ComboBox cboBuyer;
        private BindingSource tblBuyerBindingSource;
        private tblBuyerTableAdapter tblBuyerTableAdapter;
        private IContainer components;
        private Button btnAddVendor;
        private TabControl tabControl1;
        private TabPage tbpMain;
        public GroupBox Frame1;
        private NumericUpDown numPaymentTermsDays;
        public ComboBox cboChargeType;
        public ComboBox cboDeliveryPoint;
        public TextBox txtVendorContactNo;
        public TextBox txtdeliveryDate;
        public TextBox txtContactPerson;
        public TextBox txtProjectName;
        public TextBox txtDeliveryPointAttnTo;
        public TextBox txtAddress;
        public Label label10;
        public Label Label14;
        public Label label27;
        public Label label7;
        public Label Label13;
        public Label label6;
        public Label label29;
        public Label label5;
        public Label Label8;
        public Label Label2;
        private TabPage tbpDetails;
        public GroupBox Frame2;
        private POCS.Controls.NumericTextbox txtDiscountValue;
        private POCS.Controls.NumericTextbox txtWHTaxPercent;
        private POCS.Controls.NumericTextbox txtDiscountPercent;
        private POCS.Controls.NumericTextbox txtUnitPrice;
        private POCS.Controls.NumericTextbox txtQuantity;
        public ComboBox cboExpenseCode;
        public ComboBox cboJobCharge;
        public ComboBox cboUOM;
        private DataGridView dgvPOItems;
        private Button cmdClear;
        private Button btnReplace;
        private Button cmdAddItem;
        public Label lblTotalPrice;
        public TextBox txtPeriod;
        public TextBox txtGroupNote;
        public TextBox txtItemName;
        public TextBox txtChargeCode;
        public TextBox txtMSRNo;
        public Label Label22;
        public Label label30;
        public Label Label21;
        public Label label35;
        public Label label9;
        public Label label32;
        public Label label24;
        public Label Label20;
        public Label label39;
        public Label Label19;
        public Label Label18;
        public Label Label17;
        public Label label33;
        public Label Label16;
        public Label Label15;
        private TabPage tbpPreviewRaise;
        private Label label31;
        private TextBox txtImportantNotes;
        private ArrayList strDetailIDs = new ArrayList();
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataSet dsChargeCodes;
        public Label lblExpenseCodeDesc;
        public Label lblSubJobNoDesc;
        public Label lblJobnoDesc;
        public Label label38;
        public Label label37;
        public Label label36;
        private DataGridView dgvChargeCodeDist;
        private Button btnAddChargeCode;
        private POCS.Controls.NumericTextbox txtDistPercentage;
        private DataGridViewTextBoxColumn clm;
        private DataGridViewTextBoxColumn clmDistPercentage;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label40;
        private ComboBox cboAssetGroup;
        private Label label41;
        private TextBox txtEAJustification;
        private BindingSource tblAssetGroupBindingSource;
        private tblAssetGroupTableAdapter tblAssetGroupTableAdapter;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn MSRNo;
        private DataGridViewTextBoxColumn clmChargeCode;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UOM;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn WHPrice;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn DiscountValue;
        private DataGridViewTextBoxColumn Period;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn PoDetail;
        private DataGridViewTextBoxColumn clmGroupNote;
        private DataGridViewTextBoxColumn clmChargeCodes;
        private DataGridViewTextBoxColumn clmAssetGroup;
        private DataGridViewTextBoxColumn clmAGJustification;
        public Label label23;
        private CheckedListBox clbStandardInsTemplate;
        private Label label42;
        private Button btnImportfromExcel;
        private CheckBox chkExpenseAsset;
        #endregion
        public FrmDEntry()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //clbStandardNotes.BindingContext = new BindingContext();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDEntry));
            this.tblChargetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.deliveryPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblExpenseCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblJobChargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtVendorRef = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.txtEndUser = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.dtpPODate = new System.Windows.Forms.DateTimePicker();
            this.cboVendorName = new System.Windows.Forms.ComboBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.txtPODescription = new System.Windows.Forms.TextBox();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.tblBuyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboOrderType = new System.Windows.Forms.ComboBox();
            this.tblOrderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.tblCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPOValue = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.vendorTableAdapter = new POCS.Ds.POCSTableAdapters.VendorTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.deliveryPointsTableAdapter = new POCS.Ds.POCSTableAdapters.DeliveryPointsTableAdapter();
            this.tblUOMTableAdapter = new POCS.Ds.POCSTableAdapters.tblUOMTableAdapter();
            this.tblChargetypeTableAdapter = new POCS.Ds.POCSTableAdapters.tblChargetypeTableAdapter();
            this.tblOrderTypeTableAdapter = new POCS.Ds.POCSTableAdapters.tblOrderTypeTableAdapter();
            this.tblJobChargeTableAdapter = new POCS.Ds.POCSTableAdapters.tblJobChargeTableAdapter();
            this.tblExpenseCodeTableAdapter = new POCS.Ds.POCSTableAdapters.tblExpenseCodeTableAdapter();
            this.warningProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblCurrencyTableAdapter = new POCS.Ds.POCSTableAdapters.tblCurrencyTableAdapter();
            this.tblBuyerTableAdapter = new POCS.Ds.POCSTableAdapters.tblBuyerTableAdapter();
            this.tbpPreviewRaise = new System.Windows.Forms.TabPage();
            this.clbStandardInsTemplate = new System.Windows.Forms.CheckedListBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtImportantNotes = new System.Windows.Forms.TextBox();
            this.tbpDetails = new System.Windows.Forms.TabPage();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.chkExpenseAsset = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.btnAddChargeCode = new System.Windows.Forms.Button();
            this.lblSubJobNoDesc = new System.Windows.Forms.Label();
            this.txtDistPercentage = new POCS.Controls.NumericTextbox();
            this.lblExpenseCodeDesc = new System.Windows.Forms.Label();
            this.dgvChargeCodeDist = new System.Windows.Forms.DataGridView();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDistPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblJobnoDesc = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtChargeCode = new System.Windows.Forms.TextBox();
            this.cboExpenseCode = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.cboJobCharge = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEAJustification = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.cboAssetGroup = new System.Windows.Forms.ComboBox();
            this.tblAssetGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDiscountValue = new POCS.Controls.NumericTextbox();
            this.txtWHTaxPercent = new POCS.Controls.NumericTextbox();
            this.txtDiscountPercent = new POCS.Controls.NumericTextbox();
            this.txtUnitPrice = new POCS.Controls.NumericTextbox();
            this.txtQuantity = new POCS.Controls.NumericTextbox();
            this.cboUOM = new System.Windows.Forms.ComboBox();
            this.dgvPOItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChargeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WHPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGroupNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChargeCodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAssetGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAGJustification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdClear = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.cmdAddItem = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtGroupNote = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtMSRNo = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.tbpMain = new System.Windows.Forms.TabPage();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.numPaymentTermsDays = new System.Windows.Forms.NumericUpDown();
            this.cboChargeType = new System.Windows.Forms.ComboBox();
            this.cboDeliveryPoint = new System.Windows.Forms.ComboBox();
            this.txtVendorContactNo = new System.Windows.Forms.TextBox();
            this.txtdeliveryDate = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtDeliveryPointAttnTo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsChargeCodes = new System.Data.DataSet();
            this.tblAssetGroupTableAdapter = new POCS.Ds.POCSTableAdapters.tblAssetGroupTableAdapter();
            this.btnImportfromExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblChargetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobChargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningProvider)).BeginInit();
            this.tbpPreviewRaise.SuspendLayout();
            this.tbpDetails.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeCodeDist)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssetGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItems)).BeginInit();
            this.tbpMain.SuspendLayout();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentTermsDays)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsChargeCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // tblChargetypeBindingSource
            // 
            this.tblChargetypeBindingSource.DataMember = "tblChargetype";
            this.tblChargetypeBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POS_DBDataSet";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryPointsBindingSource
            // 
            this.deliveryPointsBindingSource.DataMember = "DeliveryPoints";
            this.deliveryPointsBindingSource.DataSource = this.pOCS;
            // 
            // tblExpenseCodeBindingSource
            // 
            this.tblExpenseCodeBindingSource.DataMember = "tblExpenseCode";
            this.tblExpenseCodeBindingSource.DataSource = this.pOCS;
            // 
            // tblJobChargeBindingSource
            // 
            this.tblJobChargeBindingSource.DataMember = "tblJobCharge";
            this.tblJobChargeBindingSource.DataSource = this.pOCS;
            // 
            // tblUOMBindingSource
            // 
            this.tblUOMBindingSource.DataMember = "tblUOM";
            this.tblUOMBindingSource.DataSource = this.pOCS;
            // 
            // txtVendorRef
            // 
            this.txtVendorRef.AcceptsReturn = true;
            this.txtVendorRef.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorRef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorRef.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorRef.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorRef.Location = new System.Drawing.Point(485, 48);
            this.txtVendorRef.MaxLength = 0;
            this.txtVendorRef.Name = "txtVendorRef";
            this.txtVendorRef.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorRef.Size = new System.Drawing.Size(120, 20);
            this.txtVendorRef.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.Control;
            this.label26.Cursor = System.Windows.Forms.Cursors.Default;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label26.Location = new System.Drawing.Point(413, 52);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label26.Size = new System.Drawing.Size(65, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "Vendor Ref.";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(849, 19);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(117, 23);
            this.btnSaveOrder.TabIndex = 35;
            this.btnSaveOrder.Text = "Save PO";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // txtEndUser
            // 
            this.txtEndUser.AcceptsReturn = true;
            this.txtEndUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndUser.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndUser.Location = new System.Drawing.Point(485, 76);
            this.txtEndUser.MaxLength = 25;
            this.txtEndUser.Name = "txtEndUser";
            this.txtEndUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndUser.Size = new System.Drawing.Size(120, 20);
            this.txtEndUser.TabIndex = 6;
            this.txtEndUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtEndUser_Validating);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.Control;
            this.label25.Cursor = System.Windows.Forms.Cursors.Default;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(611, 80);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "Buyer";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.Control;
            this.label28.Cursor = System.Windows.Forms.Cursors.Default;
            this.label28.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(413, 80);
            this.label28.Name = "label28";
            this.label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label28.Size = new System.Drawing.Size(57, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "Requestor";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.SystemColors.Control;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(219, 52);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(51, 13);
            this.Label12.TabIndex = 26;
            this.Label12.Text = "Currency";
            // 
            // dtpPODate
            // 
            this.dtpPODate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPODate.Location = new System.Drawing.Point(272, 21);
            this.dtpPODate.Name = "dtpPODate";
            this.dtpPODate.Size = new System.Drawing.Size(102, 21);
            this.dtpPODate.TabIndex = 1;
            // 
            // cboVendorName
            // 
            this.cboVendorName.BackColor = System.Drawing.SystemColors.Window;
            this.cboVendorName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVendorName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOCS, "Vendor.v_name", true));
            this.cboVendorName.DataSource = this.vendorBindingSource;
            this.cboVendorName.DisplayMember = "v_name";
            this.cboVendorName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendorName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVendorName.Location = new System.Drawing.Point(485, 21);
            this.cboVendorName.Name = "cboVendorName";
            this.cboVendorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVendorName.Size = new System.Drawing.Size(314, 21);
            this.cboVendorName.TabIndex = 4;
            this.cboVendorName.ValueMember = "vendor_id";
            this.cboVendorName.Validated += new System.EventHandler(this.cboVendorName_Validated);
            this.cboVendorName.SelectedIndexChanged += new System.EventHandler(this.cboVendorName_SelectedIndexChanged);
            this.cboVendorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboVendorName_KeyPress);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.pOCS;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(219, 25);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "PO Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(413, 25);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Vendor Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddVendor);
            this.groupBox1.Controls.Add(this.txtPODescription);
            this.groupBox1.Controls.Add(this.cboBuyer);
            this.groupBox1.Controls.Add(this.cboOrderType);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSaveOrder);
            this.groupBox1.Controls.Add(this.cmbCurrency);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtEndUser);
            this.groupBox1.Controls.Add(this.txtVendorRef);
            this.groupBox1.Controls.Add(this.lblPOValue);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpPODate);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtPONumber);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.cboVendorName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label12);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PO Header";
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(810, 19);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(33, 23);
            this.btnAddVendor.TabIndex = 37;
            this.btnAddVendor.Text = "...";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // txtPODescription
            // 
            this.txtPODescription.AcceptsReturn = true;
            this.txtPODescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtPODescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPODescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPODescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPODescription.Location = new System.Drawing.Point(99, 76);
            this.txtPODescription.MaxLength = 0;
            this.txtPODescription.Name = "txtPODescription";
            this.txtPODescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPODescription.Size = new System.Drawing.Size(308, 20);
            this.txtPODescription.TabIndex = 3;
            // 
            // cboBuyer
            // 
            this.cboBuyer.BackColor = System.Drawing.SystemColors.Window;
            this.cboBuyer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboBuyer.DataSource = this.tblBuyerBindingSource;
            this.cboBuyer.DisplayMember = "BuyerIntial";
            this.cboBuyer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuyer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboBuyer.Location = new System.Drawing.Point(666, 76);
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboBuyer.Size = new System.Drawing.Size(70, 21);
            this.cboBuyer.TabIndex = 7;
            this.cboBuyer.ValueMember = "BuyerID";
            // 
            // tblBuyerBindingSource
            // 
            this.tblBuyerBindingSource.DataMember = "tblBuyer";
            this.tblBuyerBindingSource.DataSource = this.pOCS;
            // 
            // cboOrderType
            // 
            this.cboOrderType.BackColor = System.Drawing.SystemColors.Window;
            this.cboOrderType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboOrderType.DataSource = this.tblOrderTypeBindingSource;
            this.cboOrderType.DisplayMember = "OrderType";
            this.cboOrderType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrderType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboOrderType.Location = new System.Drawing.Point(666, 47);
            this.cboOrderType.Name = "cboOrderType";
            this.cboOrderType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboOrderType.Size = new System.Drawing.Size(44, 21);
            this.cboOrderType.TabIndex = 8;
            this.cboOrderType.ValueMember = "OrderType_id";
            this.cboOrderType.Validated += new System.EventHandler(this.cboOrderType_Validated);
            // 
            // tblOrderTypeBindingSource
            // 
            this.tblOrderTypeBindingSource.DataMember = "tblOrderType";
            this.tblOrderTypeBindingSource.DataSource = this.pOCS;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(849, 47);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 23);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCurrency.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbCurrency.DataSource = this.tblCurrencyBindingSource;
            this.cmbCurrency.DisplayMember = "Currency";
            this.cmbCurrency.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCurrency.Location = new System.Drawing.Point(272, 48);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCurrency.Size = new System.Drawing.Size(60, 21);
            this.cmbCurrency.TabIndex = 2;
            this.cmbCurrency.ValueMember = "CurrencyID";
            this.cmbCurrency.Validated += new System.EventHandler(this.cmbCurrency_Validated);
            // 
            // tblCurrencyBindingSource
            // 
            this.tblCurrencyBindingSource.DataMember = "tblCurrency";
            this.tblCurrencyBindingSource.DataSource = this.pOCS;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(716, 47);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lblPOValue
            // 
            this.lblPOValue.AutoSize = true;
            this.lblPOValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblPOValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPOValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPOValue.Location = new System.Drawing.Point(96, 52);
            this.lblPOValue.Name = "lblPOValue";
            this.lblPOValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPOValue.Size = new System.Drawing.Size(14, 13);
            this.lblPOValue.TabIndex = 34;
            this.lblPOValue.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(11, 79);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(81, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "PO. Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "PO. Value";
            // 
            // txtPONumber
            // 
            this.txtPONumber.AcceptsReturn = true;
            this.txtPONumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPONumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPONumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPONumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPONumber.Location = new System.Drawing.Point(99, 20);
            this.txtPONumber.MaxLength = 0;
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPONumber.Size = new System.Drawing.Size(102, 23);
            this.txtPONumber.TabIndex = 0;
            this.txtPONumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPONumber.TextChanged += new System.EventHandler(this.txtPONumber_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(13, 25);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(65, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "PO. Number";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Control;
            this.label34.Cursor = System.Windows.Forms.Cursors.Default;
            this.label34.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label34.Location = new System.Drawing.Point(611, 51);
            this.label34.Name = "label34";
            this.label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label34.Size = new System.Drawing.Size(49, 13);
            this.label34.TabIndex = 15;
            this.label34.Text = "Our Ref.";
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // deliveryPointsTableAdapter
            // 
            this.deliveryPointsTableAdapter.ClearBeforeFill = true;
            // 
            // tblUOMTableAdapter
            // 
            this.tblUOMTableAdapter.ClearBeforeFill = true;
            // 
            // tblChargetypeTableAdapter
            // 
            this.tblChargetypeTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderTypeTableAdapter
            // 
            this.tblOrderTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tblJobChargeTableAdapter
            // 
            this.tblJobChargeTableAdapter.ClearBeforeFill = true;
            // 
            // tblExpenseCodeTableAdapter
            // 
            this.tblExpenseCodeTableAdapter.ClearBeforeFill = true;
            // 
            // warningProvider
            // 
            this.warningProvider.ContainerControl = this;
            // 
            // tblCurrencyTableAdapter
            // 
            this.tblCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // tblBuyerTableAdapter
            // 
            this.tblBuyerTableAdapter.ClearBeforeFill = true;
            // 
            // tbpPreviewRaise
            // 
            this.tbpPreviewRaise.Controls.Add(this.clbStandardInsTemplate);
            this.tbpPreviewRaise.Controls.Add(this.label42);
            this.tbpPreviewRaise.Controls.Add(this.label31);
            this.tbpPreviewRaise.Controls.Add(this.txtImportantNotes);
            this.tbpPreviewRaise.Location = new System.Drawing.Point(4, 22);
            this.tbpPreviewRaise.Name = "tbpPreviewRaise";
            this.tbpPreviewRaise.Size = new System.Drawing.Size(968, 502);
            this.tbpPreviewRaise.TabIndex = 3;
            this.tbpPreviewRaise.Text = "PO Notes / Instructions";
            this.tbpPreviewRaise.UseVisualStyleBackColor = true;
            // 
            // clbStandardInsTemplate
            // 
            this.clbStandardInsTemplate.CheckOnClick = true;
            this.clbStandardInsTemplate.FormattingEnabled = true;
            this.clbStandardInsTemplate.HorizontalScrollbar = true;
            this.clbStandardInsTemplate.Location = new System.Drawing.Point(14, 27);
            this.clbStandardInsTemplate.Name = "clbStandardInsTemplate";
            this.clbStandardInsTemplate.Size = new System.Drawing.Size(711, 84);
            this.clbStandardInsTemplate.TabIndex = 36;
            this.clbStandardInsTemplate.SelectedIndexChanged += new System.EventHandler(this.clbStandardInsTemplate_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(11, 11);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(158, 13);
            this.label42.TabIndex = 2;
            this.label42.Text = "Standard Instructions Template";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 117);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(167, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Important Notes and Instructions";
            // 
            // txtImportantNotes
            // 
            this.txtImportantNotes.Location = new System.Drawing.Point(14, 133);
            this.txtImportantNotes.Multiline = true;
            this.txtImportantNotes.Name = "txtImportantNotes";
            this.txtImportantNotes.Size = new System.Drawing.Size(711, 118);
            this.txtImportantNotes.TabIndex = 34;
            // 
            // tbpDetails
            // 
            this.tbpDetails.Controls.Add(this.Frame2);
            this.tbpDetails.Location = new System.Drawing.Point(4, 22);
            this.tbpDetails.Name = "tbpDetails";
            this.tbpDetails.Size = new System.Drawing.Size(968, 502);
            this.tbpDetails.TabIndex = 1;
            this.tbpDetails.Text = "Purchase Order Details";
            this.tbpDetails.UseVisualStyleBackColor = true;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.btnImportfromExcel);
            this.Frame2.Controls.Add(this.chkExpenseAsset);
            this.Frame2.Controls.Add(this.tabControl2);
            this.Frame2.Controls.Add(this.txtDiscountValue);
            this.Frame2.Controls.Add(this.txtWHTaxPercent);
            this.Frame2.Controls.Add(this.txtDiscountPercent);
            this.Frame2.Controls.Add(this.txtUnitPrice);
            this.Frame2.Controls.Add(this.txtQuantity);
            this.Frame2.Controls.Add(this.cboUOM);
            this.Frame2.Controls.Add(this.dgvPOItems);
            this.Frame2.Controls.Add(this.cmdClear);
            this.Frame2.Controls.Add(this.btnReplace);
            this.Frame2.Controls.Add(this.cmdAddItem);
            this.Frame2.Controls.Add(this.lblTotalPrice);
            this.Frame2.Controls.Add(this.txtPeriod);
            this.Frame2.Controls.Add(this.txtGroupNote);
            this.Frame2.Controls.Add(this.txtItemName);
            this.Frame2.Controls.Add(this.txtMSRNo);
            this.Frame2.Controls.Add(this.Label22);
            this.Frame2.Controls.Add(this.label30);
            this.Frame2.Controls.Add(this.Label21);
            this.Frame2.Controls.Add(this.label35);
            this.Frame2.Controls.Add(this.label9);
            this.Frame2.Controls.Add(this.label32);
            this.Frame2.Controls.Add(this.label24);
            this.Frame2.Controls.Add(this.Label20);
            this.Frame2.Controls.Add(this.label39);
            this.Frame2.Controls.Add(this.Label19);
            this.Frame2.Controls.Add(this.Label18);
            this.Frame2.Controls.Add(this.Label17);
            this.Frame2.Controls.Add(this.Label16);
            this.Frame2.Controls.Add(this.Label15);
            this.Frame2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(3, 13);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(954, 475);
            this.Frame2.TabIndex = 34;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Add PO Items";
            // 
            // chkExpenseAsset
            // 
            this.chkExpenseAsset.AutoSize = true;
            this.chkExpenseAsset.Location = new System.Drawing.Point(334, 231);
            this.chkExpenseAsset.Name = "chkExpenseAsset";
            this.chkExpenseAsset.Size = new System.Drawing.Size(97, 17);
            this.chkExpenseAsset.TabIndex = 56;
            this.chkExpenseAsset.Text = "Expense Asset";
            this.chkExpenseAsset.UseVisualStyleBackColor = true;
            this.chkExpenseAsset.CheckedChanged += new System.EventHandler(this.chkExpenseAsset_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(433, 14);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(441, 240);
            this.tabControl2.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.btnAddChargeCode);
            this.tabPage1.Controls.Add(this.lblSubJobNoDesc);
            this.tabPage1.Controls.Add(this.txtDistPercentage);
            this.tabPage1.Controls.Add(this.lblExpenseCodeDesc);
            this.tabPage1.Controls.Add(this.dgvChargeCodeDist);
            this.tabPage1.Controls.Add(this.lblJobnoDesc);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.txtChargeCode);
            this.tabPage1.Controls.Add(this.cboExpenseCode);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.cboJobCharge);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Charge Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.label33.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(6, 13);
            this.label33.Name = "label33";
            this.label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label33.Size = new System.Drawing.Size(70, 13);
            this.label33.TabIndex = 38;
            this.label33.Text = "Charge Code";
            // 
            // btnAddChargeCode
            // 
            this.btnAddChargeCode.Location = new System.Drawing.Point(340, 35);
            this.btnAddChargeCode.Name = "btnAddChargeCode";
            this.btnAddChargeCode.Size = new System.Drawing.Size(33, 23);
            this.btnAddChargeCode.TabIndex = 37;
            this.btnAddChargeCode.Text = "+";
            this.btnAddChargeCode.UseVisualStyleBackColor = true;
            this.btnAddChargeCode.Click += new System.EventHandler(this.btnAddChargeCode_Click);
            // 
            // lblSubJobNoDesc
            // 
            this.lblSubJobNoDesc.AutoSize = true;
            this.lblSubJobNoDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblSubJobNoDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSubJobNoDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJobNoDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubJobNoDesc.Location = new System.Drawing.Point(89, 175);
            this.lblSubJobNoDesc.Name = "lblSubJobNoDesc";
            this.lblSubJobNoDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubJobNoDesc.Size = new System.Drawing.Size(11, 13);
            this.lblSubJobNoDesc.TabIndex = 38;
            this.lblSubJobNoDesc.Text = "-";
            // 
            // txtDistPercentage
            // 
            this.txtDistPercentage.CommaFormat = true;
            this.txtDistPercentage.CurrencyFormat = false;
            this.txtDistPercentage.DecimalPrecision = 2;
            this.txtDistPercentage.Location = new System.Drawing.Point(285, 35);
            this.txtDistPercentage.Name = "txtDistPercentage";
            this.txtDistPercentage.PercentFormat = false;
            this.txtDistPercentage.ReadOnly = false;
            this.txtDistPercentage.Size = new System.Drawing.Size(49, 24);
            this.txtDistPercentage.TabIndex = 24;
            // 
            // lblExpenseCodeDesc
            // 
            this.lblExpenseCodeDesc.AutoSize = true;
            this.lblExpenseCodeDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblExpenseCodeDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExpenseCodeDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseCodeDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExpenseCodeDesc.Location = new System.Drawing.Point(89, 193);
            this.lblExpenseCodeDesc.Name = "lblExpenseCodeDesc";
            this.lblExpenseCodeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExpenseCodeDesc.Size = new System.Drawing.Size(11, 13);
            this.lblExpenseCodeDesc.TabIndex = 38;
            this.lblExpenseCodeDesc.Text = "-";
            // 
            // dgvChargeCodeDist
            // 
            this.dgvChargeCodeDist.AllowUserToAddRows = false;
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
            this.clm,
            this.clmDistPercentage});
            this.dgvChargeCodeDist.Location = new System.Drawing.Point(92, 63);
            this.dgvChargeCodeDist.Name = "dgvChargeCodeDist";
            this.dgvChargeCodeDist.ReadOnly = true;
            this.dgvChargeCodeDist.Size = new System.Drawing.Size(327, 85);
            this.dgvChargeCodeDist.TabIndex = 53;
            // 
            // clm
            // 
            this.clm.DataPropertyName = "ChargeCode";
            this.clm.HeaderText = "Charge Code";
            this.clm.Name = "clm";
            this.clm.ReadOnly = true;
            this.clm.Width = 150;
            // 
            // clmDistPercentage
            // 
            this.clmDistPercentage.DataPropertyName = "DistPercentage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmDistPercentage.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDistPercentage.HeaderText = "%";
            this.clmDistPercentage.Name = "clmDistPercentage";
            this.clmDistPercentage.ReadOnly = true;
            this.clmDistPercentage.Width = 50;
            // 
            // lblJobnoDesc
            // 
            this.lblJobnoDesc.AutoSize = true;
            this.lblJobnoDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblJobnoDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblJobnoDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobnoDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJobnoDesc.Location = new System.Drawing.Point(89, 157);
            this.lblJobnoDesc.Name = "lblJobnoDesc";
            this.lblJobnoDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblJobnoDesc.Size = new System.Drawing.Size(11, 13);
            this.lblJobnoDesc.TabIndex = 38;
            this.lblJobnoDesc.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.label36.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label36.Location = new System.Drawing.Point(6, 157);
            this.label36.Name = "label36";
            this.label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label36.Size = new System.Drawing.Size(54, 13);
            this.label36.TabIndex = 38;
            this.label36.Text = "Job Desc.";
            // 
            // txtChargeCode
            // 
            this.txtChargeCode.AcceptsReturn = true;
            this.txtChargeCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtChargeCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChargeCode.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChargeCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtChargeCode.Location = new System.Drawing.Point(92, 35);
            this.txtChargeCode.MaxLength = 0;
            this.txtChargeCode.Name = "txtChargeCode";
            this.txtChargeCode.ReadOnly = true;
            this.txtChargeCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtChargeCode.Size = new System.Drawing.Size(187, 20);
            this.txtChargeCode.TabIndex = 17;
            // 
            // cboExpenseCode
            // 
            this.cboExpenseCode.BackColor = System.Drawing.SystemColors.Window;
            this.cboExpenseCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboExpenseCode.DataSource = this.tblExpenseCodeBindingSource;
            this.cboExpenseCode.DisplayMember = "ExpenseCode";
            this.cboExpenseCode.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExpenseCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboExpenseCode.Location = new System.Drawing.Point(204, 9);
            this.cboExpenseCode.Name = "cboExpenseCode";
            this.cboExpenseCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboExpenseCode.Size = new System.Drawing.Size(75, 21);
            this.cboExpenseCode.TabIndex = 22;
            this.cboExpenseCode.ValueMember = "ExDescription";
            this.cboExpenseCode.Validated += new System.EventHandler(this.cboExpenseCode_Validated);
            this.cboExpenseCode.SelectedIndexChanged += new System.EventHandler(this.cboExpenseCode_SelectedIndexChanged);
            this.cboExpenseCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboExpenseCode_KeyPress);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Cursor = System.Windows.Forms.Cursors.Default;
            this.label38.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label38.Location = new System.Drawing.Point(6, 193);
            this.label38.Name = "label38";
            this.label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label38.Size = new System.Drawing.Size(78, 13);
            this.label38.TabIndex = 38;
            this.label38.Text = "Expense Desc.";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Cursor = System.Windows.Forms.Cursors.Default;
            this.label37.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label37.Location = new System.Drawing.Point(6, 175);
            this.label37.Name = "label37";
            this.label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label37.Size = new System.Drawing.Size(76, 13);
            this.label37.TabIndex = 38;
            this.label37.Text = "Sub-Job Desc.";
            // 
            // cboJobCharge
            // 
            this.cboJobCharge.BackColor = System.Drawing.SystemColors.Window;
            this.cboJobCharge.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboJobCharge.DataSource = this.tblJobChargeBindingSource;
            this.cboJobCharge.DisplayMember = "job_code";
            this.cboJobCharge.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJobCharge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboJobCharge.Location = new System.Drawing.Point(92, 9);
            this.cboJobCharge.Name = "cboJobCharge";
            this.cboJobCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboJobCharge.Size = new System.Drawing.Size(106, 21);
            this.cboJobCharge.TabIndex = 21;
            this.cboJobCharge.ValueMember = "ChID";
            this.cboJobCharge.Validated += new System.EventHandler(this.cboJobCharge_Validated);
            this.cboJobCharge.SelectedIndexChanged += new System.EventHandler(this.cboJobCharge_SelectedIndexChanged);
            this.cboJobCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboJobCharge_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEAJustification);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.cboAssetGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Expense Asset";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEAJustification
            // 
            this.txtEAJustification.Location = new System.Drawing.Point(104, 44);
            this.txtEAJustification.Multiline = true;
            this.txtEAJustification.Name = "txtEAJustification";
            this.txtEAJustification.Size = new System.Drawing.Size(299, 95);
            this.txtEAJustification.TabIndex = 2;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 52);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(64, 13);
            this.label41.TabIndex = 1;
            this.label41.Text = "Justification";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(66, 13);
            this.label40.TabIndex = 1;
            this.label40.Text = "Asset Group";
            // 
            // cboAssetGroup
            // 
            this.cboAssetGroup.DataSource = this.tblAssetGroupBindingSource;
            this.cboAssetGroup.DisplayMember = "AssetGroup";
            this.cboAssetGroup.FormattingEnabled = true;
            this.cboAssetGroup.Location = new System.Drawing.Point(104, 13);
            this.cboAssetGroup.Name = "cboAssetGroup";
            this.cboAssetGroup.Size = new System.Drawing.Size(121, 21);
            this.cboAssetGroup.TabIndex = 0;
            this.cboAssetGroup.ValueMember = "AssetGroupID";
            // 
            // tblAssetGroupBindingSource
            // 
            this.tblAssetGroupBindingSource.DataMember = "tblAssetGroup";
            this.tblAssetGroupBindingSource.DataSource = this.pOCS;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.CommaFormat = true;
            this.txtDiscountValue.CurrencyFormat = false;
            this.txtDiscountValue.DecimalPrecision = 2;
            this.txtDiscountValue.Location = new System.Drawing.Point(255, 206);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.PercentFormat = false;
            this.txtDiscountValue.ReadOnly = false;
            this.txtDiscountValue.Size = new System.Drawing.Size(80, 24);
            this.txtDiscountValue.TabIndex = 29;
            // 
            // txtWHTaxPercent
            // 
            this.txtWHTaxPercent.CommaFormat = false;
            this.txtWHTaxPercent.CurrencyFormat = false;
            this.txtWHTaxPercent.DecimalPrecision = 2;
            this.txtWHTaxPercent.Location = new System.Drawing.Point(90, 229);
            this.txtWHTaxPercent.Name = "txtWHTaxPercent";
            this.txtWHTaxPercent.PercentFormat = false;
            this.txtWHTaxPercent.ReadOnly = false;
            this.txtWHTaxPercent.Size = new System.Drawing.Size(50, 24);
            this.txtWHTaxPercent.TabIndex = 30;
            this.txtWHTaxPercent.Validated += new System.EventHandler(this.txtWHTaxPercent_Validated);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.CommaFormat = false;
            this.txtDiscountPercent.CurrencyFormat = false;
            this.txtDiscountPercent.DecimalPrecision = 2;
            this.txtDiscountPercent.Location = new System.Drawing.Point(90, 206);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.PercentFormat = false;
            this.txtDiscountPercent.ReadOnly = false;
            this.txtDiscountPercent.Size = new System.Drawing.Size(50, 24);
            this.txtDiscountPercent.TabIndex = 28;
            this.txtDiscountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountPercent_KeyPress);
            this.txtDiscountPercent.Validated += new System.EventHandler(this.txtDiscountPercent_Validated);
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.txtDiscountPercent_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.CommaFormat = true;
            this.txtUnitPrice.CurrencyFormat = false;
            this.txtUnitPrice.DecimalPrecision = 6;
            this.txtUnitPrice.Location = new System.Drawing.Point(255, 177);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PercentFormat = false;
            this.txtUnitPrice.ReadOnly = false;
            this.txtUnitPrice.Size = new System.Drawing.Size(80, 24);
            this.txtUnitPrice.TabIndex = 26;
            // 
            // txtQuantity
            // 
            this.txtQuantity.CommaFormat = true;
            this.txtQuantity.CurrencyFormat = false;
            this.txtQuantity.DecimalPrecision = 2;
            this.txtQuantity.Location = new System.Drawing.Point(255, 151);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PercentFormat = false;
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.Size = new System.Drawing.Size(80, 24);
            this.txtQuantity.TabIndex = 24;
            // 
            // cboUOM
            // 
            this.cboUOM.BackColor = System.Drawing.SystemColors.Window;
            this.cboUOM.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboUOM.DataSource = this.tblUOMBindingSource;
            this.cboUOM.DisplayMember = "uom";
            this.cboUOM.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUOM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboUOM.Location = new System.Drawing.Point(90, 179);
            this.cboUOM.Name = "cboUOM";
            this.cboUOM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboUOM.Size = new System.Drawing.Size(80, 21);
            this.cboUOM.TabIndex = 25;
            this.cboUOM.ValueMember = "uom_id";
            this.cboUOM.Validated += new System.EventHandler(this.cboUOM_Validated);
            this.cboUOM.SelectedIndexChanged += new System.EventHandler(this.cboUOM_SelectedIndexChanged);
            // 
            // dgvPOItems
            // 
            this.dgvPOItems.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPOItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPOItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.MSRNo,
            this.clmChargeCode,
            this.Quantity,
            this.UOM,
            this.UnitPrice,
            this.WHPrice,
            this.Discount,
            this.DiscountValue,
            this.Period,
            this.TotalPrice,
            this.PoDetail,
            this.clmGroupNote,
            this.clmChargeCodes,
            this.clmAssetGroup,
            this.clmAGJustification});
            this.dgvPOItems.Location = new System.Drawing.Point(11, 260);
            this.dgvPOItems.Name = "dgvPOItems";
            this.dgvPOItems.ReadOnly = true;
            this.dgvPOItems.Size = new System.Drawing.Size(924, 209);
            this.dgvPOItems.TabIndex = 35;
            this.dgvPOItems.SelectionChanged += new System.EventHandler(this.dgvPOItems_SelectionChanged);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Description";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 300;
            // 
            // MSRNo
            // 
            this.MSRNo.HeaderText = "MSR No";
            this.MSRNo.Name = "MSRNo";
            this.MSRNo.ReadOnly = true;
            this.MSRNo.Width = 50;
            // 
            // clmChargeCode
            // 
            this.clmChargeCode.HeaderText = "Charge Code";
            this.clmChargeCode.Name = "clmChargeCode";
            this.clmChargeCode.ReadOnly = true;
            this.clmChargeCode.Visible = false;
            // 
            // Quantity
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 75;
            // 
            // UOM
            // 
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            this.UOM.ReadOnly = true;
            this.UOM.Width = 50;
            // 
            // UnitPrice
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C6";
            dataGridViewCellStyle6.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 75;
            // 
            // WHPrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.WHPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.WHPrice.HeaderText = "W/H Tax";
            this.WHPrice.Name = "WHPrice";
            this.WHPrice.ReadOnly = true;
            this.WHPrice.Width = 30;
            // 
            // Discount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle8;
            this.Discount.HeaderText = "Disc. %";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 30;
            // 
            // DiscountValue
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.DiscountValue.DefaultCellStyle = dataGridViewCellStyle9;
            this.DiscountValue.HeaderText = "Disc. Value";
            this.DiscountValue.Name = "DiscountValue";
            this.DiscountValue.ReadOnly = true;
            // 
            // Period
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Period.DefaultCellStyle = dataGridViewCellStyle10;
            this.Period.HeaderText = "Dur.";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            this.Period.Width = 30;
            // 
            // TotalPrice
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle11;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 120;
            // 
            // PoDetail
            // 
            this.PoDetail.HeaderText = "PoDetail";
            this.PoDetail.Name = "PoDetail";
            this.PoDetail.ReadOnly = true;
            this.PoDetail.Visible = false;
            // 
            // clmGroupNote
            // 
            this.clmGroupNote.HeaderText = "Group Note";
            this.clmGroupNote.Name = "clmGroupNote";
            this.clmGroupNote.ReadOnly = true;
            this.clmGroupNote.Width = 150;
            // 
            // clmChargeCodes
            // 
            this.clmChargeCodes.HeaderText = "ChargeCodes";
            this.clmChargeCodes.Name = "clmChargeCodes";
            this.clmChargeCodes.ReadOnly = true;
            // 
            // clmAssetGroup
            // 
            this.clmAssetGroup.HeaderText = "AssetGroup";
            this.clmAssetGroup.Name = "clmAssetGroup";
            this.clmAssetGroup.ReadOnly = true;
            // 
            // clmAGJustification
            // 
            this.clmAGJustification.HeaderText = "Justification";
            this.clmAGJustification.Name = "clmAGJustification";
            this.clmAGJustification.ReadOnly = true;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(876, 78);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 33;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(876, 49);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 32;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // cmdAddItem
            // 
            this.cmdAddItem.Location = new System.Drawing.Point(876, 22);
            this.cmdAddItem.Name = "cmdAddItem";
            this.cmdAddItem.Size = new System.Drawing.Size(75, 23);
            this.cmdAddItem.TabIndex = 31;
            this.cmdAddItem.Text = "Add Item";
            this.cmdAddItem.UseVisualStyleBackColor = true;
            this.cmdAddItem.Click += new System.EventHandler(this.cmdAddItem_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalPrice.Location = new System.Drawing.Point(255, 235);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPrice.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPrice.TabIndex = 50;
            this.lblTotalPrice.Text = "0";
            // 
            // txtPeriod
            // 
            this.txtPeriod.AcceptsReturn = true;
            this.txtPeriod.BackColor = System.Drawing.SystemColors.Window;
            this.txtPeriod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeriod.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPeriod.Location = new System.Drawing.Point(390, 150);
            this.txtPeriod.MaxLength = 0;
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPeriod.Size = new System.Drawing.Size(37, 20);
            this.txtPeriod.TabIndex = 27;
            this.txtPeriod.Text = "1";
            this.txtPeriod.Visible = false;
            // 
            // txtGroupNote
            // 
            this.txtGroupNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupNote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupNote.Location = new System.Drawing.Point(90, 21);
            this.txtGroupNote.MaxLength = 0;
            this.txtGroupNote.Multiline = true;
            this.txtGroupNote.Name = "txtGroupNote";
            this.txtGroupNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupNote.Size = new System.Drawing.Size(337, 45);
            this.txtGroupNote.TabIndex = 19;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Window;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtItemName.Location = new System.Drawing.Point(90, 72);
            this.txtItemName.MaxLength = 0;
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtItemName.Size = new System.Drawing.Size(337, 74);
            this.txtItemName.TabIndex = 20;
            // 
            // txtMSRNo
            // 
            this.txtMSRNo.AcceptsReturn = true;
            this.txtMSRNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtMSRNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSRNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSRNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMSRNo.Location = new System.Drawing.Point(90, 153);
            this.txtMSRNo.MaxLength = 0;
            this.txtMSRNo.Name = "txtMSRNo";
            this.txtMSRNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMSRNo.Size = new System.Drawing.Size(80, 20);
            this.txtMSRNo.TabIndex = 23;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.BackColor = System.Drawing.SystemColors.Control;
            this.Label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label22.Location = new System.Drawing.Point(80, 240);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label22.Size = new System.Drawing.Size(0, 13);
            this.Label22.TabIndex = 48;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.Control;
            this.label30.Cursor = System.Windows.Forms.Cursors.Default;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label30.Location = new System.Drawing.Point(341, 155);
            this.label30.Name = "label30";
            this.label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label30.Size = new System.Drawing.Size(48, 13);
            this.label30.TabIndex = 45;
            this.label30.Text = "Duration";
            this.label30.Visible = false;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.BackColor = System.Drawing.SystemColors.Control;
            this.Label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label21.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label21.Location = new System.Drawing.Point(176, 235);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label21.Size = new System.Drawing.Size(58, 13);
            this.Label21.TabIndex = 47;
            this.Label21.Text = "Item Value";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.Control;
            this.label35.Cursor = System.Windows.Forms.Cursors.Default;
            this.label35.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label35.Location = new System.Drawing.Point(176, 212);
            this.label35.Name = "label35";
            this.label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label35.Size = new System.Drawing.Size(77, 13);
            this.label35.TabIndex = 43;
            this.label35.Text = "Discount Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(11, 212);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Discount";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.Control;
            this.label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(139, 212);
            this.label32.Name = "label32";
            this.label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label32.Size = new System.Drawing.Size(18, 13);
            this.label32.TabIndex = 45;
            this.label32.Text = "%";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(139, 235);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label24.Size = new System.Drawing.Size(18, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "%";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.SystemColors.Control;
            this.Label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label20.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label20.Location = new System.Drawing.Point(11, 235);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label20.Size = new System.Drawing.Size(49, 13);
            this.Label20.TabIndex = 45;
            this.Label20.Text = "W/H Tax";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.SystemColors.Control;
            this.label39.Cursor = System.Windows.Forms.Cursors.Default;
            this.label39.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label39.Location = new System.Drawing.Point(8, 25);
            this.label39.Name = "label39";
            this.label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label39.Size = new System.Drawing.Size(62, 13);
            this.label39.TabIndex = 41;
            this.label39.Text = "Group Note";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.SystemColors.Control;
            this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label19.Location = new System.Drawing.Point(176, 183);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(52, 13);
            this.Label19.TabIndex = 43;
            this.Label19.Text = "Unit Price";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.SystemColors.Control;
            this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label18.Location = new System.Drawing.Point(8, 76);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(58, 13);
            this.Label18.TabIndex = 41;
            this.Label18.Text = "Item Desc ";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.SystemColors.Control;
            this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label17.Location = new System.Drawing.Point(11, 157);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(48, 13);
            this.Label17.TabIndex = 40;
            this.Label17.Text = "MSR No.";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.SystemColors.Control;
            this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label16.Location = new System.Drawing.Point(176, 157);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label16.Size = new System.Drawing.Size(49, 13);
            this.Label16.TabIndex = 39;
            this.Label16.Text = "Quantity";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.SystemColors.Control;
            this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label15.Location = new System.Drawing.Point(11, 183);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(30, 13);
            this.Label15.TabIndex = 38;
            this.Label15.Text = "UOM";
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.Frame1);
            this.tbpMain.Location = new System.Drawing.Point(4, 22);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Size = new System.Drawing.Size(968, 502);
            this.tbpMain.TabIndex = 0;
            this.tbpMain.Text = "Purchase Order Main";
            this.tbpMain.UseVisualStyleBackColor = true;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.numPaymentTermsDays);
            this.Frame1.Controls.Add(this.cboChargeType);
            this.Frame1.Controls.Add(this.cboDeliveryPoint);
            this.Frame1.Controls.Add(this.txtVendorContactNo);
            this.Frame1.Controls.Add(this.txtdeliveryDate);
            this.Frame1.Controls.Add(this.txtContactPerson);
            this.Frame1.Controls.Add(this.txtProjectName);
            this.Frame1.Controls.Add(this.txtDeliveryPointAttnTo);
            this.Frame1.Controls.Add(this.txtAddress);
            this.Frame1.Controls.Add(this.label10);
            this.Frame1.Controls.Add(this.Label14);
            this.Frame1.Controls.Add(this.label27);
            this.Frame1.Controls.Add(this.label7);
            this.Frame1.Controls.Add(this.Label13);
            this.Frame1.Controls.Add(this.label6);
            this.Frame1.Controls.Add(this.label29);
            this.Frame1.Controls.Add(this.label5);
            this.Frame1.Controls.Add(this.Label8);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(5, 6);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(938, 447);
            this.Frame1.TabIndex = 35;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Purchase Order Info";
            // 
            // numPaymentTermsDays
            // 
            this.numPaymentTermsDays.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaymentTermsDays.Location = new System.Drawing.Point(266, 233);
            this.numPaymentTermsDays.Name = "numPaymentTermsDays";
            this.numPaymentTermsDays.Size = new System.Drawing.Size(45, 21);
            this.numPaymentTermsDays.TabIndex = 15;
            this.numPaymentTermsDays.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // cboChargeType
            // 
            this.cboChargeType.BackColor = System.Drawing.SystemColors.Window;
            this.cboChargeType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboChargeType.DataSource = this.tblChargetypeBindingSource;
            this.cboChargeType.DisplayMember = "ChargeType";
            this.cboChargeType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChargeType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboChargeType.Location = new System.Drawing.Point(121, 234);
            this.cboChargeType.Name = "cboChargeType";
            this.cboChargeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChargeType.Size = new System.Drawing.Size(49, 21);
            this.cboChargeType.TabIndex = 14;
            this.cboChargeType.ValueMember = "ChID";
            this.cboChargeType.Validated += new System.EventHandler(this.cboChargeType_Validated);
            // 
            // cboDeliveryPoint
            // 
            this.cboDeliveryPoint.BackColor = System.Drawing.SystemColors.Window;
            this.cboDeliveryPoint.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboDeliveryPoint.DataSource = this.deliveryPointsBindingSource;
            this.cboDeliveryPoint.DisplayMember = "DeliveryPointName";
            this.cboDeliveryPoint.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeliveryPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboDeliveryPoint.Location = new System.Drawing.Point(564, 166);
            this.cboDeliveryPoint.Name = "cboDeliveryPoint";
            this.cboDeliveryPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboDeliveryPoint.Size = new System.Drawing.Size(209, 21);
            this.cboDeliveryPoint.TabIndex = 17;
            this.cboDeliveryPoint.ValueMember = "DeliveryPointID";
            this.cboDeliveryPoint.Validated += new System.EventHandler(this.cboDeliveryPoint_Validated);
            // 
            // txtVendorContactNo
            // 
            this.txtVendorContactNo.AcceptsReturn = true;
            this.txtVendorContactNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtVendorContactNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorContactNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorContactNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVendorContactNo.Location = new System.Drawing.Point(119, 166);
            this.txtVendorContactNo.MaxLength = 0;
            this.txtVendorContactNo.Name = "txtVendorContactNo";
            this.txtVendorContactNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVendorContactNo.Size = new System.Drawing.Size(305, 20);
            this.txtVendorContactNo.TabIndex = 12;
            // 
            // txtdeliveryDate
            // 
            this.txtdeliveryDate.AcceptsReturn = true;
            this.txtdeliveryDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtdeliveryDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdeliveryDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeliveryDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdeliveryDate.Location = new System.Drawing.Point(564, 132);
            this.txtdeliveryDate.MaxLength = 0;
            this.txtdeliveryDate.Name = "txtdeliveryDate";
            this.txtdeliveryDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdeliveryDate.Size = new System.Drawing.Size(209, 20);
            this.txtdeliveryDate.TabIndex = 16;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.AcceptsReturn = true;
            this.txtContactPerson.BackColor = System.Drawing.SystemColors.Window;
            this.txtContactPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactPerson.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContactPerson.Location = new System.Drawing.Point(119, 132);
            this.txtContactPerson.MaxLength = 0;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactPerson.Size = new System.Drawing.Size(305, 20);
            this.txtContactPerson.TabIndex = 11;
            // 
            // txtProjectName
            // 
            this.txtProjectName.AcceptsReturn = true;
            this.txtProjectName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProjectName.Location = new System.Drawing.Point(119, 200);
            this.txtProjectName.MaxLength = 0;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProjectName.Size = new System.Drawing.Size(305, 20);
            this.txtProjectName.TabIndex = 13;
            // 
            // txtDeliveryPointAttnTo
            // 
            this.txtDeliveryPointAttnTo.AcceptsReturn = true;
            this.txtDeliveryPointAttnTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeliveryPointAttnTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryPointAttnTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryPointAttnTo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDeliveryPointAttnTo.Location = new System.Drawing.Point(564, 200);
            this.txtDeliveryPointAttnTo.MaxLength = 0;
            this.txtDeliveryPointAttnTo.Name = "txtDeliveryPointAttnTo";
            this.txtDeliveryPointAttnTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeliveryPointAttnTo.Size = new System.Drawing.Size(209, 20);
            this.txtDeliveryPointAttnTo.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(119, 36);
            this.txtAddress.MaxLength = 0;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(305, 81);
            this.txtAddress.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(445, 204);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Delivery Point Attn. To:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.SystemColors.Control;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(6, 238);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(69, 13);
            this.Label14.TabIndex = 31;
            this.Label14.Text = "Charge Type";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Control;
            this.label27.Cursor = System.Windows.Forms.Cursors.Default;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(4, 204);
            this.label27.Name = "label27";
            this.label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label27.Size = new System.Drawing.Size(109, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Project / Cost Center";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(445, 136);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Promised Delivery Date";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.SystemColors.Control;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(445, 170);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(59, 13);
            this.Label13.TabIndex = 29;
            this.Label13.Text = "Deliver To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(317, 237);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Days";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.Control;
            this.label29.Cursor = System.Windows.Forms.Cursors.Default;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(8, 170);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label29.Size = new System.Drawing.Size(65, 13);
            this.label29.TabIndex = 13;
            this.label29.Text = "Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(180, 237);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Payment Terms";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(8, 136);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(47, 13);
            this.Label8.TabIndex = 13;
            this.Label8.Text = "Attn. To";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(8, 70);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Address";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpMain);
            this.tabControl1.Controls.Add(this.tbpDetails);
            this.tabControl1.Controls.Add(this.tbpPreviewRaise);
            this.tabControl1.Location = new System.Drawing.Point(22, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 528);
            this.tabControl1.TabIndex = 33;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataSource = this.tblJobChargeBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "job_code";
            this.dataGridViewComboBoxColumn1.HeaderText = "JobCode";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ValueMember = "ChID";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataSource = this.tblExpenseCodeBindingSource;
            this.dataGridViewComboBoxColumn2.DisplayMember = "ExpenseCode";
            this.dataGridViewComboBoxColumn2.HeaderText = "Exp. Code";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ValueMember = "ExCodeID";
            this.dataGridViewComboBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Charge Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "%";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Job Code Desc.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Sub Job Desc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Exp. Code Desc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "MSR No";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn11.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn12.HeaderText = "W/H Tax";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 30;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn13.HeaderText = "Disc. %";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 30;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn14.HeaderText = "Disc. Value";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn15.HeaderText = "Dur.";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 30;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn16.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 120;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "PoDetail";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Group Note";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dsChargeCodes
            // 
            this.dsChargeCodes.DataSetName = "ChargeCodes";
            // 
            // tblAssetGroupTableAdapter
            // 
            this.tblAssetGroupTableAdapter.ClearBeforeFill = true;
            // 
            // btnImportfromExcel
            // 
            this.btnImportfromExcel.Location = new System.Drawing.Point(876, 107);
            this.btnImportfromExcel.Name = "btnImportfromExcel";
            this.btnImportfromExcel.Size = new System.Drawing.Size(75, 23);
            this.btnImportfromExcel.TabIndex = 57;
            this.btnImportfromExcel.Text = "Import";
            this.btnImportfromExcel.UseVisualStyleBackColor = true;
            this.btnImportfromExcel.Click += new System.EventHandler(this.btnImportfromExcel_Click);
            // 
            // FrmDEntry
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(1010, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDEntry";
            this.Text = "Purchase Order Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblChargetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobChargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningProvider)).EndInit();
            this.tbpPreviewRaise.ResumeLayout(false);
            this.tbpPreviewRaise.PerformLayout();
            this.tbpDetails.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeCodeDist)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssetGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItems)).EndInit();
            this.tbpMain.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentTermsDays)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsChargeCodes)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void FrmDEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.tblAssetGroup' table. You can move, or remove it, as needed.
            this.tblAssetGroupTableAdapter.Fill(this.pOCS.tblAssetGroup);
            // TODO: This line of code loads data into the 'pOCS.tblBuyer' table. You can move, or remove it, as needed.
            this.tblBuyerTableAdapter.Fill(this.pOCS.tblBuyer);
            // TODO: This line of code loads data into the 'pOCS.tblCurrency' table. You can move, or remove it, as needed.
            this.tblCurrencyTableAdapter.Fill(this.pOCS.tblCurrency);
            // TODO: This line of code loads data into the 'pOCS.tblExpenseCode' table. You can move, or remove it, as needed.
            this.tblExpenseCodeTableAdapter.Fill(this.pOCS.tblExpenseCode);
            // TODO: This line of code loads data into the 'pOCS.tblJobCharge' table. You can move, or remove it, as needed.
            this.tblJobChargeTableAdapter.Fill(this.pOCS.tblJobCharge);
            // TODO: This line of code loads data into the 'pOCS.tblOrderType' table. You can move, or remove it, as needed.
            this.tblOrderTypeTableAdapter.Fill(this.pOCS.tblOrderType);
            // TODO: This line of code loads data into the 'pOCS.tblChargetype' table. You can move, or remove it, as needed.
            this.tblChargetypeTableAdapter.Fill(this.pOCS.tblChargetype);
            // TODO: This line of code loads data into the 'pOCS.tblUOM' table. You can move, or remove it, as needed.
            this.tblUOMTableAdapter.Fill(this.pOCS.tblUOM);
            // TODO: This line of code loads data into the 'pOCS.DeliveryPoints' table. You can move, or remove it, as needed.
            this.deliveryPointsTableAdapter.Fill(this.pOCS.DeliveryPoints);
            // TODO: This line of code loads data into the 'pOS_DBDataSet.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.pOCS.Vendor);
            //if (txtPONumber.Text == "")
            //   fncGetOrderNumber();
            txtDiscountPercent.Text = "0";
            txtWHTaxPercent.Text = "0";
            txtDiscountValue.Text = "0";
            cboChargeType.Text = "";
            //if (!IsEditMode)
            fillCheckedList();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private void fillCheckedList()
        {
            Properties.Settings appSettings = new Properties.Settings();
            for (int i = 0; i < appSettings.ImportantInstructions.Count; i++)
            {
                clbStandardInsTemplate.Items.Add(appSettings.ImportantInstructions[i].ToString());
            }
        }
        void fncGetOrderNumber()
        {
            POCS.Ds.POCSTableAdapters.QueriesTableAdapter tAdapter = new POCS.Ds.POCSTableAdapters.QueriesTableAdapter();
            txtPONumber.Text = tAdapter.sqNextOrderNumber("PO").ToString();
        }

        private void cboVendorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //    POCS.Ds.POCSTableAdapters.VendorTableAdapter tAdapter = new POCS.Ds.POCSTableAdapters.VendorTableAdapter();
                txtAddress.Text = clsDataFunctions.FunGetAddressInfo(Convert.ToDecimal(cboVendorName.SelectedValue));
                txtContactPerson.Text = clsDataFunctions.FunGetConctPerson(Convert.ToDecimal(cboVendorName.SelectedValue));
                txtVendorContactNo.Text = clsDataFunctions.FunGetConctPersonTel(Convert.ToDecimal(cboVendorName.SelectedValue));
                numPaymentTermsDays.Value = Convert.ToInt16(clsDataFunctions.FunGetPaymentTerms(Convert.ToDecimal(cboVendorName.SelectedValue)));
            }
            catch
            {

            }
        }
        bool IsValidDiscount()
        {
            if (Convert.ToDecimal(txtDiscountPercent.Text) > 0)
            {
                if (Convert.ToDouble(txtDiscountPercent.Text) > 0 & Convert.ToDouble(txtDiscountValue.Text) == fncCalculateDiscountValue(Double.Parse(txtUnitPrice.Text), Double.Parse(txtQuantity.Text), Convert.ToDouble(txtPeriod.Text), Convert.ToDouble(txtDiscountPercent.Text)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
        private bool IsValidItemEntry()
        {
            bool bValidItemName = ValidateIsNotEmptyTextBox(txtItemName, "Enter Item Desc");
            bool bValidQuantity = ValidateIsNotEmptyTextBox(txtQuantity, "Enter Quantity");
            bool bValidUnitPrice = ValidateIsNotEmptyTextBox(txtUnitPrice, "Enter Unit Price");
            bool bValidChargeCode = ValidateIsNotEmptyTextBox(txtChargeCode, "Enter Charge Code");
            bool bValidMSRNo = ValidateIsNotEmptyTextBox(txtMSRNo, "Enter MSR No.");
            bool bValidDiscount = ValidateIsNotEmptyTextBox(txtDiscountPercent, "Enter Discount");
            bool bValidWithHolding = ValidateIsNotEmptyTextBox(txtWHTaxPercent, "Enter W/H Tax");
            bool bValidDuration = ValidateIsNotEmptyTextBox(txtPeriod, "Enter Duration");
            bool bValidHasAtleastOneRow = Convert.ToBoolean(dgvChargeCodeDist.RowCount > 0);
            if (bValidItemName && bValidQuantity && bValidUnitPrice && bValidChargeCode && bValidMSRNo && bValidDiscount && bValidWithHolding && bValidDuration && bValidHasAtleastOneRow)
                return true;
            else

                return false;
        }
        private void cmdAddItem_Click(object sender, EventArgs e)
        {
            if (IsValidItemEntry())
            {
                try
                {

                    lblTotalPrice.Text = Convert.ToString(Math.Round(fncCalTotalItemPrice(Double.Parse(txtUnitPrice.Text), Double.Parse(txtQuantity.Text), Double.Parse(txtWHTaxPercent.Text.ToString()), Double.Parse(txtDiscountPercent.Text.ToString()), Double.Parse(txtPeriod.Text)), 2));
                    string[] row1;
                    if (chkExpenseAsset.Checked)
                    {
                        row1 = new string[] { txtItemName.Text.TrimEnd(clsUtilies.charsToTrim), txtMSRNo.Text, txtChargeCode.Text, txtQuantity.Text, cboUOM.Text, txtUnitPrice.Text, txtDiscountPercent.Text.ToString(), txtDiscountPercent.Text.ToString(), txtDiscountValue.Text, txtPeriod.Text, lblTotalPrice.Text, "", txtGroupNote.Text.TrimEnd(clsUtilies.charsToTrim), GetChargeCodesArray(), cboAssetGroup.Text, txtEAJustification.Text.TrimEnd(clsUtilies.charsToTrim) };
                    }
                    else
                    {
                        row1 = new string[] { txtItemName.Text.TrimEnd(clsUtilies.charsToTrim), txtMSRNo.Text, txtChargeCode.Text, txtQuantity.Text, cboUOM.Text, txtUnitPrice.Text, txtDiscountPercent.Text.ToString(), txtDiscountPercent.Text.ToString(), txtDiscountValue.Text, txtPeriod.Text, lblTotalPrice.Text, "", txtGroupNote.Text.TrimEnd(clsUtilies.charsToTrim), GetChargeCodesArray() };
                    }
                    dgvPOItems.Rows.Add(row1);
                    lblPOValue.Text = lblPOValue.Text == "" ? "0" : lblPOValue.Text;
                    CalculatePOValue();
                    //lblPOValue.Text = Convert.ToString(Convert.ToDouble(lblPOValue.Text) + Convert.ToDouble(lblTotalPrice.Text));
                    dgvPOItems_SelectionChanged(null, null);
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Please check the Discount Value & Percentage!", Application.ProductName, MessageBoxButtons.OK);
            }

        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (IsValidItemEntry())
            {
                try
                {
                    lblTotalPrice.Text = Convert.ToString(Math.Round(fncCalTotalItemPrice(Double.Parse(txtUnitPrice.Text), Double.Parse(txtQuantity.Text), Double.Parse(txtWHTaxPercent.Text.ToString()), Double.Parse(txtDiscountValue.Text.ToString()), Double.Parse(txtPeriod.Text)), 2));
                    if (dgvPOItems.CurrentRow.Index > -1)
                    {
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[0].Value = txtItemName.Text.TrimEnd(clsUtilies.charsToTrim);
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[2].Value = txtChargeCode.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[1].Value = txtMSRNo.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[5].Value = txtUnitPrice.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[3].Value = txtQuantity.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[4].Value = cboUOM.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[7].Value = txtDiscountPercent.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[8].Value = txtDiscountValue.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[6].Value = txtWHTaxPercent.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[9].Value = txtPeriod.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[10].Value = lblTotalPrice.Text;
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[12].Value = txtGroupNote.Text.TrimEnd(clsUtilies.charsToTrim);
                        dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[13].Value = GetChargeCodesArray();
                        if (chkExpenseAsset.Checked)
                        {
                            dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[14].Value = cboAssetGroup.Text;
                            dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[15].Value = txtEAJustification.Text.TrimEnd(clsUtilies.charsToTrim);
                        }
                        else
                        {
                            dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[14].Value = "";
                            dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[15].Value = "";
                        }

                    }
                    CalculatePOValue();
                }
                catch { }
            }
        }
        string retstr;
        private string GetChargeCodesArray()
        {
            ChargeCode[] chCode = new ChargeCode[dgvChargeCodeDist.Rows.Count];
            foreach (DataGridViewRow ccRow in dgvChargeCodeDist.Rows)
            {

                chCode[ccRow.Index] = new ChargeCode(ccRow.Cells[0].Value.ToString(), ccRow.Cells[1].Value.ToString());
            }


            int arDim = 0;
            arDim = chCode.Length;
            retstr = "";
            //retstr = chCode.GetValue(arDim).ToString();
            for (int i = 0; i <= chCode.GetUpperBound(0); i++)
            {
                if (chCode.GetValue(i) != null)
                    retstr += chCode.GetValue(i).ToString() + " | ";
            }
            return retstr;

        }
        void RemoveChargeCodeRows()
        {
            foreach (DataGridViewRow dgvr in dgvChargeCodeDist.Rows)
            {
                dgvChargeCodeDist.Rows.Remove(dgvr);
            }
        }
        private string[] ReturnSplitChargeRows(string Charges)
        {
            char splitter = '|';
            string[] chrow = new string[ArrCount(Charges, splitter) - 1];
            chrow = Charges.Split(splitter);
            return chrow;
        }
        private string[] ReturnChargeCodeWithValue(string instccdatarow)
        {
            char ccsplit = ',';
            string[] ccdatarow = new string[2];
            ccdatarow = instccdatarow.Split(ccsplit);
            return ccdatarow;
        }
        void ReplaceChargeCodesGrid(string Charges)
        {
            try
            {
                dgvChargeCodeDist.Rows.Clear();
                RemoveChargeCodeRows();
                string[] chrow = ReturnSplitChargeRows(Charges);
                foreach (string instccdatarow in chrow)
                {
                    if (instccdatarow[0].ToString() != "")
                    {
                        string[] ccdatarow = ReturnChargeCodeWithValue(instccdatarow);
                        dgvChargeCodeDist.Rows.Add(ccdatarow[0].ToString(), ccdatarow[1].ToString());
                    }
                }
            }
            catch { }
        }
        public static int ArrCount(string src, char find)
        {
            int ret = 0;
            foreach (char s in src)
            {
                if (s == find)
                {
                    ++ret;
                }
            }
            return ret;
        }
        void CalculatePOValue()
        {
            try
            {
                decimal POVal = 0;
                foreach (DataGridViewRow dRow in dgvPOItems.Rows)
                {
                    POVal += Convert.ToDecimal(dgvPOItems.Rows[dRow.Index].Cells[10].Value);
                }
                lblPOValue.Text = Math.Round(POVal, 2).ToString();
            }
            catch { }
        }
        private static double fncCalTotalItemPrice(double UnitPrice, double Quantity, double withholding, double discount, double Period)
        {
            try
            {
                double TotalPrice, PostDiscountPrice;
                // TotalPrice = ((UnitPrice - (UnitPrice * discount / 100)) * Quantity) - (((UnitPrice - (UnitPrice * discount / 100)) * Quantity) * withholding / 100);
                PostDiscountPrice = (UnitPrice * Quantity * Period) - (discount);
                if (withholding > 0)
                    TotalPrice = PostDiscountPrice - (100 * 1 / withholding);
                else
                    TotalPrice = PostDiscountPrice;
                return (TotalPrice);
            }
            catch
            {
                return 0;
            }
        }
        private static double fncCalculateDiscountValue(double UnitPrice, double Quantity, double Period, double discount)
        {
            try
            {
                double DiscountValue;
                DiscountValue = (UnitPrice * Quantity * Period) * (discount / 100);
                return (DiscountValue);
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// If the user has selected a file, send it to the upload method, 
        /// the upload method will convert the file to a byte array and
        /// send it through the web service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (!IsEditMode)
            {
                if (IsEntryValid())
                {

                    try
                    {
                        PO_HeaderTableAdapter hAdpater = new PO_HeaderTableAdapter();
                        decimal NewID = Convert.ToDecimal(hAdpater.InsertOrder(cboVendorName.Text, txtAddress.Text, decimal.Parse(txtPONumber.Text), dtpPODate.Value, "-", "-", txtEndUser.Text, cboBuyer.Text, "-", "-", cmbCurrency.Text, 1, cboChargeType.Text, txtContactPerson.Text, txtVendorRef.Text, txtProjectName.Text, "-",
                            txtEndUser.Text, cboBuyer.Text, "PO", txtPODescription.Text, txtdeliveryDate.Text, txtImportantNotes.Text, cboDeliveryPoint.Text, txtVendorContactNo.Text, numPaymentTermsDays.Value.ToString(), txtDeliveryPointAttnTo.Text, DateTime.Now, ((FrmMain)this.ParentForm).ReturnUserName()));
                        InsertDetails(NewID);
                        MessageBox.Show("New Purchase Order Generated Successfully!", Application.ProductName, MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Please check the entries for missing or incorrect information", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //update Header
                PO_HeaderTableAdapter UpdateAdapter = new PO_HeaderTableAdapter();
                UpdateAdapter.UpdateOrder(cboVendorName.Text, decimal.Parse(txtPONumber.Text), txtAddress.Text, dtpPODate.Value, "-", "-", txtEndUser.Text, cboBuyer.Text, "-", "-", cmbCurrency.Text, 1, cboChargeType.Text, txtContactPerson.Text, txtVendorRef.Text, txtProjectName.Text, "-",
                            txtEndUser.Text, cboBuyer.Text, "PO", txtPODescription.Text, txtdeliveryDate.Text, txtImportantNotes.Text, cboDeliveryPoint.Text, txtVendorContactNo.Text, numPaymentTermsDays.Value.ToString(), txtDeliveryPointAttnTo.Text, DateTime.Now, ((FrmMain)this.ParentForm).ReturnUserName(), decPOID);
                PO_detailsTableAdapter UpdateDetailAdapter = new PO_detailsTableAdapter();
                //update Detail
                tblItemCostDistributionTableAdapter ItemCostAdapter = new tblItemCostDistributionTableAdapter();
                tblExpenseAssetTableAdapter ExpenseAssetAdapter = new tblExpenseAssetTableAdapter();
                ArrayList dgList = new ArrayList();
                decimal newAddDetID;
                foreach (DataGridViewRow uRow in dgvPOItems.Rows)
                {
                    if (uRow.Cells[11].Value.ToString() == "")
                    {
                        //Insert
                        newAddDetID = Convert.ToDecimal(UpdateDetailAdapter.InsertOrderItem(decPOID, uRow.Cells[0].Value.ToString(), Convert.ToDecimal(uRow.Cells[3].Value.ToString()), uRow.Cells[4].Value.ToString(), uRow.Cells[2].Value.ToString(), Convert.ToDecimal(uRow.Cells[5].Value.ToString()), Convert.ToDecimal(uRow.Cells[6].Value.ToString()), uRow.Cells[1].Value.ToString(), 1, Convert.ToDecimal(uRow.Cells[7].Value.ToString()), Convert.ToDecimal(uRow.Cells[8].Value.ToString()), uRow.Cells[12].Value.ToString()));
                        InsertItemCostDistribution(newAddDetID, uRow.Cells[13].Value.ToString());
                        if (uRow.Cells[14].Value != null)
                        {
                            InsertExpenseAssetRegistration(newAddDetID, uRow.Cells[14].Value.ToString(), uRow.Cells[15].Value.ToString());
                        }
                    }
                    else
                    {
                        dgList.Add(uRow.Cells[11].Value);
                    }

                }
                int location = -1;
                foreach (object DetID in strDetailIDs)
                {
                    location = dgList.IndexOf(DetID.ToString());
                    ItemCostAdapter.DeleteChargeCodeDistribution(Convert.ToDecimal(DetID));
                    ExpenseAssetAdapter.DeleteExpenseAssetByPODetailID(Convert.ToDecimal(DetID));
                    if (location > -1)
                    {
                        // Found! Update Now!
                        try
                        {
                            UpdateDetailAdapter.UpdateDetail(decPOID, dgvPOItems.Rows[location].Cells[0].Value.ToString(), Convert.ToDecimal(dgvPOItems.Rows[location].Cells[3].Value.ToString()), dgvPOItems.Rows[location].Cells[4].Value.ToString(), dgvPOItems.Rows[location].Cells[2].Value.ToString(), Convert.ToDecimal(dgvPOItems.Rows[location].Cells[5].Value.ToString()), Convert.ToDecimal(dgvPOItems.Rows[location].Cells[6].Value.ToString()), dgvPOItems.Rows[location].Cells[1].Value.ToString(), 1, Convert.ToDecimal(dgvPOItems.Rows[location].Cells[7].Value.ToString()), Convert.ToDecimal(dgvPOItems.Rows[location].Cells[8].Value.ToString()), dgvPOItems.Rows[location].Cells[12].Value.ToString(), Convert.ToDecimal(dgvPOItems.Rows[location].Cells[11].Value));
                            InsertItemCostDistribution(Convert.ToDecimal(DetID), dgvPOItems.Rows[location].Cells[13].Value.ToString());
                            ///Enter the New Item into ExpenseItem
                            if (dgvPOItems.Rows[location].Cells[14].Value != null)
                            {
                                InsertExpenseAssetRegistration(Convert.ToDecimal(DetID), dgvPOItems.Rows[location].Cells[14].Value.ToString(), dgvPOItems.Rows[location].Cells[15].Value.ToString());
                            }
                        }
                        catch { }
                    }
                    else
                    {
                        //Delete
                        UpdateDetailAdapter.DeleteItem(Convert.ToDecimal(DetID));

                    }
                }

                MessageBox.Show("Purchase Order Updated Successfully!", Application.ProductName, MessageBoxButtons.OK);
                // Refresh Parent Grid
                try
                {

                }
                catch
                {

                }
                this.Close();

            }

        }
        private void InsertItemCostDistribution(decimal PODetailID, string strChargeCodeDistribution)
        {
            tblItemCostDistributionTableAdapter iAdapter = new tblItemCostDistributionTableAdapter();
            string[] chrow = ReturnSplitChargeRows(strChargeCodeDistribution);
            foreach (string instccdatarow in chrow)
            {
                if (instccdatarow[0].ToString() != "")
                {
                    string[] ccdatarow = ReturnChargeCodeWithValue(instccdatarow);
                    if (ccdatarow[0].ToString().Trim() != "")
                        iAdapter.InsertItemDistribution(PODetailID, ccdatarow[0].ToString().Trim(), Convert.ToDecimal(ccdatarow[1].ToString()));

                }
            }

        }
        private void InsertExpenseAssetRegistration(decimal PODetailID, string strAssetGroup, string strJustification)
        {
            tblExpenseAssetTableAdapter eaAdapter = new tblExpenseAssetTableAdapter();
            eaAdapter.InsertEAItem(Common.intEARFNo(dtpPODate.Value, txtPONumber.Text), PODetailID, strAssetGroup, strJustification);

        }
        private void InsertDetails(decimal POID)
        {
            /// Enter the detail row
            PO_detailsTableAdapter dAdapter = new PO_detailsTableAdapter();

            decimal NewDetID;
            foreach (DataGridViewRow dgvR in dgvPOItems.Rows)
            {
                if (dgvR.Cells[0].Value != null)
                {
                    NewDetID = Convert.ToDecimal(dAdapter.InsertOrderItem(POID, dgvR.Cells[0].Value.ToString(), Convert.ToDecimal(dgvR.Cells[3].Value.ToString()), dgvR.Cells[4].Value.ToString(), dgvR.Cells[2].Value.ToString(), Convert.ToDecimal(dgvR.Cells[5].Value.ToString()), Convert.ToDecimal(dgvR.Cells[6].Value.ToString()), dgvR.Cells[1].Value.ToString(), 1, Convert.ToDecimal(dgvR.Cells[7].Value.ToString()), Convert.ToDecimal(dgvR.Cells[8].Value.ToString()), dgvR.Cells[12].Value.ToString()));
                    /// Enter the New Item into Chargecode
                    InsertItemCostDistribution(NewDetID, dgvR.Cells[13].Value.ToString());
                    ///Enter the New Item into ExpenseItem
                    if (dgvR.Cells[14].Value != null)
                    {
                        InsertExpenseAssetRegistration(NewDetID, dgvR.Cells[14].Value.ToString(), dgvR.Cells[15].Value.ToString());
                    }
                }
            }
        }

        public void AutoComplete(ComboBox cb, System.Windows.Forms.KeyPressEventArgs e, bool blnLimitToList)
        {
            string strFindStr = "";

            if (e.KeyChar == (char)8)
            {
                if (cb.SelectionStart <= 1)
                {
                    cb.Text = "";
                    return;
                }

                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text.Substring(0, cb.Text.Length - 1);
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1);
            }
            else
            {
                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text + e.KeyChar;
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart) + e.KeyChar;
            }

            int intIdx = -1;

            // Search the string in the ComboBox list.

            intIdx = cb.FindString(strFindStr);

            if (intIdx != -1)
            {
                cb.SelectedText = "";
                cb.SelectedIndex = intIdx;
                cb.SelectionStart = strFindStr.Length;
                cb.SelectionLength = cb.Text.Length;
                e.Handled = true;
            }
            else
            {
                e.Handled = blnLimitToList;
            }

        }

        private void cboVendorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoComplete(this.cboVendorName, e, false);
        }
        private void CheckNewRecordRequiredControls(Control ctl)
        {
            foreach (Control control in ctl.Controls)
            {
                //if the current control contains additional controls, run recursively
                if (control.Controls.Count > 0)
                { CheckNewRecordRequiredControls(control); }
                if ((control is TextBox && control.Text == "") || (control is ComboBox && (control as ComboBox).SelectedIndex == -1))
                {
                    //make sure we have databindings
                    if (control.DataBindings.Count == 0) { continue; }
                    //get bound field name
                    string boundField =
                      control.DataBindings[0].BindingMemberInfo.BindingField;
                    //get the bound table -- if we're bound to a dataview, 
                    //we need to get the table from that
                    // otherwise just get to the DataTable
                    string boundTable = string.Empty;
                    if (control.DataBindings[0].DataSource is DataView)
                    {
                        boundTable = (control.DataBindings[0].DataSource as DataView).Table.TableName;
                    }
                    else if (control.DataBindings[0].DataSource is DataTable)
                    {
                        boundTable = (control.DataBindings[0].DataSource as DataTable).TableName;
                    }
                    else
                    {
                        //not set up to handle bindings to anything 
                        //other than DataView or DataTable
                        continue;
                    }
                    //if (GetDataSet().Tables[boundTable].Columns[boundField].AllowDBNull == false)
                    //{
                    //   warningProvider.SetError(control, "Required Field");
                    //}
                }
            }
        }

        private bool IsEntryValid()
        {
            bool bValidPO_Number = ValidatePONumber();//
            bool IsValidNumber = NumberExists();
            bool bValidEndUser = ValidateIsNotEmptyTextBox(txtEndUser, "Enter End-User");
            //bool bValidBuyer = ValidateIsNotEmptyTextBox(txtBuyer, "Enter Buyer");
            bool bValidAddress = ValidateIsNotEmptyTextBox(txtAddress, "Enter Address");
            bool bValidAttn = ValidateIsNotEmptyTextBox(txtContactPerson, "Enter Vendor Contact Person");
            bool bValidDeliveryPointAttn = ValidateIsNotEmptyTextBox(txtDeliveryPointAttnTo, "Enter Delivery Point Attn. To");
            //bool bValidCurrency = CheckNewRecordRequiredControls(cmbCurrency);
            //CheckNewRecordRequiredControls(this);
            bool bValidHasAtleastOneRow = (Convert.ToInt16(dgvPOItems.RowCount) > 0);

            if (bValidPO_Number && IsValidNumber && bValidEndUser && bValidAddress && bValidAttn && bValidDeliveryPointAttn && bValidHasAtleastOneRow)
                return true;
            else
                return false;
        }
        private bool NumberExists()
        {
            bool bIsNewPO_Number = false;
            try
            {
                bIsNewPO_Number = clsDataFunctions.PONumberExists(Decimal.Parse(txtPONumber.Text), "", "PO");
                if (!bIsNewPO_Number)
                    MessageBox.Show("This Number is in use... Please Create the PO under different Number", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch
            {

            }
            return bIsNewPO_Number;
        }
        private bool ValidatePONumber()
        {
            if (ValidateIsNotEmptyTextBox(txtPONumber, "Enter Valid PO Number"))
                return true;

            try
            {
                int x = Int32.Parse(txtPONumber.Text);
                warningProvider.SetError(txtPONumber, "");
                return true;
            }
            catch (Exception e)
            {
                warningProvider.SetError(txtPONumber, "Not an Number.");
                Console.WriteLine(e);
                return false;
            }

        }

        private void cboJobCharge_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtChargeCode.Text = GetChargeCode(cboJobCharge.Text, cboExpenseCode.Text, cboChargeType.Text);
                lblJobnoDesc.Text = clsDataFunctions.FunGetjobnoDesc(Decimal.Parse(cboJobCharge.SelectedValue.ToString()));
                lblSubJobNoDesc.Text = clsDataFunctions.FunGetSubJobnoDesc(Decimal.Parse(cboJobCharge.SelectedValue.ToString()));
            }
            catch
            { }

        }

        private void cboExpenseCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtChargeCode.Text = GetChargeCode(cboJobCharge.Text, cboExpenseCode.Text, cboChargeType.Text);
                lblExpenseCodeDesc.Text = cboExpenseCode.SelectedValue.ToString();
            }
            catch
            {
            }

        }
        private static string GetChargeCode(string JobCharge, string ExpenseCode, string ChargeType)
        {
            return JobCharge + '-' + ExpenseCode + '-' + ChargeType;
        }

        private void cboJobCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoComplete(this.cboJobCharge, e, false);
        }

        private void cboExpenseCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoComplete(this.cboExpenseCode, e, false);
        }

        private void txtEndUser_Validating(object sender, CancelEventArgs e)
        {
            ValidateIsNotEmptyTextBox(txtEndUser, "Enter End User");
        }
        private bool ValidateIsNotEmptyTextBox(Control txtToValidate, string MessageToShow)
        {
            bool bStatus = true;
            if (txtToValidate.Text == "")
            {
                warningProvider.SetError(txtToValidate, MessageToShow);
                bStatus = false;
                txtToValidate.Focus();
                //set main form status
                ((FrmMain)this.ParentForm).WriteToStatusBar(MessageToShow);
            }
            else
                warningProvider.SetError(txtToValidate, "");
            return bStatus;
        }

        private void txtDiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(txtDiscountPercent.Text) < 0) || (Convert.ToInt16(txtDiscountPercent.Text) > 100))
            {
                MessageBox.Show("Invalid Percentage", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtDiscountValue.Text = String.Format("{0:N2}", fncCalculateDiscountValue(Double.Parse(txtUnitPrice.Text), Double.Parse(txtQuantity.Text), Convert.ToDouble(txtPeriod.Text), (Convert.ToDouble(txtDiscountPercent.Text))));
            }
        }
        private void txtDiscountPercent_TextChanged(object sender, System.EventArgs e)
        {
            if ((Convert.ToInt16(txtDiscountPercent.Text) < 0) || (Convert.ToInt16(txtDiscountPercent.Text) > 100))
            {
                MessageBox.Show("Invalid Percentage", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtDiscountValue.Text = String.Format("{0:N2}", fncCalculateDiscountValue(Double.Parse(txtUnitPrice.Text), Double.Parse(txtQuantity.Text), Convert.ToDouble(txtPeriod.Text), (Convert.ToDouble(txtDiscountPercent.Text))));
            }
        }

        private void txtPONumber_TextChanged(object sender, EventArgs e)
        {
            if (IsEditMode)
                fncGetOrderData();
        }
        void fncGetOrderData()
        {
            try
            {

                DataSet dsOrder = Common.dsOrderHeader(Decimal.Parse(txtPONumber.Text));

                foreach (DataRow row in dsOrder.Tables["po_header"].Rows)
                {
                    decPOID = Convert.ToDecimal(row["POID"]);
                    txtPODescription.Text = row["PO_description"].ToString();
                    dtpPODate.Text = row["PO_date"].ToString();
                    cboVendorName.Text = row["VendorName"].ToString();
                    txtAddress.Text = row["VendorAddress"].ToString();
                    txtEndUser.Text = row["EndUser"].ToString();
                    cboBuyer.Text = row["Buyer"].ToString();
                    cmbCurrency.Text = row["Currency"].ToString();
                    cboChargeType.Text = row["ChargeType"].ToString();
                    txtContactPerson.Text = row["CnctPerson"].ToString();
                    txtVendorRef.Text = row["VendorRef"].ToString();
                    txtProjectName.Text = row["Project"].ToString();
                    txtdeliveryDate.Text = row["DeliveryDate"].ToString();
                    txtImportantNotes.Text = row["ImpInstructions"].ToString();
                    cboDeliveryPoint.Text = row["DeliveryPoint"].ToString();
                    txtVendorContactNo.Text = row["CnCtTelephone"].ToString();
                    numPaymentTermsDays.Value = Convert.ToDecimal(row["PaymentTerms"]);
                    txtDeliveryPointAttnTo.Text = row["DeliveryPointAttn"].ToString();

                }
                dsDetails = Common.dsPODetails(Decimal.Parse(txtPONumber.Text));
                //dgvPOItems.Columns.Add("clmPODetID","PO_Detail");
                //dgvPOItems.Columns["clmPODetID"].Visible = false;

                foreach (DataRow drow in dsDetails.Tables["vPOdetailsCalculation"].Rows)
                {
                    string CharCodes = Common.arrItemChargeCodeDistribution(Convert.ToDecimal(drow["Po_DetailID"]));
                    CharCodes = CharCodes.Replace("Charge Code: ", "");
                    CharCodes = CharCodes.Replace("%\n", "|");
                    CharCodes = CharCodes.Replace(' ', ',');
                    CharCodes = CharCodes.Replace("|,", "|");

                    string[] row1 = new string[] { drow["ItemDescription"].ToString(), drow["MSRNo"].ToString(), drow["AccountCode"].ToString(), drow["Quantity"].ToString(), drow["UOM"].ToString(), String.Format("{0:N2}", drow["UnitPrice"]), String.Format("{0:N2}", drow["WithHolding"]), String.Format("{0:N2}", drow["Discount"]), String.Format("{0:N2}", drow["discountvalue"]), drow["Period"].ToString(), String.Format("{0:N2}", drow["NetValue"]), drow["PO_DetailID"].ToString(), drow["GroupNote"].ToString(), CharCodes.ToString(), drow["AssetGroup"].ToString(), drow["Justification"].ToString() };

                    dgvPOItems.Rows.Add(row1);
                    //myAL.Add(drow[""

                    strDetailIDs.Add(drow["Po_DetailID"]);

                }
                CalculatePOValue();
                btnSaveOrder.Text = "Save Changes";
                btnReset.Text = "Discard Changes";
            }
            catch { }
            finally
            {

            }
        }

        void VerifyComboSelection(ComboBox Ctrl, string strEntry)
        {
            try
            {

                int i = -1;
                i = Ctrl.FindStringExact(strEntry);
                if (i == -1)
                {
                    MessageBox.Show("Not a Valid Entry - Please choose an entry in the list.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Ctrl.Focus();
                }
            }
            catch { }
        }
        
        private void cboUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // VerifyComboSelection(cboUOM, cboUOM.Text);
        }

        private void cboVendorName_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cboVendorName, cboVendorName.Text);
        }

        private void cmbCurrency_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cmbCurrency, cmbCurrency.Text);
        }

        private void cboOrderType_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cboOrderType, cboOrderType.Text);
        }

        private void cboJobCharge_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cboJobCharge, cboJobCharge.Text);
        }

        private void cboExpenseCode_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cboExpenseCode, cboExpenseCode.Text);

        }

        private void cboUOM_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cboUOM, cboUOM.Text);
        }

        private void dgvPOItems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtItemName.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[0].Value.ToString();
                txtChargeCode.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[2].Value.ToString();
                txtMSRNo.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[1].Value.ToString();
                txtUnitPrice.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[5].Value.ToString();
                txtQuantity.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[3].Value.ToString();
                cboUOM.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[4].Value.ToString();
                txtDiscountPercent.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[7].Value.ToString();
                txtDiscountValue.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[8].Value.ToString();
                txtWHTaxPercent.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[6].Value.ToString();
                txtPeriod.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[9].Value.ToString();
                lblTotalPrice.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[10].Value.ToString();
                txtGroupNote.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[12].Value.ToString();
                ReplaceChargeCodesGrid(dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[13].Value.ToString());
                if (dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[14].Value.ToString() != "")
                {
                    chkExpenseAsset.Checked = true;
                    cboAssetGroup.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[14].Value.ToString();
                    txtEAJustification.Text = dgvPOItems.Rows[dgvPOItems.CurrentRow.Index].Cells[15].Value.ToString();
                }
                else
                {
                    chkExpenseAsset.Checked = false;
                }
            }
            catch { }
        }


        private void cboChargeType_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cboChargeType, cboChargeType.Text);
        }

        private void cboDeliveryPoint_Validated(object sender, EventArgs e)
        {
            VerifyComboSelection(cboDeliveryPoint, cboDeliveryPoint.Text);
        }

        private void txtWHTaxPercent_Validated(object sender, EventArgs e)
        {
            try
            {
                lblTotalPrice.Text = Convert.ToString(Math.Round(fncCalTotalItemPrice(Double.Parse(txtUnitPrice.Text), Double.Parse(txtQuantity.Text), Double.Parse(txtDiscountPercent.Text.ToString()), Double.Parse(txtDiscountPercent.Text.ToString()), Double.Parse(txtPeriod.Text)), 2));

            }
            catch { }
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            /*  form2 = new FrmQuickAddVendor();
              form2.BringToFront();  // if running this demo in debugger, form is 
              form2.Show(); //minimized at first so force form2 to open*/
            // Create an instance of the form that performs a lookup
            FrmQuickAddVendor form2 = new FrmQuickAddVendor();
            // Create an instance of the delegate
            form2.passControl = new FrmQuickAddVendor.PassControl(PassData);
            // Toon form
            form2.Show();
        }
        private void PassData(object sender)
        {
            // take the incoming string object
            this.vendorTableAdapter.Fill(this.pOCS.Vendor);
            cboVendorName.Refresh();
            cboVendorName.Text = ((TextBox)sender).Text;
        }

        public void VendorJustAdded(string VendorName, decimal VID)
        {
            try
            {

                cboVendorName.Text = VendorName;// and then store it internally
            }

            catch { }
        }

        private void txtDiscountPercent_Validated(object sender, EventArgs e)
        {
            try
            {
                txtDiscountValue.Text = Convert.ToString((Decimal.Parse(txtUnitPrice.Text) * Decimal.Parse(txtPeriod.Text) * Decimal.Parse(txtQuantity.Text)) * Decimal.Parse(txtDiscountPercent.Text) / 100);
            }
            catch { }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtChargeCode.Text = "";
            txtMSRNo.Text = "";
            txtUnitPrice.Text = "";
            txtQuantity.Text = "";
            txtDiscountPercent.Text = "";
            txtDiscountValue.Text = "";
            txtWHTaxPercent.Text = "";
            txtPeriod.Text = "";
            lblTotalPrice.Text = "";
            txtGroupNote.Text = "";

        }
        private decimal ReturnColumnPercentageValue()
        {
            decimal Percent = 0;
            try
            {
                foreach (DataGridViewRow dRow in dgvChargeCodeDist.Rows)
                {
                    if (dgvChargeCodeDist.Rows[dRow.Index].Cells[1].Value != null)
                        Percent += Convert.ToDecimal(dgvChargeCodeDist.Rows[dRow.Index].Cells[1].Value);
                }
            }
            catch { }
            return Percent;
        }

        void GetChargeCode()
        {
            try
            {
                string strJobCharge = cboJobCharge.Text.ToString();
                string strExpense = cboExpenseCode.Text.ToString();
                dgvChargeCodeDist.CurrentRow.Cells[0].Value = strJobCharge + "-" + strExpense + "-" + cboChargeType.Text;
                dgvChargeCodeDist.CurrentRow.Cells[1].Value = Convert.ToString(100 - ReturnColumnPercentageValue());
            }
            catch { }
        }
        bool ChargeCodeIsThere(string ChargeCode)
        {
            bool IsThere = false;
            foreach (DataGridViewRow drow in dgvChargeCodeDist.Rows)
            {
                if (dgvChargeCodeDist.Rows[drow.Index].Cells[0].Value.ToString() == ChargeCode)
                    IsThere = true;
            }
            return IsThere;

        }
        bool IsValidChargeCode()
        {
            bool bValidChargeCode = ValidateIsNotEmptyTextBox(txtChargeCode, "Enter Charge Code");
            bool bValidDistPercentage = ValidateIsNotEmptyTextBox(txtDistPercentage, "Enter Distribution Percentage");
            bool bValidPercentageRange = (Convert.ToDecimal(txtDistPercentage.Text) > 0);
            bool bValidTotalDistribution = (ReturnColumnPercentageValue() + Convert.ToDecimal(txtDistPercentage.Text) <= 100);
            return (bValidChargeCode && bValidDistPercentage && bValidPercentageRange && bValidTotalDistribution);
        }
        private void btnAddChargeCode_Click(object sender, EventArgs e)
        {
           if  (IsValidChargeCode() && !ChargeCodeIsThere(txtChargeCode.Text))
            {
                string[] strChargeCode = new string[] { txtChargeCode.Text, txtDistPercentage.Text };
                dgvChargeCodeDist.Rows.Add(strChargeCode);
            }
            else
            {
                MessageBox.Show("Please Check Charge Code Distribution Percentage", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void chkExpenseAsset_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clbStandardInsTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValues = "";
            for (int i = 0; i < clbStandardInsTemplate.CheckedItems.Count; i++)
            {
                SelectedValues += clbStandardInsTemplate.CheckedItems[i].ToString() + "\r\n";
            }
            txtImportantNotes.Text = SelectedValues;
        }

        private void btnImportfromExcel_Click(object sender, EventArgs e)
        {
            frmImportItems formImport = new frmImportItems();
            formImport.passControl = new frmImportItems.PassControl(PassDataSet);
            formImport.ShowDialog();
        }
        private void PassDataSet(object sender)
        {
            // take the incoming string object
            DataTable dt = ((DataTable)sender);
            foreach (DataRow dr in dt.Rows)
            {
                if(dr.Table.Columns[0].GetType() != null)
                dgvPOItems.Rows.Add(dr.ItemArray);
            }
            //dgvPOItems.DataSource = ((DataTable)sender);
        }



    }

}