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
    public partial class frmMaintainExpenseCodes : KryptonForm
    {
        #region Constructors

        public frmMaintainExpenseCodes()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<ExpenseCode> buyerList = new BindingList<ExpenseCode>(ExpenseCode.GetEntityList());
            expensecodeBindingSource.DataSource = buyerList;
        }

        private void Save()
        {
            expensecodeBindingSource.EndEdit();
            ExpenseCode expensecode = expensecodeBindingSource.Current as ExpenseCode;
            //BindingList<ExpenseCode> OrderList = (BindingList<ExpenseCode>)userBindingSource.DataSource;
            //ExpenseCode ExpenseCode = OrderList[userBindingSource.Position];

            ExpenseCode.SaveEntity(expensecode);

            BindingList<ExpenseCode> orderList = new BindingList<ExpenseCode>(ExpenseCode.GetEntityList());
            expensecodeBindingSource.DataSource = orderList;

            MessageBox.Show("Expense Code was saved.");
        }

        private void Delete()
        {
            ExpenseCode expensecode = expensecodeBindingSource.Current as ExpenseCode;
            // (BindingList<ExpenseCode>)userBindingSource.DataSource;
            //ExpenseCode expensecode = OrderList[userBindingSource.Position];

            decimal ExCodeID = expensecode.ExCodeID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete Expense Code # {0}?", ExCodeID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                ExpenseCode.DeleteEntity(expensecode);
                expensecodeBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("Expense Code # {0} was deleted.", ExCodeID.ToString()));
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
            List<ExpenseCode> orderList = new List<ExpenseCode>(expensecodeBindingSource.DataSource as BindingList<ExpenseCode>);
            BuyerFilter userFilter = new BuyerFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<ExpenseCode> filterByOrderID = new Predicate<ExpenseCode>(orderFilter.MatchesOrderID);
            Predicate<ExpenseCode> filterByOrderID = new Predicate<ExpenseCode>(userFilter.BeginsWithOrderID);
            ExpenseCode expensecode = orderList.Find(filterByOrderID);
            if (expensecode == null)
                MessageBox.Show("No matching Expense Code found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = expensecodeBindingSource.IndexOf(expensecode);
                expensecodeBindingSource.Position = index;
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
            private int ExCodeID = 0;

            public BuyerFilter(int ExCodeID)
            {
                this.ExCodeID = ExCodeID;
            }
            public bool MatchesOrderID(ExpenseCode expensecode)
            {
                return expensecode.ExCodeID == ExCodeID;
            }
            public bool BeginsWithOrderID(ExpenseCode expensecode)
            {
                return expensecode.ExCodeID.ToString().StartsWith(ExCodeID.ToString());
            }
        }

        #endregion

    }
}          