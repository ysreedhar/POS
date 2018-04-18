using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class UOMs : INotifyPropertyChanged
    {
        #region Properties

        private decimal _UOM_ID;
        public decimal UOM_ID
        {
            get
            {
                return _UOM_ID;
            }
            set
            {
                _UOM_ID = value;
            }
        }
        private string _UOM;
        public string UOM
        {
            get
            {
                return _UOM;
            }
            set
            {
                if (!value.Equals(_UOM))
                {
                    _UOM = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("UOM"));
                    }
                }
            }
        }

        private string _UOM_Desc;
        public string UOM_Desc
        {
            get
            {
                return _UOM_Desc;
            }
            set
            {
                if (!value.Equals(_UOM_Desc))
                {
                    _UOM_Desc = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("UOM_Desc"));
                    }
                }
            }
        }

        private string _t_user;
        public string t_user
        {
            get
            {
                return clsGlobals.UserName.ToString(); // _t_user;
            }
            set
            {
                if (!value.Equals(_t_user))
                {
                    _t_user = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("t_user"));
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

        public static List<UOMs> GetEntityList()
        {
            List<UOMs> uomList = new List<UOMs>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_UOM_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        UOMs uom = FillUOM(rdr);
                        uomList.Add(uom);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return uomList;
        }

        public static UOMs GetEntity(decimal uomID)
        {
            UOMs uom = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_UOM_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UOM_ID", uomID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        uom = FillUOM(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return uom;
        }

        public static UOMs SaveEntity(UOMs uom)
        {
            if (uom.UOM_ID > 0)
                return UpdateEntity(uom);
            else
                return AddEntity(uom);
        }

        public static void DeleteEntity(UOMs uom)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_UOM_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UOM_ID", uom.UOM_ID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static UOMs UpdateEntity(UOMs uom)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_UOM_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UOM_ID", uom.UOM_ID);
                    cmd.Parameters.AddWithValue("@UOM", uom.UOM);
                    cmd.Parameters.AddWithValue("@UOM_Desc", uom.UOM_Desc);
                    cmd.Parameters.AddWithValue("@t_user", uom.t_user);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            uom = GetEntity(uom.UOM_ID);
            return uom;
        }

        private static UOMs AddEntity(UOMs uom)
        {
            int UOM_ID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_UOM_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UOM", uom.UOM);
                    cmd.Parameters.AddWithValue("@UOM_Desc", uom.UOM_Desc);
                    cmd.Parameters.AddWithValue("@t_user", uom.t_user);
                    cmd.Parameters.Add(new SqlParameter("@UOM_ID", SqlDbType.Int));
                    cmd.Parameters["@UOM_ID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    UOM_ID = Convert.ToInt32(cmd.Parameters["@UOM_ID"].Value);
                }
                uom = GetEntity(UOM_ID);
            }
            return uom;
        }

        private static UOMs FillUOM(SqlDataReader rdr)
        {
            UOMs uom = new UOMs();
            uom.UOM_ID = Convert.ToDecimal(rdr["UOM_ID"]);
            uom.UOM = rdr["UOM"].ToString();
            uom.UOM_Desc = rdr["UOM_Desc"].ToString();
            return uom;
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
