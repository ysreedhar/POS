using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS;

namespace POCS
{
    public partial class FrmOrderSummary_SO : Form
    {
        public FrmOrderSummary_SO()
        {
            InitializeComponent();
        }

        private void FrmOrderSummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.PO_Header' table. You can move, or remove it, as needed.
            this.pO_HeaderTableAdapter.FillByType(this.pOCS.PO_Header,"SO");

        }
        // Displays the drop-down list when the user presses 
        // ALT+DOWN ARROW or ALT+UP ARROW.
        private void dgvOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up))
            {
                DataGridViewAutoFilterColumnHeaderCell filterCell =
                    dgvOrders.CurrentCell.OwningColumn.HeaderCell as
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
                .GetFilterStatus(dgvOrders);
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
            DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvOrders);
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }
        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (clsGlobals.UserType.ToString().ToLower() != "admin")
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow theRow = dgvOrders.Rows[rowIndex];

                    string cellValue = theRow.Cells[10].Value.ToString();
                    if (cellValue != clsGlobals.UserName)
                    {
                        theRow.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        // theRow.DefaultCellStyle.BackColor = Color.Blue;
                    }
                }
            }
            catch { }
        }
        private string UserName = clsGlobals.UserName;
        private bool isEditablebyUser(string Owner)
        {

            if (clsGlobals.UserType.ToString().ToLower() != "admin")
            {
                if (Owner != UserName)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.CurrentRow.Index > 0 || dgvOrders.CurrentRow.Index != null)
                {
                    // TODO: This line of code loads data into the 'pOCS.PO_details' table. You can move, or remove it, as needed.
                    this.pO_detailsTableAdapter.Fill(this.pOCS.PO_details);

                    this.pO_detailsTableAdapter.FillBy(this.pOCS.PO_details, ((decimal)(System.Convert.ChangeType(dgvOrders.CurrentRow.Cells[0].Value.ToString(), typeof(decimal)))));
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            //this.pO_detailsTableAdapter.Update(SO
        }


        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.WhiteSmoke)
            {
                FrmDEntry_SO frm = new FrmDEntry_SO();
                frm.MdiParent = this.ParentForm;
                frm.IsEditMode = true;
                frm.Show();
                try
                {
                    TextBox myControl1 = (TextBox)this.ParentForm.ActiveMdiChild.Controls.Find("txtPONumber", true)[0];
                    myControl1.Text = dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                catch { }
            }
        }

        private void FrmOrderSummary_Activated(object sender, EventArgs e)
        {
            try
            {
                this.pO_HeaderTableAdapter.FillByType(this.pOCS.PO_Header,"SO");
                dgvOrders.Refresh();
            }
            catch
            { }
        }
    }
}