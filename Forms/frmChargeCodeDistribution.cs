using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace POCS.Forms
{
    public partial class frmChargeCodeDistribution : KryptonForm
    {
        public frmChargeCodeDistribution()
        {
            InitializeComponent();
        }

        private void rblPO_CheckedChanged(object sender, EventArgs e)
        {
            if (rblPO.Checked)
            {
                FillOrderCombo(rblPO.Text);
            }
        }

        private void frmChargeCodeDistribution_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.tblItemCostDistribution' table. You can move, or remove it, as needed.
            this.tblItemCostDistributionTableAdapter.Fill(this.pOCS.tblItemCostDistribution);
            // TODO: This line of code loads data into the 'pOCS.PO_details' table. You can move, or remove it, as needed.
            this.pO_detailsTableAdapter.Fill(this.pOCS.PO_details);

        }
        void FillOrderCombo(string Type)
        {
            try
            {
                this.pO_HeaderTableAdapter.FillByType(this.pOCS.PO_Header,Type);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void rblSO_CheckedChanged(object sender, EventArgs e)
        {
            if (rblSO.Checked)
            {
                FillOrderCombo(rblSO.Text);
            }
        }
        void FillItemDescCombo(decimal poid)
        {
            try
            {
                this.pO_detailsTableAdapter.FillBy(this.pOCS.PO_details, poid);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cboOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOrders.SelectedIndex > 0)
                FillItemDescCombo((decimal)cboOrders.SelectedValue);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.tblItemCostDistributionTableAdapter.Update(this.pOCS.tblItemCostDistribution);
        }
        
    }
}