using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace POCS
{
    public partial class frmViewEARF : Form
    {
        public frmViewEARF()
        {
            InitializeComponent();
        }

        private void frmViewEARF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOS_DBDataSet.PO_Header' table. You can move, or remove it, as needed.
            this.pO_HeaderTableAdapter.FillByType(this.POCS.PO_Header,"PO");
        }
        private void SetReportParameters()
        {

            ReportParameter pRpt_Param_POID = new ReportParameter("Rpt_Param_POID",
               cboOrders.SelectedValue.ToString());
            this.reportViewer1.LocalReport.SetParameters(
                      new ReportParameter[] { pRpt_Param_POID });
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'POCS.vEARF' table. You can move, or remove it, as needed.
            try
            {
                this.vEARFTableAdapter.Fill(this.POCS.vEARF);
                SetReportParameters();
                this.reportViewer1.RefreshReport();
            }
            catch { }
        }

        
    }
}