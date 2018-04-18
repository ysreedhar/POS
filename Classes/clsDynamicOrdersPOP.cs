using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace POCS
{
    public class clsDynamicOrdersPOP
    {

        public clsDynamicOrdersPOP()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static SqlConnection GetConnection()
        {
            // get the connection string from web.config
            string sCon = clsGlobals.ConnectionString();
            return new SqlConnection(sCon);

        }

        public static System.Data.DataSet DynamicCategorySalesByWeek(DateTime startingDate, int numWeeks)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DynamicOrdersByPOP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // add parameters
                cmd.Parameters.AddWithValue("@startingDate", startingDate);
                cmd.Parameters.AddWithValue("@numWeeks", numWeeks);

                // execute via a DataAdapter and return the results as a DataSet
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

    }

}

