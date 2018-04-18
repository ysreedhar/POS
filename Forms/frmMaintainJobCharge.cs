using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS;
using ComponentFactory.Krypton.Toolkit;
namespace POCS
{
    public partial class frmMaintainJobCharge : KryptonForm
    {
        #region Constructors

        public frmMaintainJobCharge()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<JobCharge> jobchargeList = new BindingList<JobCharge>(JobCharge.GetEntityList());
            jobchargeBindingSource.DataSource = jobchargeList;
        }

        private void Save()
        {
            jobchargeBindingSource.EndEdit();
            JobCharge jobcharge = jobchargeBindingSource.Current as JobCharge;
            //BindingList<JobCharge> OrderList = (BindingList<JobCharge>)userBindingSource.DataSource;
            //JobCharge JobCharge = OrderList[userBindingSource.Position];

            JobCharge.SaveEntity(jobcharge);

            BindingList<JobCharge> orderList = new BindingList<JobCharge>(JobCharge.GetEntityList());
            jobchargeBindingSource.DataSource = orderList;

            MessageBox.Show("JobCharge was saved.");
        }

        private void Delete()
        {
            JobCharge jobcharge = jobchargeBindingSource.Current as JobCharge;
            // (BindingList<JobCharge>)userBindingSource.DataSource;
            //JobCharge jobcharge = OrderList[userBindingSource.Position];

            decimal CHID = jobcharge.CHID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete JobCharge # {0}?", CHID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                JobCharge.DeleteEntity(jobcharge);
                jobchargeBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("JobCharge # {0} was deleted.", CHID.ToString()));
            }
        }

        #endregion

        #region Form Events

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolBtnFindOrderNumber_Click(object sender, EventArgs e)
        {
            List<JobCharge> orderList = new List<JobCharge>(jobchargeBindingSource.DataSource as BindingList<JobCharge>);
            BuyerFilter userFilter = new BuyerFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<JobCharge> filterByOrderID = new Predicate<JobCharge>(orderFilter.MatchesOrderID);
            Predicate<JobCharge> filterByOrderID = new Predicate<JobCharge>(userFilter.BeginsWithOrderID);
            JobCharge jobcharge = orderList.Find(filterByOrderID);
            if (jobcharge == null)
                MessageBox.Show("No matching JobCharge found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = jobchargeBindingSource.IndexOf(jobcharge);
                jobchargeBindingSource.Position = index;
            }
        }

        private void toolTxtFindOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Digits are OK & Backspace key is OK.
            // Otherwise, swallow the invalid key 
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == '\b')))
                e.Handled = true;
        }
        
        #endregion

        #region BuyerFilter Class

        private class BuyerFilter
        {
            private int CHID = 0;

            public BuyerFilter(int CHID)
            {
                this.CHID = CHID;
            }
            public bool MatchesOrderID(JobCharge jobcharge)
            {
                return jobcharge.CHID == CHID;
            }
            public bool BeginsWithOrderID(JobCharge jobcharge)
            {
                return jobcharge.CHID.ToString().StartsWith(CHID.ToString());
            }
        }

        #endregion

        void getChargeCode()
        {
            txtJobCharge.Text = txtJobNo.Text + "-" + txtSubJobNo.Text;
        }

        private void txtJobNo_Validated(object sender, EventArgs e)
        {
            getChargeCode();
        }

        private void txtSubJobNo_Validated(object sender, EventArgs e)
        {
            getChargeCode();
        }

        private void txtJobDesc_Validated(object sender, EventArgs e)
        {
            getChargeCode();
        }

        private void txtSubJobDesc_Validated(object sender, EventArgs e)
        {
            getChargeCode();
        }

    }
}          