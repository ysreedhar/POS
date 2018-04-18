using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class Buyer : INotifyPropertyChanged
    {
        #region Properties

        private decimal _BuyerID;
        public decimal BuyerID
        {
            get
            {
                return _BuyerID;
            }
            set
            {
                _BuyerID = value;
            }
        }
        private string _BuyerIntial;
        public string BuyerIntial
        {
            get
            {
                return _BuyerIntial;
            }
            set
            {
                if (!value.Equals(_BuyerIntial))
                {
                    _BuyerIntial = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BuyerIntial"));
                    }
                }
            }
        }

        private string _BuyerName;
        public string BuyerName
        {
            get
            {
                return _BuyerName;
            }
            set
            {
                if (!value.Equals(_BuyerName))
                {
                    _BuyerName = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BuyerName"));
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

        public static List<Buyer> GetEntityList()
        {
            List<Buyer> buyerList = new List<Buyer>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Buyer_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        Buyer buyer = FillBuyer(rdr);
                        buyerList.Add(buyer);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return buyerList;
        }

        public static Buyer GetEntity(decimal buyerID)
        {
            Buyer buyer = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Buyer_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyerID", buyerID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        buyer = FillBuyer(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return buyer;
        }

        public static Buyer SaveEntity(Buyer buyer)
        {
            if (buyer.BuyerID > 0)
                return UpdateEntity(buyer);
            else
                return AddEntity(buyer);
        }

        public static void DeleteEntity(Buyer buyer)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Buyer_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyerID", buyer.BuyerID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static Buyer UpdateEntity(Buyer buyer)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Buyer_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyerID", buyer.BuyerID);
                    cmd.Parameters.AddWithValue("@BuyerIntial", buyer.BuyerIntial);
                    cmd.Parameters.AddWithValue("@BuyerName", buyer.BuyerName);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            buyer = GetEntity(buyer.BuyerID);
            return buyer;
        }

        private static Buyer AddEntity(Buyer buyer)
        {
            int BuyerID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Buyer_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyerIntial", buyer.BuyerIntial);
                    cmd.Parameters.AddWithValue("@BuyerName", buyer.BuyerName);
                    cmd.Parameters.Add(new SqlParameter("@BuyerID", SqlDbType.Int));
                    cmd.Parameters["@BuyerID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    BuyerID = Convert.ToInt32(cmd.Parameters["@BuyerID"].Value);
                }
                buyer = GetEntity(BuyerID);
            }
            return buyer;
        }

        private static Buyer FillBuyer(SqlDataReader rdr)
        {
            Buyer buyer = new Buyer();
            buyer.BuyerID = Convert.ToDecimal(rdr["BuyerID"]);
            buyer.BuyerIntial = rdr["BuyerIntial"].ToString();
            buyer.BuyerName = rdr["BuyerName"].ToString();
            return buyer;
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
