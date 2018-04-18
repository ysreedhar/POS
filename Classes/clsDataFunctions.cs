using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace POCS
{
    public class clsDataFunctions
    {

        public static DataTable LoadOrderData(string OrderNo)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            string sql = "SELECT * FROM PO_header where PO_OrderNo = '" + OrderNo + "'"  ;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = conn;
            sqlcommand.CommandText = sql;
            sqlcommand.CommandType = CommandType.Text;
            SqlDataAdapter sqldataadapter = new SqlDataAdapter();
            sqldataadapter.SelectCommand = sqlcommand;
            DataSet dataSet = new DataSet();
            sqldataadapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public static DataTable LoadInvoiceNumbers()
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            string sql = "SELECT ExprConcat FROM vInvoiceVendorValue where transmittalNumber = 0";
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = conn;
            sqlcommand.CommandText = sql;
            sqlcommand.CommandType = CommandType.Text;
            SqlDataAdapter sqldataadapter = new SqlDataAdapter();
            sqldataadapter.SelectCommand = sqlcommand;
            DataSet dataSet = new DataSet();
            sqldataadapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public static string GetUserRights(string UserName)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT AccessRights FROM tblUsers where UserID = '" + UserName + "'";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string AccessRights = (string)returnValue;
            return AccessRights;
        }
        public static string GetCurrencyUnitsInShillings(string Currency)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT Shillings FROM tblCurrency where Currency = '" + Currency + "'";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string Shillings = (string)returnValue;
            return Shillings;
        }
        public static string GetUserFullName(string UserName)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT UserName FROM tblUsers where UserID = '" + UserName + "'";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string UserFullName = (string)returnValue;
            return UserFullName;
        }
        public static string GetUserType(string UserName)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT UserType FROM tblUsers where UserID = '" + UserName + "'";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string UserType = (string)returnValue;
            return UserType;
        }

        public static string GetUserDept(string UserName)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT Department FROM tblUsers where UserID = '" + UserName + "'";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string UserDept = (string)returnValue;
            return UserDept;
        }
        public static string FunGetjobnoDesc(decimal ChId)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT jobno_Desc FROM tblJobCharge where Chid = " + ChId ;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string JobNoDesc = (string)returnValue;
            return JobNoDesc;
        }
        public static bool PONumberExists(decimal PONumber, string OrderSeriesType,string OrderType)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT Count(PO_OrderNo) FROM PO_header where PO_OrderNo = " + PONumber + " and Type = '" + OrderType + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            int OrderCount = (int)returnValue;
            bool OrderExists = (OrderCount == 0);
            return OrderExists;
        }
        public static string FunGetConctPerson(decimal VId)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "select v_contactperson from vendor where vendor_id = " + VId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string strConctPerson = (string)returnValue;
            return strConctPerson;
        }
        public static string FunGetConctPersonTel(decimal VId)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "select v_mobile from vendor where vendor_id = " + VId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string strConctPersonTel = (string)returnValue;
            return strConctPersonTel;
        }        
        public static string FunGetAddressInfo(decimal VId)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "select v_address + char(13) + char(10) + v_state + ' ' + v_zip + char(13) + char(10) + + 'Tel: ' + v_phone + char(13) + char(10) + 'Fax: ' + v_Fax from vendor where vendor_id = " + VId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string AddressString = (string)returnValue;
           return AddressString;
        }
        public static string FunGetSubJobnoDesc(decimal ChId)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT SubJobno_Desc FROM tblJobCharge where Chid = " + ChId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            string SubJobnoDesc = (string)returnValue;
            return SubJobnoDesc;
        }
        public static int FunGetPaymentTerms(decimal VId)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT PaymentTerms FROM vendor where vendor_id = " + VId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            int intPaymentTerms = (int)returnValue;
            return intPaymentTerms;
        }
        public static bool FunGetUserValidPassword(string UserName, string Password)
        {
            string ConnStr = clsGlobals.ConnectionString();
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            cmd.CommandText = "SELECT Count(*) FROM tblUsers where UserID = '" + UserName + "' and UserPassword = '" + Password + "'";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            returnValue = cmd.ExecuteScalar();
            conn.Close();
            int recCount = (int)returnValue;
            if (recCount > 0)
                return true;
            else
                return false;
        }
    }
}
