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
    public partial class frmMaintainAssetGroups : KryptonForm
    {
        #region Constructors

        public frmMaintainAssetGroups()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<AssetGroups> buyerList = new BindingList<AssetGroups>(AssetGroups.GetEntityList());
            assetgroupBindingSource.DataSource = buyerList;
        }

        private void Save()
        {
            assetgroupBindingSource.EndEdit();
            AssetGroups assetgroup = assetgroupBindingSource.Current as AssetGroups;
            //BindingList<AssetGroup> OrderList = (BindingList<AssetGroup>)userBindingSource.DataSource;
            //AssetGroup AssetGroup = OrderList[userBindingSource.Position];

            AssetGroups.SaveEntity(assetgroup);

            BindingList<AssetGroups> orderList = new BindingList<AssetGroups>(AssetGroups.GetEntityList());
            assetgroupBindingSource.DataSource = orderList;

            MessageBox.Show("Asset Group was saved.");
        }

        private void Delete()
        {
            AssetGroups assetgroup = assetgroupBindingSource.Current as AssetGroups;
            // (BindingList<AssetGroup>)userBindingSource.DataSource;
            //AssetGroup assetgroup = OrderList[userBindingSource.Position];

            decimal AssetGroupID = assetgroup.AssetGroupID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete Asset Group # {0}?", AssetGroupID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                AssetGroups.DeleteEntity(assetgroup);
                assetgroupBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("AssetGroup # {0} was deleted.", AssetGroupID.ToString()));
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
            List<AssetGroups> orderList = new List<AssetGroups>(assetgroupBindingSource.DataSource as BindingList<AssetGroups>);
            AssetGroupFilter userFilter = new AssetGroupFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<AssetGroup> filterByOrderID = new Predicate<AssetGroup>(orderFilter.MatchesOrderID);
            Predicate<AssetGroups> filterByOrderID = new Predicate<AssetGroups>(userFilter.BeginsWithOrderID);
            AssetGroups assetgroup = orderList.Find(filterByOrderID);
            if (assetgroup == null)
                MessageBox.Show("No matching Asset Group found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = assetgroupBindingSource.IndexOf(assetgroup);
                assetgroupBindingSource.Position = index;
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

        #region AssetGroupFilter Class

        private class AssetGroupFilter
        {
            private int AssetGroupID = 0;

            public AssetGroupFilter(int AssetGroupID)
            {
                this.AssetGroupID = AssetGroupID;
            }
            public bool MatchesOrderID(AssetGroups assetgroup)
            {
                return assetgroup.AssetGroupID == AssetGroupID;
            }
            public bool BeginsWithOrderID(AssetGroups assetgroup)
            {
                return assetgroup.AssetGroupID.ToString().StartsWith(AssetGroupID.ToString());
            }
        }

        #endregion

    }
}          