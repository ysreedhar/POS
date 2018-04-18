using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using POCS.Ds;
using POCS.Ds.POCSTableAdapters;
using Microsoft.Win32;
namespace POCS
{

    public class clsGlobals
    {
        //private string companyName;
        public static void IESetupMargins()
        {
            
                string strKey = "Software\\Microsoft\\Internet Explorer\\PageSetup";
                bool bolWritable = true;
                //string strName = "margin_bottom";
                object oValue = "0.6";
                string[] arrmargins = new string[3];

                RegistryKey oKey = Registry.CurrentUser.OpenSubKey(strKey, bolWritable);
                //Console.Write(strKey);
                oKey.SetValue("margin_bottom", POCS.Properties.Settings.Default.margin_bottom);
                oKey.SetValue("margin_left", POCS.Properties.Settings.Default.margin_left);
                oKey.SetValue("margin_right", POCS.Properties.Settings.Default.margin_right);
                oKey.SetValue("margin_top", POCS.Properties.Settings.Default.margin_top);
                oKey.Close();
            
        }
        public static string CompanyName()
        {
            QueriesTableAdapter tAdapter = new QueriesTableAdapter();
            string companyName = tAdapter.SQCompanyName().ToString(); 
            return companyName;
        }
        public static int intA4index()
        {

            string strindex = POCS.Properties.Settings.Default.margin_bottom.ToString(); ;
                return Convert.ToInt16(strindex);
        }
        public static string ConnectionString()
        {
            string ConString = System.Configuration.ConfigurationManager.AppSettings["connStr"];
            return ConString;
        }
        public static string strFileUploadPath()
        {
            string StrFileUploadPath = System.Configuration.ConfigurationManager.AppSettings["strFileUploadPath"];
            return StrFileUploadPath;
        }
        public static string FileUploadService()
        {
            string fileUploadService = System.Configuration.ConfigurationManager.AppSettings["FileUploadService"];
            return fileUploadService;
        }
        private static string _UserName;
        public static string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        private static string _UserType;
        public static string UserType
        {
            get
            {
                return _UserType;
            }
            set
            {
                _UserType = value;
            }
        }
            

    }
}
