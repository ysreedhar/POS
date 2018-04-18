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
    public partial class frmMaintainBuyers : KryptonForm
    {
        #region Constructors

        public frmMaintainBuyers()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<Buyer> buyerList = new BindingList<Buyer>(Buyer.GetEntityList());
            buyerBindingSource.DataSource = buyerList;
        }

        private void Save()
        {
            buyerBindingSource.EndEdit();
            Buyer buyer = buyerBindingSource.Current as Buyer;
            //BindingList<Buyer> OrderList = (BindingList<Buyer>)userBindingSource.DataSource;
            //Buyer Buyer = OrderList[userBindingSource.Position];

            Buyer.SaveEntity(buyer);

            BindingList<Buyer> orderList = new BindingList<Buyer>(Buyer.GetEntityList());
            buyerBindingSource.DataSource = orderList;

            MessageBox.Show("Buyer was saved.");
        }

        private void Delete()
        {
            Buyer buyer = buyerBindingSource.Current as Buyer;
            // (BindingList<Buyer>)userBindingSource.DataSource;
            //Buyer buyer = OrderList[userBindingSource.Position];

            decimal BuyerID = buyer.BuyerID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete Buyer # {0}?", BuyerID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                Buyer.DeleteEntity(buyer);
                buyerBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("Buyer # {0} was deleted.", BuyerID.ToString()));
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
            List<Buyer> orderList = new List<Buyer>(buyerBindingSource.DataSource as BindingList<Buyer>);
            BuyerFilter userFilter = new BuyerFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<Buyer> filterByOrderID = new Predicate<Buyer>(orderFilter.MatchesOrderID);
            Predicate<Buyer> filterByOrderID = new Predicate<Buyer>(userFilter.BeginsWithOrderID);
            Buyer buyer = orderList.Find(filterByOrderID);
            if (buyer == null)
                MessageBox.Show("No matching Buyer found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = buyerBindingSource.IndexOf(buyer);
                buyerBindingSource.Position = index;
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
            private int BuyerID = 0;

            public BuyerFilter(int BuyerID)
            {
                this.BuyerID = BuyerID;
            }
            public bool MatchesOrderID(Buyer buyer)
            {
                return buyer.BuyerID == BuyerID;
            }
            public bool BeginsWithOrderID(Buyer buyer)
            {
                return buyer.BuyerID.ToString().StartsWith(BuyerID.ToString());
            }
        }

        #endregion

    }
}          