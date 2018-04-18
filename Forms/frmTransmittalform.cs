using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS.Ds.POCSTableAdapters;

namespace POCS.Forms
{
    public partial class frmTransmittalform : Form
    {
        public frmTransmittalform()
        {
            InitializeComponent();
        }

        private void frmTransmittalform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POCS.Company' table. You can move, or remove it, as needed.
            this.CompanyTableAdapter.Fill(this.POCS.Company);
            SetClBoxDataSource(cblInvoices, clsDataFunctions.LoadInvoiceNumbers());
              cblInvoices.DisplayMember = "ExprConcat";
              cblInvoices.ValueMember = "ExprConcat";
            
        }
        private void SetClBoxDataSource(CheckedListBox clb, DataTable dt)
        {
            clb.Items.Clear();
            foreach (DataRow drow in dt.Rows)
            {
                clb.Items.Add(drow[0].ToString());
            }
        }

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            string strUserName = ((FrmMain)this.ParentForm).ReturnUserName().ToString();
            //string strInvoiceNumbers;
           //Array aInvoiceArray;
            foreach (object lItem in cblInvoices.CheckedItems)
            {
               string strchkInvoiceNo = lItem.ToString();
            }
            tblTransmittalLogTableAdapter tAdapter = new tblTransmittalLogTableAdapter();
            tAdapter.spInsertTransmittal(strUserName,txtName.Text,txtDepartment.Text,dtpTransmittalDate.Value,"-");
        }
    }
}