using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace POCS.Forms
{
    public partial class frmViewRptChargeCodeDis : Form
    {

        public frmViewRptChargeCodeDis()
        {
            InitializeComponent();
        }

        private void llselAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < clbFilter.Items.Count; i++)
            {
                clbFilter.SetItemChecked(i, true);
            }
        }

        private void llselNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < clbFilter.Items.Count; i++)
            {
                clbFilter.SetItemChecked(i, false);
            }
        }
        void fillJobCharges()
        {
            BindingList<JobCharge> filterList = new BindingList<JobCharge>(JobCharge.GetEntityList());
            clbFilter.DataSource = filterList;
            clbFilter.DisplayMember = "Job_Code";
            clbFilter.ValueMember = "Job_Code";
        }
        void fillJobNos()
        {
            BindingList<JobCharge> filterList = new BindingList<JobCharge>(JobCharge.GetEntityList());
            clbFilter.DataSource = filterList;
            clbFilter.DisplayMember = "JobNo_Desc";
            clbFilter.ValueMember = "JobNo";
        }
        void fillSubJobNos()
        {
            BindingList<JobCharge> filterList = new BindingList<JobCharge>(JobCharge.GetEntityList());
            clbFilter.DataSource = filterList;
            clbFilter.DisplayMember = "SubJobNo_Desc";
            clbFilter.ValueMember = "SubJobNo";
        }
        void fillExpensesCodes()
        {
            BindingList<ExpenseCode> filterList = new BindingList<ExpenseCode>(ExpenseCode.GetEntityList());
            clbFilter.DataSource = filterList;
            clbFilter.DisplayMember = "ExDescription";
            clbFilter.ValueMember = "ExpenseCode";
        }
        void fillChargeTypes()
        {
            clbFilter.DataSource = null;
            clbFilter.Items.Clear();
            String[] ChargeTypes = { "AC", "CP", "DR", "LS", "NA" };
            for (int i = 0; i < 5; i++)
            {
                clbFilter.Items.Add(ChargeTypes[i].ToString(), false);
            }
        }
        private void cboChooseReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboChooseReport.SelectedIndex)
            {
                case 1:
                    fillJobCharges();
                    break;
                case 2:
                    fillJobNos();
                    break;
                case 3:
                    fillSubJobNos();
                    break;
                case 4:
                    fillExpensesCodes();
                    break;
                case 5:
                    fillChargeTypes();
                    break;
                default:
                    MessageBox.Show("Please Choose a Report", Application.ProductName);
                    break;
            }
        }

        private void frmViewRptChargeCodeDis_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
        }
        protected void SetParameterFields()
        {
            ParameterFields paramFields = crvPurchases.ParameterFieldInfo;
            ParameterField paramField = paramFields[0].`;
            ParameterValues curValues = paramField.CurrentValues;
            ParameterDiscreteValue discreteValue = new ParameterDiscreteValue();
            curValues.Add(discreteValue);
            crvPurchases.ParameterFieldInfo = paramFields;
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            crvPurchases.ReportSource = null;
            this.Cursor = Cursors.WaitCursor;
            SetParameterFields();
            Reports.rptPurchasesbySubjob crpt = new Reports.rptPurchasesbySubjob();
            if (cboChooseReport.SelectedIndex == 1)
            {
                crvPurchases.ReportSource = crpt;

            }
            this.Cursor = Cursors.Default;
            System.GC.Collect();
        }

    }
}