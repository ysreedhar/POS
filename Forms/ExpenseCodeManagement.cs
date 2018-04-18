using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POCS
{
    public partial class ExpenseCodeManagement : Form
    {
        public ExpenseCodeManagement()
        {
            InitializeComponent();
        }

        private void BuyerManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.tblExpenseCode' table. You can move, or remove it, as needed.
            this.tblExpenseCodeTableAdapter.Fill(this.pOCS.tblExpenseCode);
            // TODO: This line of code loads data into the 'pOCS.tblExpenseCode' table. You can move, or remove it, as needed.
            this.tblExpenseCodeTableAdapter.Fill(this.pOCS.tblExpenseCode);

        }
        // Displays the drop-down list when the user presses 
        // ALT+DOWN ARROW or ALT+UP ARROW.
        private void dgvOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up))
            {
                DataGridViewAutoFilterColumnHeaderCell filterCell =
                    dgvExpenseCodes.CurrentCell.OwningColumn.HeaderCell as
                    DataGridViewAutoFilterColumnHeaderCell;
                if (filterCell != null)
                {
                    filterCell.ShowDropDownList();
                    e.Handled = true;
                }
            }
        }

        // Updates the filter status label. 
        private void dgvOrders_DataBindingComplete(object sender,
            DataGridViewBindingCompleteEventArgs e)
        {
            String filterStatus = DataGridViewAutoFilterColumnHeaderCell
                .GetFilterStatus(dgvExpenseCodes);
            if (String.IsNullOrEmpty(filterStatus))
            {
                showAllLabel.Visible = false;
                filterStatusLabel.Visible = false;
            }
            else
            {
                showAllLabel.Visible = true;
                filterStatusLabel.Visible = true;
                filterStatusLabel.Text = filterStatus;
            }
        }

        // Clears the filter when the user clicks the "Show All" link
        // or presses ALT+A. 
        private void showAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvExpenseCodes);
        }
   
        private void dgvExpenseCodes_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                //tblExpenseCodeTableAdapter.Insert(dgvExpenseCodes.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvExpenseCodes.Rows[e.RowIndex].Cells[2].Value.ToString());


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                tblExpenseCodeTableAdapter.Update(this.pOCS.tblExpenseCode);
                
                MessageBox.Show("Buyer Information Updated Successfully", Application.ProductName);
            }
        }
        private bool IsValid()
        {
            bool AllOK =true;
            foreach (DataGridViewRow GridRow in dgvExpenseCodes.Rows)
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