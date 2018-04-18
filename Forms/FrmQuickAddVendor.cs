using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS.Ds.POCSTableAdapters;

namespace POCS
{
    public partial class FrmQuickAddVendor : Form
    {
        public FrmQuickAddVendor()
        {
            InitializeComponent();
        }

        // Defines a delegate. Sender is the object that is being returned to the other form.
        public delegate void PassControl(object sender);

        // Declare a new instance of the delegate (null)
        public PassControl passControl;
        public TextBox getText()
        {
            return txtVendorName;
        }
        private void cmdAddVendor_Click(object sender, EventArgs e)
        {
            if (IsValidEntry())
            {
                try
                {
                    VendorTableAdapter qaAdapter = new VendorTableAdapter();
                    qaAdapter.Insert(txtVendorName.Text, txtContactPerson.Text, txtAddress.Text, txtTelephone.Text, txtHandphoneNo.Text, txtPostalCode.Text, txtFaxNo.Text, "", "", txtCity.Text, "", "", "", DateTime.Now,"", true,45);
                    MessageBox.Show("New Vendor Added Succesfully");
                    //callingForm = new FrmDEntry();
                    //callingForm.VendorJustAdded(txtVendorName.Text,1);
                    //this.Close();
                    //return;
                    if (passControl != null)
                    {
                        passControl(txtVendorName);
                    }

                    // Close form
                    this.Hide();   
                }
                catch { }
            }
        }
        bool IsValidEntry()
        {
            bool bVendorName = ValidateIsNotEmptyTextBox(txtVendorName, "Enter Vendor Name");
            bool bAddress = ValidateIsNotEmptyTextBox(txtAddress, "Enter Address");
            bool bCity = ValidateIsNotEmptyTextBox(txtCity, "Enter City");
            bool bPostalCode = ValidateIsNotEmptyTextBox(txtPostalCode, "Enter Postal Code");
            bool bTelephone = ValidateIsNotEmptyTextBox(txtTelephone, "Enter Telephone No.");
            bool bFax = ValidateIsNotEmptyTextBox(txtFaxNo, "Enter Fax No.");
            bool bContactPerson = ValidateIsNotEmptyTextBox(txtContactPerson, "Enter Contact Person");
            bool bHandphone = ValidateIsNotEmptyTextBox(txtHandphoneNo, "Enter Handphone No.");
            if (bVendorName && bAddress && bCity && bPostalCode && bTelephone && bFax && bContactPerson && bHandphone)
                return true;
            else
                return false;
        }
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
    }
}