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
    public partial class frmMaintainUsers : KryptonForm
    {
        #region Constructors

        public frmMaintainUsers()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<User> userList = new BindingList<User>(User.GetEntityList());
            userBindingSource.DataSource = userList;
        }

        private void Save()
        {
            userBindingSource.EndEdit();
            User user = userBindingSource.Current as User;
            //BindingList<User> OrderList = (BindingList<User>)userBindingSource.DataSource;
            //User User = OrderList[userBindingSource.Position];

            User.SaveEntity(user);

            BindingList<User> orderList = new BindingList<User>(User.GetEntityList());
            userBindingSource.DataSource = orderList;

            MessageBox.Show("User was saved.");
        }

        private void Delete()
        {
            User user = userBindingSource.Current as User;
            // (BindingList<User>)userBindingSource.DataSource;
            //User user = OrderList[userBindingSource.Position];

            decimal usrID = user.UsrID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete User # {0}?", usrID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                User.DeleteEntity(user);
                userBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("User # {0} was deleted.", usrID.ToString()));
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
            List<User> orderList = new List<User>(userBindingSource.DataSource as BindingList<User>);
            UserFilter userFilter = new UserFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<User> filterByOrderID = new Predicate<User>(orderFilter.MatchesOrderID);
            Predicate<User> filterByOrderID = new Predicate<User>(userFilter.BeginsWithOrderID);
            User user = orderList.Find(filterByOrderID);
            if (user == null)
                MessageBox.Show("No matching User found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = userBindingSource.IndexOf(user);
                userBindingSource.Position = index;
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

        #region UserFilter Class

        private class UserFilter
        {
            private int usrID = 0;

            public UserFilter(int usrID)
            {
                this.usrID = usrID;
            }
            public bool MatchesOrderID(User user)
            {
                return user.UsrID == usrID;
            }
            public bool BeginsWithOrderID(User user)
            {
                return user.UsrID.ToString().StartsWith(usrID.ToString());
            }
        }

        #endregion

        private void Orders_CustomObjects_Load(object sender, EventArgs e)
        {

        }
    }
}          