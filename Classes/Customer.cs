using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    public class Customer : INotifyPropertyChanged 
    {
        #region Properties

        private string _CustomerID;
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        private string _CompanyName;
        public string CompanyName
        {
            get { return _CompanyName; }
            set
            {
                if (!value.Equals(_CompanyName))
                {
                    _CompanyName = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("CompanyName"));
                    }
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Static CRUD Methods

        #region Public Methods

        //public static BindingList<Customer> GetBindingList()
        //{
        //    BindingList<Customer> CustomerList = new BindingList<Customer>(GetEntityList());
        //    return CustomerList;
        //}

        public static List<Customer> GetEntityList()
        {
            List<Customer> customerList = new List<Customer>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string sql = "SELECT Vendor_ID, V_Name FROM Vendor";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        Customer customer = FillCustomer(rdr);
                        customerList.Add(customer);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return customerList;
        }

        #endregion

        #region Private Methods

        private static Customer FillCustomer(SqlDataReader rdr)
        {
            Customer customer = new Customer();
            customer.CustomerID = rdr["Vendor_ID"].ToString();
            customer.CompanyName = rdr["v_Name"].ToString();
            return customer;
        }

        #endregion

        #endregion
    }
}
