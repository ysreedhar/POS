using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace POCS.Forms
{
    public partial class frmViewOrderSummary : Form
    {
        public frmViewOrderSummary()
        {
            InitializeComponent();
        }

        private void frmViewOrderSummary_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.vPOSummary' table. You can move, or remove it, as needed.
            this.vPOSummaryTableAdapter.Fill(this.pOCS.vPOSummary);
            SetReportParameters();
            this.reportViewer1.RefreshReport();
        }
        private void SetReportParameters()
        {
            ReportParameter pRpt_Param_Type = new ReportParameter("Rpt_Param_Type",
                this.rblPO.Checked ? "PO" : "SO");
            ReportParameter pRpt_Param_Date = new ReportParameter("Rpt_Param_Date", dtpFromDate.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(
                      new ReportParameter[] { pRpt_Param_Date,pRpt_Param_Type });
        }
    }
}