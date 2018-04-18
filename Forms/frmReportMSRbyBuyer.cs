using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS.Ds.POCSTableAdapters;
using POCS;

namespace POCS
{
    public partial class frmReportMSRbyBuyer : Form
    {
        public frmReportMSRbyBuyer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  this.newDataSet.ReadXml("CustomerOrders.xml");
            // TODO: This line of code loads data into the 'pOCS.tblMSRReceipts' table. You can move, or remove it, as needed.
                this.vMSR_POIssuedTableAdapter.Fill(this.pOCS.vMSR_POIssued);
                this.reportViewer1.RefreshReport();
         
        }
    }
}