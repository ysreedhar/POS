using System;
using System.Collections.Generic;
using System.Text;

namespace POCS.Classes
{
    public class ChargeCode
    {
        public string jobcode, expensecode, chargecode, distpercentage;
        int rowid;
        //public ChargeCode(int RowID, string JobCode, string ExpenseCode, string ChargeCode, string DistPercentage)
        public ChargeCode(string ChargeCode, string DistPercentage)
        {
            //rowid = RowID;
            //jobcode = JobCode;
            //expensecode = ExpenseCode;
            chargecode = ChargeCode;
            distpercentage = DistPercentage;
        }
        public override string ToString()
        {
            //return jobcode.ToString() + ", " + expensecode.ToString() + ", " + chargecode.ToString() + ", " + distpercentage.ToString();
            return chargecode.ToString() + ", " + distpercentage.ToString();
        }
    }
}
