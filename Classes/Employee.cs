using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace POCS
{
    //INotifyPropertyChanged  - notifies the binding controls if a property changes programatically
    public class Employee : INotifyPropertyChanged 
    {
        #region Properties

        private int _EmployeeID;
        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }
        }

        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (!value.Equals(_FirstName))
                {
                    _FirstName= value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
                    }
                }
            }
        }

        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (!value.Equals(_LastName))
                {
                    _LastName  = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
                    }
                }
            }
        }

        public string FullName
        {
            get
            {
                return _FirstName + " " + _LastName;
            }
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Static CRUD Methods

        #region Public Methods

        public static List<Employee> GetEntityList()
        {
            List<Employee> employeeList = new List<Employee>();

            using (SqlConnection cn = new SqlConnection(Common.ConnectionString))
            {
                string sql = "SELECT '1' as EmployeeID , 'MURADI' as FirstName, 'AMIR' as LastName";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (rdr.Read())
                    {
                        Employee employee = FillEmployee(rdr);
                        employeeList.Add(employee);
                    }
                    if (!rdr.IsClosed)
                        rdr.Close();
                }
            }
            return employeeList;
        }

        #endregion

        #region Private Methods

        private static Employee FillEmployee(SqlDataReader rdr)
        {
            Employee employee = new Employee();
            employee.EmployeeID = 1;//Convert.ToInt32(rdr["EmployeeID"]);
            employee.FirstName = "MURADI";//rdr["FirstName"].ToString();
            employee.LastName = "AMIR";//rdr["LastName"].ToString();
            return employee;
        }

        #endregion

        #endregion
        
    }


}
