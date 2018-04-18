using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POCS.Forms
{
    public partial class frmUserRoles : Form
    {
        public frmUserRoles()
        {
            InitializeComponent();
        }

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            fillUsersList();
        }
        void fillUsersList()
        {
            BindingList<User> userList = new BindingList<User>(User.GetEntityList());
            clbUsers.DataSource = userList;
            clbUsers.DisplayMember = "UserName";
            clbUsers.ValueMember = "UserID";
            clbUsers.BindingContext = new BindingContext();
        }

        private void llselAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < clbRoles.Items.Count; i++)
            {
                clbRoles.SetItemChecked(i, true);
            }

        }

        private void llselNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < clbRoles.Items.Count; i++)
            {
                clbRoles.SetItemChecked(i, false);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            /* if (lbUsers.SelectedIndex > -1 && ddlWarehouse.SelectedIndex > -1)
             {
                 try
                 {
                     conn = new SqlConnection(ConnStr);
                     conn.Open();
                     foreach (ListItem i in chkLocation.Items)
                     {
                         if (i.Selected)
                         {
                             string SQL = "SELECT * FROM tblUserLocationAccess WHERE LocationsAccess = '" + i.Value + "' and UserName = '" + lbUsers.SelectedItem.Text + "' and Warehouse = '" + ddlWarehouse.SelectedItem.Text + "'";
                             SqlCommand CMD = new SqlCommand(SQL, conn);
                             SqlDataReader oRS;
                             oRS = CMD.ExecuteReader();
                             if (!(oRS.Read()))
                             {
                                 oRS.Close();
                                 string SQL2 = "INSERT INTO tblUserLocationAccess (UserName, WareHouse, LocationsAccess) VALUES ('" + lbUsers.SelectedItem.Text + "', '" + ddlWarehouse.SelectedItem.Text + "', '" + i.Value + "')";
                                 SqlCommand CMD2 = new SqlCommand(SQL2, conn);
                                 CMD2.ExecuteNonQuery();
                             }
                             else
                             {
                                 oRS.Close();
                             }
                         }
                         else
                         {
                             string SQL = "DELETE FROM tblUserLocationAccess WHERE LocationsAccess = '" + i.Value + "' and UserName = '" + lbUsers.SelectedItem.Text + "' and Warehouse = '" + ddlWarehouse.SelectedItem.Text + "'";
                             SqlCommand CMD = new SqlCommand(SQL, conn);
                             CMD.ExecuteNonQuery();
                         }
                     }
                 }

                 catch (SqlException ex)
                 {
                     Response.Write(ex);
                 }
                 catch (Exception ex)
                 {
                     Response.Write(ex);
                 }
                 finally
                 {
                     if (conn.State == ConnectionState.Open)
                     {
                         conn.Close();
                     }
                 }
             }
         }
     }*/
        }
    }
}