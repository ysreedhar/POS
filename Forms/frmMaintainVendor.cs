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
    public partial class frmMaintainVendor : KryptonForm
    {
        #region Constructors

        public frmMaintainVendor()
        {
            InitializeComponent();
            SetupBindings();
            dtpSupplierSince.Value = DateTime.Now;
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<Vendors> vendorList = new BindingList<Vendors>(Vendors.GetEntityList());
            vendorBindingSource.DataSource = vendorList;
        }

        private void Save()
        {
            vendorBindingSource.EndEdit();
            Vendors vendor = vendorBindingSource.Current as Vendors;
            //BindingList<Vendors> OrderList = (BindingList<Vendors>)userBindingSource.DataSource;
            //Vendors Vendors = OrderList[userBindingSource.Position];

            Vendors.SaveEntity(vendor);

            BindingList<Vendors> vendorList = new BindingList<Vendors>(Vendors.GetEntityList());
            vendorBindingSource.DataSource = vendorList;

            MessageBox.Show("Vendor was saved.");
        }

        private void Delete()
        {
            Vendors vendor = vendorBindingSource.Current as Vendors;
            // (BindingList<Vendors>)userBindingSource.DataSource;
            //Vendors vendor = OrderList[userBindingSource.Position];

            decimal vendor_ID = vendor.vendor_ID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete Vendor # {0}?", vendor_ID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                Vendors.DeleteEntity(vendor);
                vendorBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("Vendor # {0} was deleted.", vendor_ID.ToString()));
            }
        }

        #endregion

        #region Form Events
        private bool ValidateIsNotEmptyTextBox(Control txtToValidate, string MessageToShow)
        {
            bool bStatus = true;
            if (txtToValidate.Text == "")
            {
                warningProvider.SetError(txtToValidate, MessageToShow);
                bStatus = false;
                txtToValidate.Focus();

            }
            else
                warningProvider.SetError(txtToValidate, "");
            return bStatus;
        }
        bool IsValidEntry()
        {
            bool bVendorName = ValidateIsNotEmptyTextBox(txtVendorName, "Enter Vendor Name");
            bool bVendorCode = ValidateIsNotEmptyTextBox(txtVendorCode, "Enter Vendor Code");
            bool bBizRegNo = ValidateIsNotEmptyTextBox(txtBizRegNo, "Enter Vendor Biz Registration No.");
            bool bAddress = ValidateIsNotEmptyTextBox(txtVendorAddress, "Enter Address");
            bool bPoscode = ValidateIsNotEmptyTextBox(txtPoscode, "Enter Address");
            bool bCity = ValidateIsNotEmptyTextBox(txtCity, "Enter City");
            bool bState = ValidateIsNotEmptyTextBox(txtState, "Enter State");
            bool bCountry = ValidateIsNotEmptyTextBox(txtCountry, "Enter Country");
            bool bTelephone = ValidateIsNotEmptyTextBox(txtPhone, "Enter Telephone No.");
            bool bFax = ValidateIsNotEmptyTextBox(txtFax, "Enter Fax No.");
            bool bContactPerson = ValidateIsNotEmptyTextBox(txtContactPerson, "Enter Contact Person");
            bool bHandphone = ValidateIsNotEmptyTextBox(txtMobile, "Enter Handphone No.");
            bool bEmail = ValidateIsNotEmptyTextBox(txtEmail, "Enter Email");
            bool bStatus = ValidateIsNotEmptyTextBox(txtStatus, "Enter Status");
            if (bVendorName && bVendorCode && bBizRegNo && bAddress && bPoscode && bCity && bState && bCountry && bTelephone && bFax && bContactPerson && bHandphone && bEmail && bStatus)
                return true;
            else
                return false;
        }
        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (IsValidEntry())
            {
                Save();
            }
            {
                MessageBox.Show("Please check the entries of validiity", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolBtnFindOrderNumber_Click(object sender, EventArgs e)
        {
            List<Vendors> vendorList = new List<Vendors>(vendorBindingSource.DataSource as BindingList<Vendors>);
            VendorFilter vendorFilter = new VendorFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<Vendors> filterByOrderID = new Predicate<Vendors>(orderFilter.MatchesOrderID);
            Predicate<Vendors> filterByOrderID = new Predicate<Vendors>(vendorFilter.BeginsWithOrderID);
            Vendors vendor = vendorList.Find(filterByOrderID);
            if (vendor == null)
                MessageBox.Show("No matching Vendor found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = vendorBindingSource.IndexOf(vendor);
                vendorBindingSource.Position = index;
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

        #region VendorFilter Class

        private class VendorFilter
        {
            private int vendor_ID = 0;

            public VendorFilter(int vendor_ID)
            {
                this.vendor_ID = vendor_ID;
            }
            public bool MatchesOrderID(Vendors vendor)
            {
                return vendor.vendor_ID == vendor_ID;
            }
            public bool BeginsWithOrderID(Vendors vendor)
            {
                return vendor.vendor_ID.ToString().StartsWith(vendor_ID.ToString());
            }
        }

        #endregion
    }
}          