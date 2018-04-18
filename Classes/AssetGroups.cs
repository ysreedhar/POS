using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class AssetGroups : INotifyPropertyChanged
    {
        #region Properties

        private decimal _AssetGroupID;
        public decimal AssetGroupID
        {
            get
            {
                return _AssetGroupID;
            }
            set
            {
                _AssetGroupID = value;
            }
        }
        private string _AssetGroup;
        public string AssetGroup
        {
            get
            {
                return _AssetGroup;
            }
            set
            {
                if (!value.Equals(_AssetGroup))
                {
                    _AssetGroup = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("AssetGroup"));
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

        public static List<AssetGroups> GetEntityList()
        {
            List<AssetGroups> assetgroupList = new List<AssetGroups>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_AssetGroup_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        AssetGroups assetgroup = FillBuyer(rdr);
                        assetgroupList.Add(assetgroup);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return assetgroupList;
        }

        public static AssetGroups GetEntity(decimal AssetGroupID)
        {
            AssetGroups assetgroup = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_AssetGroup_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AssetGroupID", AssetGroupID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        assetgroup = FillBuyer(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return assetgroup;
        }

        public static AssetGroups SaveEntity(AssetGroups assetgroup)
        {
            if (assetgroup.AssetGroupID > 0)
                return UpdateEntity(assetgroup);
            else
                return AddEntity(assetgroup);
        }

        public static void DeleteEntity(AssetGroups assetgroup)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_AssetGroup_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AssetGroupID", assetgroup.AssetGroupID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static AssetGroups UpdateEntity(AssetGroups assetgroup)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_AssetGroup_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AssetGroupID", assetgroup.AssetGroupID);
                    cmd.Parameters.AddWithValue("@AssetGroup", assetgroup.AssetGroup);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            assetgroup = GetEntity(assetgroup.AssetGroupID);
            return assetgroup;
        }

        private static AssetGroups AddEntity(AssetGroups assetgroup)
        {
            int AssetGroupID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_AssetGroup_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AssetGroup", assetgroup.AssetGroup);
                    cmd.Parameters.Add(new SqlParameter("@AssetGroupID", SqlDbType.Int));
                    cmd.Parameters["@AssetGroupID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    AssetGroupID = Convert.ToInt32(cmd.Parameters["@AssetGroupID"].Value);
                }
                assetgroup = GetEntity(AssetGroupID);
            }
            return assetgroup;
        }

        private static AssetGroups FillBuyer(SqlDataReader rdr)
        {
            AssetGroups assetgroup = new AssetGroups();
            assetgroup.AssetGroupID = Convert.ToDecimal(rdr["AssetGroupID"]);
            assetgroup.AssetGroup = rdr["AssetGroup"].ToString();
            return assetgroup;
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
