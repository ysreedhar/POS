using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace POCS
{
    public class clsExportToExcel
    {
        public clsExportToExcel()
        {
        }

        public bool ExportToExcel(string Filname, DataSet ds)
        {
            try
            {
                FileInfo fi = new FileInfo(Filname);
                StreamWriter sw = fi.CreateText();
                sw.WriteLine("<html><head><title>" +
                             "Order Summary Export</title>");
                sw.WriteLine("<style>th, td {border-bottom:solid 1px" +
                             " brown;border-right:solid 1px brown;}" +
                             " table {font:normal 12px arial}" +
                             "</style></head><body>");
                sw.WriteLine("<table cellpadding=0 cellspacing=0 " +
                             "style='border:solid 1px brown'>");
                // sw.Write("<tr bgcolor='#FF9933'><th align='center' " + ">"+ dc[0] +"</th></tr>");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sw.Write("<tr>");
                    foreach (DataColumn dc in ds.Tables[0].Columns)
                    {
                        sw.Write("<td align='left'>&nbsp;" + dr[dc] + "</td>");
                    }
                    sw.Write("</tr>");
                }
                sw.WriteLine("</table>");
                sw.WriteLine("</body></html>");
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

