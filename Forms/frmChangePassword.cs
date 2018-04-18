using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using POCS.Ds.POCSTableAdapters;
namespace POCS.Forms
{
    public partial class frmChangePassword : KryptonForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
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
        bool IsValidEntry()
        {
            bool bCurrentPassword = ValidateIsNotEmptyTextBox(txtCurrentPassword, "Enter Current Password");
            bool bNewPassword = ValidateIsNotEmptyTextBox(txtNewPassword, "Enter New Password");
            bool bConfirmPassword = ValidateIsNotEmptyTextBox(txtConfirmPassword, "Enter Confirm Password");
            if (bCurrentPassword && bNewPassword && bConfirmPassword && IsValidNewPassword())
                 return true;
             else
                 return false;
        }
        bool IsValidNewPassword()
        {
            bool NewPassword = true;
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The New Password and Confirmation Passwords don't match!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NewPassword = false;
            }
            return NewPassword;
        }
         private void btnChange_Click(object sender, EventArgs e)
        {
            if (IsValidEntry())
            {
                if (clsDataFunctions.FunGetUserValidPassword(clsGlobals.UserName,txtCurrentPassword.Text.Trim()))
                {
                    tblusersTableAdapter PasswordAdapter = new tblusersTableAdapter();
                    PasswordAdapter.UpdateUserPassword(txtNewPassword.Text.Trim(), clsGlobals.UserName);
                    MessageBox.Show("Your Password has been changed successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your Current Password doesn't match! Please contact the Administrator", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
    }
}