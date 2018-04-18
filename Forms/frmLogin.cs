using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace POCS
{
    public partial class frmLogin : KryptonForm
    {

        public frmLogin()
        {
            InitializeComponent();

        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                MyIPrincipal samplePrincipal = new MyIPrincipal(this.UsernameTextBox.Text, this.PasswordTextBox.Text);
                this.PasswordTextBox.Text = "";
                if ((!(samplePrincipal.Identity.IsAuthenticated)))
                {
                    MessageBox.Show("The username and password pair is incorrect");
                    return;
                }
                else
                {
                    //User.CurrentPrincipal = samplePrincipal;
                    //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    /*  FrmMain.vendorManagementToolStripMenuItem..mnuAdministration.Visible = Mid(rs1("accessrights"), 1, 1) == "1";
                      FrmMain.mnuTransactions.Visible = Mid(rs1("accessrights"), 2, 1) == "1";
                      FrmMain.mnuInvoiceTransactions.Visible = Mid(rs1("accessrights"), 3, 1) == "1";
                      varAccessStr = "logged In";*/
                    // ValueFromParent; //= this.UsernameTextBox.ToString().ToUpper();
                    
                    this.Close(); 
                   
                }
            }
            catch
            {
                MessageBox.Show("Please check the Database Server Connection", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close(); 
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}