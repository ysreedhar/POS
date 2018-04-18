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
    public partial class frmUpdateMsrStatus : Form
    {
        public frmUpdateMsrStatus()
        {
            InitializeComponent();
        }

        private void frmUpdateMsrStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.MSRStatusDesc' table. You can move, or remove it, as needed.
            this.mSRStatusDescTableAdapter.FillByWithoutCancelledMSRs(this.pOCS.MSRStatusDesc);
            // TODO: This line of code loads data into the 'pOCS.tblMSRStatus' table. You can move, or remove it, as needed.
            this.tblMSRStatusTableAdapter.Fill(this.pOCS.tblMSRStatus);
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboStatus.SelectedIndex > -1)
            {
            if (cboStatus.SelectedValue.ToString() == "50")
            {
                PO_detailsTableAdapter podAdapter = new PO_detailsTableAdapter();
                int RowCount = 0;
                RowCount = (int) podAdapter.GetDataByPOIDforMSRNo(cboMsrNo.Text).Rows.Count;
                if (RowCount == 0)
                    MessageBox.Show("Cannot Set the Status as no POs/SOs Issued", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            }
        }

        private void cboMsrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboStatus.Text = cboMsrNo.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                tblMSRReceiptsTableAdapter adpStatusAdapter = new tblMSRReceiptsTableAdapter();
                adpStatusAdapter.UpdateMSRStatusbyMSRNo(Convert.ToInt16(cboStatus.SelectedValue), cboMsrNo.Text);
                MessageBox.Show("Status Updated Successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            { }
        }

    }
}