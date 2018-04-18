using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class ExpenseCode : INotifyPropertyChanged
    {
        #region Properties

        private decimal _ExCodeID;
        public decimal ExCodeID
        {
            get
            {
                return _ExCodeID;
            }
            set
            {
                _ExCodeID = value;
            }
        }
        private string _ExpenseCode;
        public string expenseCode
        {
            get
            {
                return _ExpenseCode;
            }
            set
            {
                if (!value.Equals(_ExpenseCode))
                {
                    _ExpenseCode = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("expenseCode"));
                    }
                }
            }
        }

        private string _ExDescription;
        public string ExDescription
        {
            get
            {
                return _ExDescription;
            }
            set
            {
                if (!value.Equals(_ExDescription))
                {
                    _ExDescription = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ExDescription"));
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

        public static List<ExpenseCode> GetEntityList()
        {
            List<ExpenseCode> buyerList = new List<ExpenseCode>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_ExpenseCode_GetList";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        ExpenseCode expensecode = FillExpenseCode(rdr);
                        buyerList.Add(expensecode);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return buyerList;
        }

        public static ExpenseCode GetEntity(decimal buyerID)
        {
            ExpenseCode expensecode = null;

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_ExpenseCode_Get";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ExCodeID", buyerID);
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        expensecode = FillExpenseCode(rdr);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return expensecode;
        }

        public static ExpenseCode SaveEntity(ExpenseCode expensecode)
        {
            if (expensecode.ExCodeID > 0)
                return UpdateEntity(expensecode);
            else
                return AddEntity(expensecode);
        }

        public static void DeleteEntity(ExpenseCode expensecode)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_ExpenseCode_Delete";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ExCodeID", expensecode.ExCodeID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Private Methods

        private static ExpenseCode UpdateEntity(ExpenseCode expensecode)
        {
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_ExpenseCode_Update";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ExCodeID", expensecode.ExCodeID);
                    cmd.Parameters.AddWithValue("@ExpenseCode", expensecode.expenseCode);
                    cmd.Parameters.AddWithValue("@ExDescription", expensecode.ExDescription);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            expensecode = GetEntity(expensecode.ExCodeID);
            return expensecode;
        }

        private static ExpenseCode AddEntity(ExpenseCode expensecode)
        {
            int ExCodeID = 0;
            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string proc = "pr_ExpenseCode_Add";
                using (SqlCommand cmd = new SqlCommand(proc, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ExpenseCode", expensecode.expenseCode);
                    cmd.Parameters.AddWithValue("@ExDescription", expensecode.ExDescription);
                    cmd.Parameters.Add(new SqlParameter("@ExCodeID", SqlDbType.Int));
                    cmd.Parameters["@ExCodeID"].Direction = ParameterDirection.Output;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    ExCodeID = Convert.ToInt32(cmd.Parameters["@ExCodeID"].Value);
                }
                expensecode = GetEntity(ExCodeID);
            }
            return expensecode;
        }

        private static ExpenseCode FillExpenseCode(SqlDataReader rdr)
        {
            ExpenseCode expensecode = new ExpenseCode();
            expensecode.ExCodeID = Convert.ToDecimal(rdr["ExCodeID"]);
            expensecode.expenseCode = rdr["ExpenseCode"].ToString();
            expensecode.ExDescription = rdr["ExDescription"].ToString();
            return expensecode;
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
