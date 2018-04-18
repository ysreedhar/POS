using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace POCS
{
    public class MyIIdentity : System.Security.Principal.IIdentity
    {
        private string nameValue;
        private bool authenticatedValue;
        private Microsoft.VisualBasic.ApplicationServices.BuiltInRole roleValue;

        public string AuthenticationType
        {
            get
            {
                return "Custom Authentication";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return authenticatedValue;
            }
        }

        public string Name
        {
            get
            {
                return nameValue;
            }
        }

        public Microsoft.VisualBasic.ApplicationServices.BuiltInRole Role
        {
            get
            {
                return roleValue;
            }
        }

        public MyIIdentity(string name, string password)
        {
            if (IsValidNameAndPassword(name, password))
            {
                nameValue = name;
                authenticatedValue = true;
                roleValue = Microsoft.VisualBasic.ApplicationServices.BuiltInRole.Administrator;
            }
            else
            {
                nameValue = "";
                authenticatedValue = false;
                roleValue = Microsoft.VisualBasic.ApplicationServices.BuiltInRole.Guest;
            }
        }

        private bool IsValidNameAndPassword(string username, string password)
        {
            SqlConnection conn = new SqlConnection(POCS.Properties.Settings.Default.POS_DBConnectionString);
            try
            {
                conn.Open();
                string str = "Select Count(*) From tblusers Where UserID='" + username + "' And " + "Userpassword='" + password + "'";
                SqlCommand cmd = new SqlCommand(str, conn);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
    public class MyIPrincipal : System.Security.Principal.IPrincipal
    {
        private MyIIdentity identityValue;

        public System.Security.Principal.IIdentity Identity
        {
            get
            {
                return identityValue;
            }
        }

        public bool IsInRole(string role)
        {
            return role == identityValue.Role.ToString();
        }

        public MyIPrincipal(string name, string password)
        {
            identityValue = new MyIIdentity(name, password);
        }
    }
}

