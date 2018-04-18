using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace POCS
{
    class Report
    {
        
        
        public Report()
        {
          
        }
        public string GenerateReport(StringBuilder htmlContent)
        {
            //WriteHTML();
            return htmlContent.ToString();
        }
        public bool SaveReport(string fileName, StringBuilder htmlContent)
        {
            try
            {
                GenerateReport(htmlContent);
                StreamWriter sw = new StreamWriter(fileName);
                sw.Write(htmlContent.ToString());
                sw.Flush();
                sw.Close();
                return true;
            }
            catch (Exception exp)
            {
                System.Diagnostics.Debug.WriteLine(exp.Message);
                return false;
            }
        }

    }
}
