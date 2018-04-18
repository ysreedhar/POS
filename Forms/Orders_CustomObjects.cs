using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS;

namespace POCS
{
    public partial class Orders_CustomObjects : Form
    {
        #region Constructors

        public Orders_CustomObjects()
        {
            InitializeComponent();
            SetupBindings();
        }

        #endregion

        #region Private Methods

        private void SetupBindings()
        {
            BindingList<Order> orderList = new BindingList<Order>(Order.GetEntityList());
            orderBindingSource.DataSource = orderList;

            BindingList<Customer> customerList = new BindingList<Customer>(Customer.GetEntityList());
            customerBindingSource.DataSource = customerList;

            BindingList<Employee> empList = new BindingList<Employee>(Employee.GetEntityList());
            employeeBindingSource.DataSource = empList;
        }

        private void Save()
        {
            orderBindingSource.EndEdit();
            Order order = orderBindingSource.Current as Order;
            //BindingList<Order> OrderList = (BindingList<Order>)orderBindingSource.DataSource;
            //Order Order = OrderList[orderBindingSource.Position];

            Order.SaveEntity(order);

            BindingList<Order> orderList = new BindingList<Order>(Order.GetEntityList());
            orderBindingSource.DataSource = orderList;

            MessageBox.Show("Order was saved.");
        }

        private void Delete()
        {
            Order order = orderBindingSource.Current as Order;
            // (BindingList<Order>)orderBindingSource.DataSource;
            //Order order = OrderList[orderBindingSource.Position];

            int orderID = order.OrderID;
            DialogResult dlg = MessageBox.Show(string.Format("Are you sure you want to delete Order # {0}?", orderID.ToString()));
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                Order.DeleteEntity(order);
                orderBindingSource.RemoveCurrent();
                MessageBox.Show(string.Format("Order # {0} was deleted.", orderID.ToString()));
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
            List<Order> orderList = new List<Order>(orderBindingSource.DataSource as BindingList<Order>);
            OrderFilter orderFilter = new OrderFilter(Convert.ToInt32(toolTxtFindOrderNumber.Text));
            //Predicate<Order> filterByOrderID = new Predicate<Order>(orderFilter.MatchesOrderID);
            Predicate<Order> filterByOrderID = new Predicate<Order>(orderFilter.BeginsWithOrderID);
            Order order = orderList.Find(filterByOrderID);
            if (order == null)
                MessageBox.Show("No matching Order found", "Not Found", MessageBoxButtons.OK);
            else
            {
                int index = orderBindingSource.IndexOf(order);
                orderBindingSource.Position = index;
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

        #region OrderFilter Class

        private class OrderFilter
        {
            private int orderID = 0;

            public OrderFilter(int orderID)
            {
                this.orderID = orderID;
            }
            public bool MatchesOrderID(Order order)
            {
                return order.OrderID == orderID;
            }
            public bool BeginsWithOrderID(Order order)
            {
                return order.OrderID.ToString().StartsWith(orderID.ToString());
            }
        }

        #endregion

        private void Orders_CustomObjects_Load(object sender, EventArgs e)
        {

        }
    }
}          