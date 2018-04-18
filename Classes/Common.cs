using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace POCS
{
    class Common
    {
        public Common()
        {
        }
        public static readonly string ConnectionString = clsGlobals.ConnectionString();//@"Data Source=.;Initial Catalog=northwind;integrated security=true;";
        public static DataSet dsPODetails(decimal PO_OrderNo)
        {
            using (SqlConnection con = new SqlConnection(clsGlobals.ConnectionString().ToString()))
            {
                SqlCommand command = new SqlCommand("Select * from vPOdetailsCalculation Where poid in (select Poid from Po_header where Po_OrderNo = " + PO_OrderNo + ") order by po_detailId", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet data = new DataSet();
                adapter.Fill(data, "vPOdetailsCalculation");
                return data;
            }
        }

        public static DataSet dsPODetailsByPO_OrderNO(decimal PO_OrderNo)
        {
            using (SqlConnection con = new SqlConnection(clsGlobals.ConnectionString().ToString()))
            {
                SqlCommand command = new SqlCommand("Select * from vPOdetailsCalculation Where poid in (select Poid from Po_header where Po_OrderNo = " + PO_OrderNo + ")", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataDetail = new DataSet();
                adapter.Fill(dataDetail, "vPOdetailsCalculation");
                return dataDetail;
            }
        }
        public static DataSet dsOrderHeader(decimal PO_OrderNo)
        {
            using (SqlConnection con = new SqlConnection(clsGlobals.ConnectionString().ToString()))
            {
                SqlCommand command = new SqlCommand("Select * from po_header where Po_OrderNo = " + PO_OrderNo, con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet data = new DataSet();
                adapter.Fill(data, "po_header");
                return data;
            }
        }

        public static string arrItemChargeCodeDistribution(decimal po_detailID)
        {
            DataSet data = new DataSet();
            using (SqlConnection con = new SqlConnection(clsGlobals.ConnectionString().ToString()))
            {
                SqlCommand command = new SqlCommand("Select ChargeCode, DistPercentage from tblItemCostDistribution Where po_detailid = " + po_detailID, con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(data, "tblItemCostDistribution");

            }
            StringBuilder CCString = new StringBuilder();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                CCString.AppendFormat("Charge Code: {0} {1}%\n", row[0].ToString(), row[1].ToString());
            }
            return CCString.ToString();
        }
        public static int intEARFNo(DateTime PODate, string OrderNumber)
        {
            DataSet EARFdata = new DataSet();
            DataSet EARFDataYear = new DataSet();
            int EarfNo = 0;
            using (SqlConnection con = new SqlConnection(clsGlobals.ConnectionString().ToString()))
            {
                SqlCommand command = new SqlCommand("select max(EarfNO) from vEARF where PO_OrderNO = " + OrderNumber, con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(EARFdata, "vEARF");
            }
            foreach (DataRow row in EARFdata.Tables[0].Rows)
            {
                if (row[0].ToString() != "")
                {
                    // if the orderNO is present return the EARFNO
                    EarfNo = Convert.ToInt16(row[0]);
                }
                else // if the Row is null
                {
                    using (SqlConnection con = new SqlConnection(clsGlobals.ConnectionString().ToString()))
                    {
                        SqlCommand command = new SqlCommand("select max(EarfNO) from vEARF where year(PO_Date) = " + PODate.Year.ToString(), con);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        adapter.Fill(EARFDataYear, "vEARF");
                    }
                    foreach (DataRow EARrow in EARFDataYear.Tables[0].Rows)
                    {
                        if (EARrow[0].ToString() != "")
                        {
                            // if the orderNO is present return the incremented EARFNO
                            EarfNo = Convert.ToInt16(EARrow[0]) + 1;
                        }
                        else
                        {
                            EarfNo = 1;
                        }
                    }
                }
            }

            return EarfNo;
        }

        
    }

}
