using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class Vendors : INotifyPropertyChanged
    {
        #region Properties

        private decimal _vendor_ID;
        public decimal vendor_ID
        {
            get
            {
                return _vendor_ID;
            }
            set
            {
                _vendor_ID = value;
            }
        }
        private string _v_name;
        public string v_name
        {
            get
            {
                return _v_name;
            }
            set
            {
                if (!value.Equals(_v_name))
                {
                    _v_name = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_name"));
                    }
                }
            }
        }

        private string _v_contactperson;
        public string v_contactperson
        {
            get
            {
                return _v_contactperson;
            }
            set
            {
                if (!value.Equals(_v_contactperson))
                {
                    _v_contactperson = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_contactperson"));
                    }
                }
            }
        }

        private string _v_address;
        public string v_address
        {
            get
            {
                return _v_address;
            }
            set
            {
                if (!value.Equals(_v_address))
                {
                    _v_address = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_address"));
                    }
                }
            }
        }

        private string _v_phone;
        public string v_phone
        {
            get
            {
                return _v_phone;
            }
            set
            {
                if (!value.Equals(_v_phone))
                {
                    _v_phone = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_phone"));
                    }
                }
            }
        }

        private string _v_mobile;
        public string v_mobile
        {
            get
            {
                return _v_mobile;
            }
            set
            {
                if (!value.Equals(_v_mobile))
                {
                    _v_mobile = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_mobile"));
                    }
                }
            }
        }

        private string _v_zip;
        public string v_zip
        {
            get
            {
                return _v_zip;
            }
            set
            {
                if (!value.Equals(_v_zip))
                {
                    _v_zip = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_zip"));
                    }
                }
            }
        }

        private string _v_fax;
        public string v_fax
        {
            get
            {
                return _v_fax;
            }
            set
            {
                if (!value.Equals(_v_fax))
                {
                    _v_fax = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_fax"));
                    }
                }
            }
        }

        private string _v_email;
        public string v_email
        {
            get
            {
                return _v_email;
            }
            set
            {
                if (!value.Equals(_v_email))
                {
                    _v_email = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_email"));
                    }
                }
            }
        }

        private string _v_status;
        public string v_status
        {
            get
            {
                return _v_status;
            }
            set
            {
                if (!value.Equals(_v_status))
                {
                    _v_status = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_status"));
                    }
                }
            }
        }

        private string _v_city;
        public string v_city
        {
            get
            {
                return _v_city;
            }
            set
            {
                if (!value.Equals(_v_city))
                {
                    _v_city = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_city"));
                    }
                }
            }
        }

        private string _v_state;
        public string v_state
        {
            get
            {
                return _v_state;
            }
            set
            {
                if (!value.Equals(_v_state))
                {
                    _v_state = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_state"));
                    }
                }
            }
        }


        private string _v_country;
        public string v_country
        {
            get
            {
                return _v_country;
            }
            set
            {
                if (!value.Equals(_v_country))
                {
                    _v_country = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_country"));
                    }
                }
            }
        }

        private string _v_regno;
        public string v_regno
        {
            get
            {
                return _v_regno;
            }
            set
            {
                if (!value.Equals(_v_regno))
                {
                    _v_regno = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("v_regno"));
                    }
                }
            }
        }

        private DateTime _rEGdATE;
        public DateTime rEGdATE
        {
            get
            {
                return _rEGdATE;
            }
            set
            {
                if (!value.Equals(_rEGdATE))
                {
                    _rEGdATE = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("rEGdATE"));
                    }
                }
            }
        }

        private string _VendorCode;
        public string VendorCode
        {
            get
            {
                return _VendorCode;
            }
            set
            {
                if (!value.Equals(_VendorCode))
                {
                    _VendorCode = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("VendorCode"));
                    }
                }
            }
        }

        private bool _AVL;
        public bool AVL
        {
            get
            {
                return _AVL;
            }
            set
            {
                if (!value.Equals(_AVL))
                {
                    _AVL = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("AVL"));
                    }
                }
            }
        }

        private int _paymentTerms;
        public int paymentTerms
        {
            get
            {
                return _paymentTerms;
            }
            set
            {
                if (!value.Equals(_paymentTerms))
                {
                    _paymentTerms = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("paymentTerms"));
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

        public static List<Vendors> GetEntityList()
        {
            List<Vendors> vendorList = new List<Vendors>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Vendor_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        Vendors vendor = FillVendor(rdr);
                        vendorList.Add(vendor);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return vendorList;
        }

        public static Vendors GetEntity(decimal vendorID)
        {
            Vendors vendor = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Vendor_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vendor_ID", vendorID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        vendor = FillVendor(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return vendor;
        }

        public static Vendors SaveEntity(Vendors vendor)
        {
            if (vendor.vendor_ID > 0)
                return UpdateEntity(vendor);
            else
                return AddEntity(vendor);
        }

        public static void DeleteEntity(Vendors vendor)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Vendor_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vendor_ID", vendor.vendor_ID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static Vendors UpdateEntity(Vendors vendor)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Vendor_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vendor_ID", vendor.vendor_ID);
                    cmd.Parameters.AddWithValue("@v_name", vendor.v_name);
                    cmd.Parameters.AddWithValue("@v_contactperson", vendor.v_contactperson);
                    cmd.Parameters.AddWithValue("@v_address", vendor.v_address);
                    cmd.Parameters.AddWithValue("@v_phone", vendor.v_phone);
                    cmd.Parameters.AddWithValue("@v_mobile", vendor.v_mobile);
                    cmd.Parameters.AddWithValue("@v_zip", vendor.v_zip);
                    cmd.Parameters.AddWithValue("@v_fax", vendor.v_fax);
                    cmd.Parameters.AddWithValue("@v_email", vendor.v_email);
                    cmd.Parameters.AddWithValue("@v_status", vendor.v_status);
                    cmd.Parameters.AddWithValue("@v_city", vendor.v_city);
                    cmd.Parameters.AddWithValue("@v_state", vendor.v_state);
                    cmd.Parameters.AddWithValue("@v_country", vendor.v_country);
                    cmd.Parameters.AddWithValue("@v_regno", vendor.v_regno);
                    cmd.Parameters.AddWithValue("@rEGdATE", vendor.rEGdATE);
                    cmd.Parameters.AddWithValue("@VendorCode", vendor.VendorCode);
                    cmd.Parameters.AddWithValue("@AVL", vendor.AVL);
                    cmd.Parameters.AddWithValue("@paymentTerms", vendor.paymentTerms);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            vendor = GetEntity(vendor.vendor_ID);
            return vendor;
        }

        private static Vendors AddEntity(Vendors vendor)
        {
            int vendor_ID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_Vendor_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@v_name", vendor.v_name);
                    cmd.Parameters.AddWithValue("@v_contactperson", vendor.v_contactperson);
                    cmd.Parameters.AddWithValue("@v_address", vendor.v_address);
                    cmd.Parameters.AddWithValue("@v_phone", vendor.v_phone);
                    cmd.Parameters.AddWithValue("@v_mobile", vendor.v_mobile);
                    cmd.Parameters.AddWithValue("@v_zip", vendor.v_zip);
                    cmd.Parameters.AddWithValue("@v_fax", vendor.v_fax);
                    cmd.Parameters.AddWithValue("@v_email", vendor.v_email);
                    cmd.Parameters.AddWithValue("@v_status", vendor.v_status);
                    cmd.Parameters.AddWithValue("@v_city", vendor.v_city);
                    cmd.Parameters.AddWithValue("@v_state", vendor.v_state);
                    cmd.Parameters.AddWithValue("@v_country", vendor.v_country);
                    cmd.Parameters.AddWithValue("@v_regno", vendor.v_regno);
                    cmd.Parameters.AddWithValue("@rEGdATE", vendor.rEGdATE);
                    cmd.Parameters.AddWithValue("@VendorCode", vendor.VendorCode);
                    cmd.Parameters.AddWithValue("@AVL", vendor.AVL);
                    cmd.Parameters.AddWithValue("@paymentTerms", vendor.paymentTerms);
                    cmd.Parameters.Add(new SqlParameter("@vendor_ID", SqlDbType.Decimal));
                    cmd.Parameters["@vendor_ID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    vendor_ID = Convert.ToInt32(cmd.Parameters["@vendor_ID"].Value);
                }
                vendor = GetEntity(vendor_ID);
            }
            return vendor;
        }

        private static Vendors FillVendor(SqlDataReader rdr)
        {
            Vendors vendor = new Vendors();
            vendor.vendor_ID = Convert.ToDecimal(rdr["vendor_ID"]);
            vendor.v_name = rdr["v_name"].ToString();
            vendor.v_contactperson = rdr["v_contactperson"].ToString();
            vendor.v_address = rdr["v_address"].ToString();
            vendor.v_phone = rdr["v_phone"].ToString();
            vendor.v_mobile = rdr["v_mobile"].ToString();
            vendor.v_zip = rdr["v_zip"].ToString();
            vendor.v_fax = rdr["v_fax"].ToString();
            vendor.v_email = rdr["v_email"].ToString();
            vendor.v_status = rdr["v_status"].ToString();
            vendor.v_city = rdr["v_city"].ToString();
            vendor.v_state = rdr["v_state"].ToString();
            vendor.v_country = rdr["v_country"].ToString();
            vendor.VendorCode = rdr["VendorCode"].ToString();
            vendor.v_regno = rdr["v_regno"].ToString();
            vendor.rEGdATE = (rdr["rEGdATE"].ToString() != DBNull.Value.ToString() ? Convert.ToDateTime(rdr["rEGdATE"]):DateTime.Now) ;
            vendor.AVL = Convert.ToBoolean(rdr["AVL"]);
            vendor.paymentTerms = Convert.ToInt16(rdr["paymentTerms"]);

            return vendor;
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
