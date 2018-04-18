using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POCS.Forms
{
    public partial class BuyerManagement : Form
    {
        public BuyerManagement()
        {
            InitializeComponent();
        }

        private void BuyerManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.tblBuyer' table. You can move, or remove it, as needed.
            this.tblBuyerTableAdapter.Fill(this.pOCS.tblBuyer);

        }

        private void dgvBuyers_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                //tblBuyerTableAdapter.Insert(dgvBuyers.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvBuyers.Rows[e.RowIndex].Cells[2].Value.ToString());


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                tblBuyerTableAdapter.Update(this.pOCS.tblBuyer);
                MessageBox.Show("Buyer Information Updated Successfully", Application.ProductName);
                
            }
        }
        private bool IsValid()
        {
            bool AllOK =true;
            foreach (DataGridViewRow GridRow in dgvBuyers.Rows)
            {
                
                foreach (DataGridViewCell Cel in GridRow.Cells)
                {
                    if (Cel.Value != null)
                    {
                        if (Cel.Value.ToString() == "")
                            AllOK = false;
                    }
                }
            }
            return AllOK;
        }
    }
}