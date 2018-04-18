using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class JobCharge : INotifyPropertyChanged
    {
        #region Properties

        private decimal _CHID;
        public decimal CHID
        {
            get
            {
                return _CHID;
            }
            set
            {
                _CHID = value;
            }
        }
        private string _Job_Code;
        public string Job_Code
        {
            get
            {
                return _Job_Code;
            }
            set
            {
                if (!value.Equals(_Job_Code))
                {
                    _Job_Code = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Job_Code"));
                    }
                }
            }
        }

        private string _Jobno;
        public string Jobno
        {
            get
            {
                return _Jobno;
            }
            set
            {
                if (!value.Equals(_Jobno))
                {
                    _Jobno = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Jobno"));
                    }
                }
            }
        }
        private string _Subjobno;
        public string Subjobno
        {
            get
            {
                return _Subjobno;
            }
            set
            {
                if (!value.Equals(_Subjobno))
                {
                    _Subjobno = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Subjobno"));
                    }
                }
            }
        }
        private string _Jobno_desc;
        public string Jobno_desc
        {
            get
            {
                return _Jobno_desc;
            }
            set
            {
                if (!value.Equals(_Jobno_desc))
                {
                    _Jobno_desc = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Jobno_desc"));
                    }
                }
            }
        }
        private string _Subjobno_desc;
        public string Subjobno_desc
        {
            get
            {
                return _Subjobno_desc;
            }
            set
            {
                if (!value.Equals(_Subjobno_desc))
                {
                    _Subjobno_desc = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Subjobno_desc"));
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

        public static List<JobCharge> GetEntityList()
        {
            List<JobCharge> jobchargeList = new List<JobCharge>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_JobCharge_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        JobCharge jobcharge = FillJobCharge(rdr);
                        jobchargeList.Add(jobcharge);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return jobchargeList;
        }

        public static JobCharge GetEntity(decimal jobchargeID)
        {
            JobCharge jobcharge = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_JobCharge_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CHID", jobchargeID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        jobcharge = FillJobCharge(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return jobcharge;
        }

        public static JobCharge SaveEntity(JobCharge jobcharge)
        {
            if (jobcharge.CHID > 0)
                return UpdateEntity(jobcharge);
            else
                return AddEntity(jobcharge);
        }

        public static void DeleteEntity(JobCharge jobcharge)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_JobCharge_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CHID", jobcharge.CHID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static JobCharge UpdateEntity(JobCharge jobcharge)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_JobCharge_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CHID", jobcharge.CHID);
                    cmd.Parameters.AddWithValue("@Job_Code", jobcharge.Job_Code);
                    cmd.Parameters.AddWithValue("@Jobno", jobcharge.Jobno);
                    cmd.Parameters.AddWithValue("@Subjobno", jobcharge.Subjobno);
                    cmd.Parameters.AddWithValue("@Jobno_desc", jobcharge.Jobno_desc);
                    cmd.Parameters.AddWithValue("@Subjobno_desc", jobcharge.Subjobno_desc);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            jobcharge = GetEntity(jobcharge.CHID);
            return jobcharge;
        }

        private static JobCharge AddEntity(JobCharge jobcharge)
        {
            int CHID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_JobCharge_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Job_Code", jobcharge.Job_Code);
                    cmd.Parameters.AddWithValue("@Jobno", jobcharge.Jobno);
                    cmd.Parameters.AddWithValue("@Subjobno", jobcharge.Subjobno);
                    cmd.Parameters.AddWithValue("@Jobno_desc", jobcharge.Jobno_desc);
                    cmd.Parameters.AddWithValue("@Subjobno_desc", jobcharge.Subjobno_desc);
                    cmd.Parameters.Add(new SqlParameter("@CHID", SqlDbType.Int));
                    cmd.Parameters["@CHID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    CHID = Convert.ToInt32(cmd.Parameters["@CHID"].Value);
                }
                jobcharge = GetEntity(CHID);
            }
            return jobcharge;
        }

        private static JobCharge FillJobCharge(SqlDataReader rdr)
        {
            JobCharge jobcharge = new JobCharge();
            jobcharge.CHID = Convert.ToDecimal(rdr["CHID"]);
            jobcharge.Job_Code = rdr["Job_Code"].ToString();
            jobcharge.Jobno = rdr["Jobno"].ToString();
            jobcharge.Subjobno = rdr["Subjobno"].ToString();
            jobcharge.Jobno_desc = rdr["Jobno_desc"].ToString();
            jobcharge.Subjobno_desc = rdr["Subjobno_desc"].ToString();
            return jobcharge;
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
