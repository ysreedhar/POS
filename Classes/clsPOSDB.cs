using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace POCS
{
    public class clsPOSDB
    {
        string connStr;

        public clsPOSDB()
        {
            connStr = clsGlobals.ConnectionString();
           // connStr = System.Configuration.ConfigurationManager.AppSettings["POCS.Properties.Settings.Default.POCSConnectionString"];
        }

        public int InsertDeliveryPoint(DPDetails emp)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procInsertDeliveryPoint";

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointId", SqlDbType.Int));
            cmd.Parameters["@DeliveryPointId"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointName", SqlDbType.NVarChar, 20));
            cmd.Parameters["@DeliveryPointName"].Value = emp.DeliveryPointName;

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointAddress", SqlDbType.NVarChar, 20));
            cmd.Parameters["@DeliveryPointAddress"].Value = emp.DeliveryPointAddress;

            try
            {
                conn.Open();
                int RecordsAffected = cmd.ExecuteNonQuery();
                int EmpId;
                if (RecordsAffected != 0)
                    EmpId = (int)cmd.Parameters["@DeliveryPointId"].Value;
                else
                    EmpId = -1;
                conn.Close();
                return EmpId;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Data Error:" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public int UpdateDeliveryPoint(DPDetails emp)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procUpdateDeliveryPoint";

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointId", SqlDbType.Int));
            cmd.Parameters["@DeliveryPointId"].Value = emp.DeliveryPointId;

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointName", SqlDbType.NVarChar, 20));
            cmd.Parameters["@DeliveryPointName"].Value = emp.DeliveryPointName;

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointAddress", SqlDbType.NVarChar, 20));
            cmd.Parameters["@DeliveryPointAddress"].Value = emp.DeliveryPointAddress;

            try
            {
                conn.Open();
                int RecordsAffected = cmd.ExecuteNonQuery();
                return RecordsAffected;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Data Error:" + ex );
            }
            finally
            {
                conn.Close();
            }
        }

        public int DeleteDeliveryPoint(int DeliveryPointId)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procDeleteDeliveryPoint";

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointId", SqlDbType.Int));
            cmd.Parameters["@DeliveryPointId"].Value = DeliveryPointId;

            try
            {
                conn.Open();
                int RecordsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return RecordsAffected;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Data Error:" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public DPDetails GetDeliveryPoint(int DeliveryPointId)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procGetDeliveryPointRec";

            cmd.Parameters.Add(new SqlParameter("@DeliveryPointId", SqlDbType.Int));
            cmd.Parameters["@DeliveryPointId"].Value = DeliveryPointId;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DPDetails emp;
                if (dr.Read())
                    emp = new DPDetails((int)dr["DeliveryPointId"], (string)dr["DeliveryPointName"], (string)dr["DeliveryPointAddress"]);
                else
                    emp = null;
                dr.Close();
                conn.Close();
                return emp;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Data Error\n" + ex.Message);
            }
        }

        public DPDetails[] GetAllDeliveryPoint()
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procGetAllDeliveryPoint";

            ArrayList arrEmp = new ArrayList();
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DPDetails emp;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        emp = new DPDetails((decimal)dr["DeliveryPointId"], (string)dr["DeliveryPointName"], (string)dr["DeliveryPointAddress"]);
                        arrEmp.Add(emp);
                    }
                }
                else
                    emp = null;
                dr.Close();
                conn.Close();
                return (DPDetails[])arrEmp.ToArray(typeof(DPDetails));
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Data Error\n" + ex.Message);
            }
        }

    }
}
