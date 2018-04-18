using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class User : INotifyPropertyChanged
    {
        #region Properties

        private decimal _UsrID;
        public decimal UsrID
        {
            get
            {
                return _UsrID;
            }
            set
            {
                _UsrID = value;
            }
        }

        private string _UserID;
        public string UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                if (!value.Equals(_UserID))
                {
                    _UserID = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("UserID"));
                    }
                }
            }
        }

        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                if (!value.Equals(_UserName))
                {
                    _UserName = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
                    }
                }
            }
        }

        private string _Department;
        public string Department
        {
            get
            {
                return _Department;
            }
            set
            {
                if (!value.Equals(_Department))
                {
                    _Department = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Department"));
                    }
                }
            }
        }

        private string _UserPassword;
        public string UserPassword
        {
            get
            {
                return _UserPassword;
            }
            set
            {
                if (!value.Equals(_UserPassword))
                {
                    _UserPassword = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("UserPassword"));
                    }
                }
            }
        }

        private string _UserType;
        public string UserType
        {
            get
            {
                return _UserType;
            }
            set
            {
                if (!value.Equals(_UserType))
                {
                    _UserType = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("UserType"));
                    }
                }
            }
        }

        private string _AccessRights;
        public string AccessRights
        {
            get
            {
                return _AccessRights;
            }
            set
            {
                if (!value.Equals(_AccessRights))
                {
                    _AccessRights = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("AccessRights"));
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

        public static List<User> GetEntityList()
        {
            List<User> userList = new List<User>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_User_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        User user = FillUser(rdr);
                        userList.Add(user);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return userList;
        }

        public static User GetEntity(decimal usrID)
        {
            User user = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_User_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsrID", usrID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        user = FillUser(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return user;
        }

        public static User SaveEntity(User user)
        {
            if (user.UsrID > 0)
                return UpdateEntity(user);
            else
                return AddEntity(user);
        }

        public static void DeleteEntity(User user)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_User_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsrID", user.UsrID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static User UpdateEntity(User user)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_User_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsrID", user.UsrID);
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);
                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@Department", user.Department);
                    cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                    cmd.Parameters.AddWithValue("@UserType", GetValue(user.UserType));
                    cmd.Parameters.AddWithValue("@AccessRights", GetValue(user.AccessRights));
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            user = GetEntity(user.UsrID);
            return user;
        }

        private static User AddEntity(User user)
        {
            int UsrID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_User_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);
                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@Department", user.Department);
                    cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                    cmd.Parameters.AddWithValue("@UserType", GetValue(user.UserType));
                    cmd.Parameters.AddWithValue("@AccessRights", GetValue(user.AccessRights));
                    cmd.Parameters.Add(new SqlParameter("@UsrID", SqlDbType.Int));
                    cmd.Parameters["@UsrID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    UsrID = Convert.ToInt32(cmd.Parameters["@UsrID"].Value);
                }
                user = GetEntity(UsrID);
            }
            return user;
        }

        private static User FillUser(SqlDataReader rdr)
        {
            User user = new User();
            user.UsrID = Convert.ToDecimal(rdr["UsrID"]);
            user.UserID = rdr["UserID"].ToString();
            user.UserName = rdr["UserName"].ToString();
            user.Department = rdr["Department"].ToString();
            user.UserPassword = rdr["UserPassword"].ToString();
            user.UserType = rdr["UserType"].ToString();
            user.AccessRights = rdr["AccessRights"].ToString();
            return user;
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
