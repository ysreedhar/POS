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
    public partial class FrmUserMgmt : Form
    {
        public FrmUserMgmt()
        {
            InitializeComponent();
        }
        public bool IsEditMode;
        public decimal UserEditID;
        string strAccessRights;
        private void FrmUserMgmt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.tblusers' table. You can move, or remove it, as needed.
            this.tblusersTableAdapter.Fill(this.pOCS.tblusers);

        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUserId.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUserName.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDepartment.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboType.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                //cblAccessRights.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                string aRights = dgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
                for (int i = 0; i < cblAccessRights.Items.Count; i++)
                {
                    cblAccessRights.SetItemCheckState(i,CheckState.Unchecked);
                    //int IndexSel = ;
                    if(aRights.Substring(i, 1).ToString() == "1")
                    cblAccessRights.SetItemCheckState(i,CheckState.Checked);
                }
                btnSave.Text = "Save Changes";
                btnReset.Text = "Discard Changes";
                IsEditMode = true;
                UserEditID = Convert.ToDecimal(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
            }
            catch
            { }
        }
        bool IsValidEntry()
        { return true; }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
            {

                for (int i = 0; i < cblAccessRights.Items.Count; i++)
                {
                    if (cblAccessRights.GetItemCheckState(i) == CheckState.Checked)
                    {
                        strAccessRights += "1";
                    }
                    else
                    {
                        strAccessRights += "0";
                    }
                }
                tblusersTableAdapter tAdapter = new tblusersTableAdapter();
                if (!IsEditMode)
                {
                    
                    if (IsValidEntry())
                    {

                        tAdapter.InsertUser(txtUserId.Text,txtUserName.Text,txtDepartment.Text,txtPassword.Text,"Yes",strAccessRights);
                        MessageBox.Show("New User Added Sucessfully", Application.ProductName);
                        tblusersBindingSource1.ResetBindings(true);
                        dgvUsers.Refresh();
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Enter all Required User Info", Application.ProductName);
                    }
                }
                else
                {
                    tAdapter.UpdateUser(txtUserId.Text, txtUserName.Text, txtDepartment.Text, txtPassword.Text, "Yes", strAccessRights, UserEditID);
                    tblusersTableAdapter.Update(this.pOCS.tblusers);
                    dgvUsers.Refresh();
                    MessageBox.Show("User Information Updated Succesfully", Application.ProductName, MessageBoxButtons.OK);
                }
            }
            catch { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
            txtUserName.Text = "";
            txtDepartment.Text = "";
            txtPassword.Text = "";
            for (int i = 0; i < cblAccessRights.Items.Count; i++)
            {
                cblAccessRights.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}