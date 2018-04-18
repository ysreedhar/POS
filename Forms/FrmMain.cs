using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace POCS
{
    public partial class FrmMain : KryptonForm
    {
        private frmAbout frmAboutControl;
        private FrmViewOrder frmViewOrder;
        private FrmInvoiceEntry frmenterInvoice;
        private FrmInvoiceTransmittal frmInvoiceTransmittal;
        private FrmOrdersSummary frmOrdersSummary;
        private String UsersName;
        private String TimeLoggedIn;
        internal bool isLoggedIn;
        public FrmMain()
        {
            InitializeComponent();
            InitLogin();
            // ValueFromParent = initialValue;
        }
        private void InitLogin()
        {

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            UsersName = frm.UsernameTextBox.Text;
            clsGlobals.UserName = UsersName;
            TimeLoggedIn = System.DateTime.Now.ToString();
        }
        private void Logout()
        {
            //  If the user has any open documents warn them to close everything first.
            /*if (this.Controls.Count > 0)
            {
                MessageBox.Show("Please save your data and close any open documents before proceeding!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.UsersName = null;
                this.isLoggedIn = false;
                this.statusToolStripStatusLabel.Text = "You have been logged out...";
                
            }*/
        }
        private void vendorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            frmMaintainVendor frmDialog = new frmMaintainVendor();
            frmDialog.MdiParent = this;
            frmDialog.Show();
        }

        private void deliveryPointManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            frmMaintainDeliveryPoints frmDialog = new frmMaintainDeliveryPoints();
            frmDialog.MdiParent = this;
            frmDialog.Show();
        }
        private void CloseChildForms()
        {
            foreach (Form ctrl in this.MdiChildren)
            {
                if (ctrl.IsMdiChild == true) // typeof(MdiClient))
                {
                    ctrl.Close();
                    break;
                }
            }
        }
        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to end this session?", Application.ProductName,
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
            }
            else
            {

                Application.Exit();
            }

        }

        private void aboutPOCSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.frmAboutControl == null)
            {
                frmAbout frmAboutControl = new frmAbout();
                frmAboutControl.MdiParent = this;
                frmAboutControl.Show();
            }
        }

        private void purchaseOrderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDEntry frm = new FrmDEntry();
            frm.MdiParent = this;
            frm.Show();


        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Ask the user if he/she wishes to quit.
            if (MessageBox.Show("Are you sure you want to Quit?", "Quitting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //  hide the progressBar on the status strip.
                this.toolStripProgressBar1.Visible = false;

                //  set the default value, since we're not logged in.
                this.isLoggedIn = true;

                //Get User Rights
                string uRights = clsDataFunctions.GetUserRights(UsersName);
                administrationToolStripMenuItem.Visible = uRights.Substring(0, 1) == "1";// IndexOf(uRights, 1, 1);
                issueTransactionsToolStripMenuItem.Visible = uRights.Substring(1, 1) == "1";
                receiveTransactionsToolStripMenuItem.Visible = uRights.Substring(2, 1) == "1";
                clsGlobals.UserType = clsDataFunctions.GetUserType(this.UsersName);
                string userType = clsGlobals.UserType.ToString().ToLower();
                switch (userType)
                {
                    case "admin":
                        jobCodeMasterToolStripMenuItem.Enabled = true;
                        expenseCodeMasterToolStripMenuItem.Enabled = true;
                        userManagementToolStripMenuItem.Enabled = true;
                        break;
                    case "costing":
                        jobCodeMasterToolStripMenuItem.Enabled = true;
                        expenseCodeMasterToolStripMenuItem.Enabled = true;
                        break;
                     default:
                         break;

                }
                //  Alert the user that they have been logged in.
                String msg = String.Format("You have been logged in as \"{0}\"", this.UsersName);

                this.statusToolStripStatusLabel.Text = msg;
            }
            catch { }


        }

        public void WriteToStatusBar(string Text)
        {
            // Make this procedure public so that the child form(s) can call it
            statusToolStripStatusLabel.Text = Text;
        }
        public string ReturnUserName()
        {
            return UsersName;
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timeToolStripMenuItem.Text == "Time")
            {
                //  Create a message to inform the user upon request how long they've been on for.
                String msg = String.Format("The Time you have logged-in is {0}", TimeLoggedIn);
                this.statusToolStripStatusLabel.Text = msg;
                timeToolStripMenuItem.Text = "User";
            }
            else
            {
                String msg = String.Format("You have been logged in as \"{0}\"", this.UsersName);
                this.statusToolStripStatusLabel.Text = msg;
                timeToolStripMenuItem.Text = "Time";
            }
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void purChaseOrderListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmAboutControl == null)
            {
                FrmOrderSummary frmAboutControl = new FrmOrderSummary();
                frmAboutControl.MdiParent = this;
                frmAboutControl.Show();
            }

        }

        private void printPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmViewOrder == null)
            {
                FrmViewOrder frmDialog = new FrmViewOrder();
                frmDialog.MdiParent = this;
                frmDialog.Show();
            }
        }

        private void invoiceLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmenterInvoice == null)
            {
                FrmInvoiceEntry frmenterInvoice = new FrmInvoiceEntry();
                frmenterInvoice.MdiParent = this;
                frmenterInvoice.Show();

            }
        }

        private void transmittalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmInvoiceTransmittal == null)
            {
                frmTransmittalform frmInvoiceTransmittal = new frmTransmittalform();
                frmInvoiceTransmittal.MdiParent = this;
                frmInvoiceTransmittal.Show();
            }
        }

        private void ordersSummaryByValuePOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmOrdersSummary == null)
            {
                FrmOrdersSummary frmDialog = new FrmOrdersSummary();
                frmDialog.MdiParent = this;
                frmDialog.Show();
            }
        }

        private void purchaseOrderRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmOrdersSummary == null)
            {
                frmViewOrderSummary frmDialog = new frmViewOrderSummary();
                frmDialog.MdiParent = this;
                frmDialog.Show();
            }
        }


        private void printServiceOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmViewOrder == null)
            {
                /*FrmRptViewer frmDialog = new FrmRptViewer();
                frmDialog.MdiParent = this;
                frmDialog.Show();*/
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void buyerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainBuyers frmIns = new frmMaintainBuyers();
            frmIns.MdiParent = this;
            frmIns.Show();
        }

        private void newPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDEntry frm = new FrmDEntry();
            frm.MdiParent = this;
            frm.Show();

        }

        private void editPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderSummary frm = new FrmOrderSummary();
            frm.MdiParent = this;
            frm.Show();

        }

        private void pOListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderSummary frm = new FrmOrderSummary();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pOReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewOrder frm = new FrmViewOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void jobCodeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainJobCharge frm = new frmMaintainJobCharge();
            frm.MdiParent = this;
            frm.Show();
        }

        private void newServiceOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDEntry_SO frm = new FrmDEntry_SO();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderSummary_SO frm = new FrmOrderSummary_SO();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sOListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderSummary_SO frm = new FrmOrderSummary_SO();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sOReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewOrder_SO frm = new FrmViewOrder_SO();
            frm.MdiParent = this;
            frm.Show();
        }

        private void expenseCodeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainExpenseCodes frm = new frmMaintainExpenseCodes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mSRListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMSRReceipt frm = new FrmMSRReceipt();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mSRStatusUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateMsrStatus frm = new frmUpdateMsrStatus();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mSRListingByBuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportMSRbyBuyer frm = new frmReportMSRbyBuyer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mSRListingByRequestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportMSRbyRequestor frm = new frmReportMSRbyRequestor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void uOMMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainUOM frm = new frmMaintainUOM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewExpenseAssetRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewEARF frm = new frmViewEARF();
            frm.MdiParent = this;
            frm.Show();
        }

        private void assetGroupMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainAssetGroups frm = new frmMaintainAssetGroups();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void createTrustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserGroups frm = new frmUserGroups();
            frm.ShowDialog();
        }

        private void createUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmAboutControl == null)
            {
                frmMaintainUsers frmDialog = new frmMaintainUsers();
                frmDialog.MdiParent = this;
                frmDialog.Show();
            }
        }

        private void assignRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRoles frm = new frmUserRoles();
            frm.ShowDialog();
        }

        private void assignGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserGroups frm = new frmUserGroups();
            frm.ShowDialog();
        }

        private void mSRsByBuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportMSRbyBuyer frm = new frmReportMSRbyBuyer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mSRsByRequestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportMSRbyRequestor frm = new frmReportMSRbyRequestor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewPurchaseReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewRptChargeCodeDis frm = new frmViewRptChargeCodeDis();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}