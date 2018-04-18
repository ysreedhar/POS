using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class DeliveryPoint : INotifyPropertyChanged
    {
        #region Properties

        private decimal _DeliveryPointID;
        public decimal DeliveryPointID
        {
            get
            {
                return _DeliveryPointID;
            }
            set
            {
                _DeliveryPointID = value;
            }
        }
        private string _DeliveryPointName;
        public string DeliveryPointName
        {
            get
            {
                return _DeliveryPointName;
            }
            set
            {
                if (!value.Equals(_DeliveryPointName))
                {
                    _DeliveryPointName = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DeliveryPointName"));
                    }
                }
            }
        }

        private string _DeliveryPointAddress;
        public string DeliveryPointAddress
        {
            get
            {
                return _DeliveryPointAddress;
            }
            set
            {
                if (!value.Equals(_DeliveryPointAddress))
                {
                    _DeliveryPointAddress = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DeliveryPointAddress"));
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

        public static List<DeliveryPoint> GetEntityList()
        {
            List<DeliveryPoint> deliverypointList = new List<DeliveryPoint>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_DeliveryPoint_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        DeliveryPoint deliverypoint = FillUser(rdr);
                        deliverypointList.Add(deliverypoint);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return deliverypointList;
        }

        public static DeliveryPoint GetEntity(decimal usrID)
        {
            DeliveryPoint deliverypoint = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_DeliveryPoint_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DeliveryPointID", usrID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        deliverypoint = FillUser(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return deliverypoint;
        }

        public static DeliveryPoint SaveEntity(DeliveryPoint deliverypoint)
        {
            if (deliverypoint.DeliveryPointID > 0)
                return UpdateEntity(deliverypoint);
            else
                return AddEntity(deliverypoint);
        }

        public static void DeleteEntity(DeliveryPoint deliverypoint)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_DeliveryPoint_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DeliveryPointID", deliverypoint.DeliveryPointID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static DeliveryPoint UpdateEntity(DeliveryPoint deliverypoint)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_DeliveryPoint_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DeliveryPointID", deliverypoint.DeliveryPointID);
                    cmd.Parameters.AddWithValue("@DeliveryPointName", deliverypoint.DeliveryPointName);
                    cmd.Parameters.AddWithValue("@DeliveryPointAddress", deliverypoint.DeliveryPointAddress);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            deliverypoint = GetEntity(deliverypoint.DeliveryPointID);
            return deliverypoint;
        }

        private static DeliveryPoint AddEntity(DeliveryPoint deliverypoint)
        {
            int DeliveryPointID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_DeliveryPoint_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DeliveryPointName", deliverypoint.DeliveryPointName);
                    cmd.Parameters.AddWithValue("@DeliveryPointAddress", deliverypoint.DeliveryPointAddress);
                    cmd.Parameters.Add(new SqlParameter("@DeliveryPointID", SqlDbType.Int));
                    cmd.Parameters["@DeliveryPointID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    DeliveryPointID = Convert.ToInt32(cmd.Parameters["@DeliveryPointID"].Value);
                }
                deliverypoint = GetEntity(DeliveryPointID);
            }
            return deliverypoint;
        }

        private static DeliveryPoint FillUser(SqlDataReader rdr)
        {
            DeliveryPoint deliverypoint = new DeliveryPoint();
            deliverypoint.DeliveryPointID = Convert.ToDecimal(rdr["DeliveryPointID"]);
            deliverypoint.DeliveryPointName = rdr["DeliveryPointName"].ToString();
            deliverypoint.DeliveryPointAddress = rdr["DeliveryPointAddress"].ToString();
            return deliverypoint;
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
