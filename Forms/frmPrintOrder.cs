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
    public partial class frmPrintOrder : Form
    {
        public frmPrintOrder()
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
        
            e.DataSources.Add(new ReportDataSource("POCS_vPOdetailsCalculation", pOCS.Tables["vPODetailsCalculation"]));
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            try
            {
                this.PO_HeaderTableAdapter.FillByType(this.pOCS.PO_Header, "PO");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //this.PO_HeaderTableAdapter.Fill(this.pOCS.PO_Header);
            // TODO: This line of code loads data into the 'pOCS.vPOdetailsCalculation' table. You can move, or remove it, as needed
            try
            {
                this.vPOdetailsCalculationTableAdapter.FillByPOID(this.pOCS.vPOdetailsCalculation, ((decimal)(System.Convert.ChangeType(cboOrders.SelectedValue, typeof(decimal)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message,Application.ProductName);
            }
            SetReportParameters();
            this.reportViewer1.RefreshReport();
            
        }
        private void SetReportParameters()
        {
            ReportParameter pRpt_Param_Type = new ReportParameter("rptParamType", "PO");
            ReportParameter pRpt_Param_POID = new ReportParameter("rptParamPOID", cboOrders.SelectedValue.ToString());
            this.reportViewer1.LocalReport.SetParameters(
                      new ReportParameter[] { pRpt_Param_POID, pRpt_Param_Type });
        }



    }
}