using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POCS.Forms
{
    public partial class frmUserGroups : Form
    {
        public frmUserGroups()
        {
            InitializeComponent();
        }

        private void frmCreateTrusting_Load(object sender, EventArgs e)
        {
            fillUsersList();
        }
        void fillUsersList()
        {
            BindingList<User> userList = new BindingList<User>(User.GetEntityList());
            clbUsers.DataSource = userList;
            clbUsers.DisplayMember = "UserName";
            clbUsers.ValueMember = "UserID";
            clbUsersGroup.DataSource = userList;
            clbUsersGroup.DisplayMember = "UserName";
            clbUsersGroup.ValueMember = "UserID";
            clbUsers.BindingContext = new BindingContext();
            clbUsersGroup.BindingContext = new BindingContext();
        }

        private string GetCheckedValues()
        {
            string SelectedValues = "";

            for (int i = 0; i < clbUsers.CheckedItems.Count; i++)
            {
                SelectedValues += clbUsers.CheckedItems[i].ToString() + ",";
            }
            SelectedValues = SelectedValues.Remove(SelectedValues.LastIndexOf(','), 1);
            return SelectedValues;
        }

        private void btnGrantPermissions_Click(object sender, EventArgs e)
        {
            if (clbUsers.CheckedItems.Count > 0)
            {
                GetCheckedValues();
                MessageBox.Show("Assigned Grouping for Selected users successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please Select atleast one user to assign Grouping!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}