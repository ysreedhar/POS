using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS.Ds.POCSTableAdapters;

namespace POCS
{
    public partial class FrmInvoiceEntry : Form
    {
        public FrmInvoiceEntry()
        {
            InitializeComponent();
        }

        private void FrmEnterInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.vPODetSummary' table. You can move, or remove it, as needed.
        //    this.vPODetSummaryTableAdapter.Fill(this.pOCS.vPODetSummary);


        }

        private void cboOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvWithOrderData();
        }
        void FillDgvWithOrderData()
        {
            if (cboOrders.Text != "")
            {
                this.vPODetSummaryTableAdapter.FillByTypeOrderNO(this.pOCS.vPODetSummary,(rblPO.Checked?"PO":"SO"),Convert.ToDecimal(cboOrders.Text));
                    
            }
        }



        private void rblPO_CheckedChanged(object sender, EventArgs e)
        {
            if (rblPO.Checked)
                fncFillOrders(rblPO.Text);
        }

        private void rblSO_CheckedChanged(object sender, EventArgs e)
        {
            if (rblSO.Checked)
                fncFillOrders(rblSO.Text);
        }
        void fncFillOrders(string strType)
        {
            try
            {
                this.orderNumbersTableAdapter.FillByType(this.pOCS.OrderNumbers, strType);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}