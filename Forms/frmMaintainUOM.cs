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
    public partial class frmMaintainUOM : KryptonForm
    {
        #region Constructors

        public frmMaintainUOM()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<UOMs> uomList = new BindingList<UOMs>(UOMs.GetEntityList());
            uomBindingSource.DataSource = uomList;
        }

        private void Save()
        {
            uomBindingSource.EndEdit();
            UOMs uom = uomBindingSource.Current as UOMs;
            //BindingList<UOMs> OrderList = (BindingList<UOMs>)userBindingSource.DataSource;
            //UOMs UOMs = OrderList[userBindingSource.Position];

            UOMs.SaveEntity(uom);

            BindingList<UOMs> uomList = new BindingList<UOMs>(UOMs.GetEntityList());
            uomBindingSource.DataSource = uomList;

            MessageBox.Show("UOM was saved.");
        }

        private void Delete()
        {
            UOMs uom = uomBindingSource.Current as UOMs;
            // (BindingList<UOMs>)userBindingSource.DataSource;
            //UOMs uom = OrderList[userBindingSource.Position];

            decimal UOM_ID = uom.UOM_ID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete UOM # {0}?", UOM_ID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                UOMs.DeleteEntity(uom);
                uomBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("UOM # {0} was deleted.", UOM_ID.ToString()));
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
            List<UOMs> uomList = new List<UOMs>(uomBindingSource.DataSource as BindingList<UOMs>);
            UOMFilter uomFilter = new UOMFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<UOMs> filterByOrderID = new Predicate<UOMs>(orderFilter.MatchesOrderID);
            Predicate<UOMs> filterByOrderID = new Predicate<UOMs>(uomFilter.BeginsWithOrderID);
            UOMs uom = uomList.Find(filterByOrderID);
            if (uom == null)
                MessageBox.Show("No matching UOM found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = uomBindingSource.IndexOf(uom);
                uomBindingSource.Position = index;
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

        #region UOMFilter Class

        private class UOMFilter
        {
            private int UOM_ID = 0;

            public UOMFilter(int UOM_ID)
            {
                this.UOM_ID = UOM_ID;
            }
            public bool MatchesOrderID(UOMs uom)
            {
                return uom.UOM_ID == UOM_ID;
            }
            public bool BeginsWithOrderID(UOMs uom)
            {
                return uom.UOM_ID.ToString().StartsWith(UOM_ID.ToString());
            }
        }

        #endregion
    }
}          