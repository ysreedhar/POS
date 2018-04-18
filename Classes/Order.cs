using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class Order : INotifyPropertyChanged 
    {
        #region Properties

        private int _OrderID;
        public int OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                _OrderID = value;
            }
        }

        private string _CustomerID;
        public string CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (!value.Equals(_CustomerID))
                {
                    _CustomerID = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("CustomerID"));
                    }
                }
            }
        }
        
        private int _EmployeeID;
        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (!value.Equals(_EmployeeID))
                {
                    _EmployeeID = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("EmployeeID"));
                    }
                }
            }
        }

        private DateTime _OrderDate;
        public DateTime OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                if (!value.Equals(_OrderDate))
                {
                    _OrderDate = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("OrderDate"));
                    }
                }
            }
        }

        private string _ShipVia;
        public string ShipVia
        {
            get
            {
                return _ShipVia;
            }
            set
            {
                if (!value.Equals(_ShipVia))
                {
                    _ShipVia = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ShipVia"));
                    }
                }
            }
        }

        private string _ShipAddress;
        public string ShipAddress
        {
            get
            {
                return _ShipAddress;
            }
            set
            {
                if (!value.Equals(_ShipAddress))
                {
                    _ShipAddress = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ShipAddress"));
                    }
                }
            }
        }

        private string _ShipCity;
        public string ShipCity
        {
            get
            {
                return _ShipCity;
            }
            set
            {
                if (!value.Equals(_ShipCity))
                {
                    _ShipCity = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ShipCity"));
                    }
                }
            }
        }

        private string _ShipCountry;
        public string ShipCountry
        {
            get
            {
                return _ShipCountry;
            }
            set
            {
                if (!value.Equals(_ShipCountry))
                {
                    _ShipCountry = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ShipCountry"));
                    }
                }
            }
        }

        private string _ShipName;
        public string ShipName
        {
            get
            {
                return _ShipName;
            }
            set
            {
                if (!value.Equals(_ShipName))
                {
                    _ShipName = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ShipName"));
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

        public static List<Order> GetEntityList()
        {
            List<Order> orderList = new List<Order>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Order_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        Order order = FillOrder(rdr);
                        orderList.Add(order);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return orderList;
        }

        public static Order GetEntity(int orderID)
        {
            Order order = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Order_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        order = FillOrder(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return order;
        }

        public static Order SaveEntity(Order order)
        {
            if (order.OrderID > 0)
                return UpdateEntity(order);
            else
                return AddEntity(order);
        }

        public static void DeleteEntity(Order order)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Order_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orderID", order.OrderID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static Order UpdateEntity(Order order)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Order_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orderID", order.OrderID);
                    cmd.Parameters.AddWithValue("@customerID", order.CustomerID);
                    cmd.Parameters.AddWithValue("@employeeID", order.EmployeeID);
                    cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                    cmd.Parameters.AddWithValue("@shipVia", order.ShipVia);
                    cmd.Parameters.AddWithValue("@shipName", GetValue(order.ShipName));
                    cmd.Parameters.AddWithValue("@shipAddress", GetValue(order.ShipAddress));
                    cmd.Parameters.AddWithValue("@shipCity", GetValue(order.ShipCity));
                    cmd.Parameters.AddWithValue("@shipCountry", GetValue(order.ShipCountry));
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            order = GetEntity(order.OrderID);
            return order;
        }

        private static Order AddEntity(Order order)
        {
            int orderID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Order_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", order.CustomerID);
                    cmd.Parameters.AddWithValue("@employeeID", order.EmployeeID);
                    cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                    cmd.Parameters.AddWithValue("@shipVia", order.ShipVia);
                    cmd.Parameters.AddWithValue("@shipName", GetValue(order.ShipName));
                    cmd.Parameters.AddWithValue("@shipAddress", GetValue(order.ShipAddress));
                    cmd.Parameters.AddWithValue("@shipCity", GetValue(order.ShipCity));
                    cmd.Parameters.AddWithValue("@shipCountry", GetValue(order.ShipCountry));
                    cmd.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                    cmd.Parameters["@orderID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    orderID = Convert.ToInt32(cmd.Parameters["@orderID"].Value);
                }
                order = GetEntity(orderID);
            }
            return order;
        }

        private static Order FillOrder(SqlDataReader rdr)
        {
            Order order = new Order();
            order.OrderID = Convert.ToInt32(rdr["PO_OrderNo"]);
            order.CustomerID = rdr["VendorName"].ToString();
            //order.EmployeeID = rdr["OrderedBy"];
            order.OrderDate = Convert.ToDateTime(rdr["PO_date"]);
            //order.ShipVia = rdr["ShipVia"].ToString();
            //order.ShipName = rdr["ShipName"].ToString();
            //order.ShipAddress = rdr["ShipAddress"].ToString();
            //order.ShipCity = rdr["ShipCity"].ToString();
            //order.ShipCountry = rdr["ShipCountry"].ToString();
            return order;
        }

        private static object GetValue(object value)
        {
            if (value == null)
                return DBNull.Value;
            else
                return value;
        }

        #endregion

        #endregion
    }
}
