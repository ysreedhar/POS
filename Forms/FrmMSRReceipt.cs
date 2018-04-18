using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS.Ds.POCSTableAdapters;
using POCS;

namespace POCS.Forms
{
    public partial class FrmMSRReceipt : Form
    {
        public FrmMSRReceipt()
        {
            InitializeComponent();
        }
        private bool IsEditMode;
        private decimal decMSRId;
        private void FrmMSRReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOCS.tblBuyer' table. You can move, or remove it, as needed.
            this.tblBuyerTableAdapter.Fill(this.pOCS.tblBuyer);
            // TODO: This line of code loads data into the 'pOCS.tblMSRReceipts' table. You can move, or remove it, as needed.
            this.tblMSRReceiptsTableAdapter.Fill(this.pOCS.tblMSRReceipts);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblMSRReceiptsTableAdapter dAdapter = new tblMSRReceiptsTableAdapter();

            if (!IsEditMode)
            {
                if (IsValidEntry())
                {
                    dAdapter.InsertMSRReceipt(txtMSRNo.Text, dtpMSRDate.Value, dtpReceivedDate.Value, dtpRequiredDate.Value, Convert.ToInt16(txtNosofItems.Text), txtRequestor.Text, txtDepartment.Text, txtApprovedBy.Text, txtProject.Text, cboBuyer.Text, txtDescription.Text, 10);
                    MessageBox.Show("New MSR Receipt Entered Succesfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.tblMSRReceiptsTableAdapter.Fill(this.pOCS.tblMSRReceipts);
                }
                else
                {
                    MessageBox.Show("Please Check the Entries for Validity", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (IsValidEntry())
                {
                    dAdapter.UpdateMSRReceipt(txtMSRNo.Text, dtpMSRDate.Value, dtpReceivedDate.Value, dtpRequiredDate.Value, Convert.ToInt16(txtNosofItems.Text), txtRequestor.Text, txtDepartment.Text, txtApprovedBy.Text, txtProject.Text, cboBuyer.Text, txtDescription.Text, decMSRId);
                    MessageBox.Show("MSR Receipt Information Updated Succesfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.tblMSRReceiptsTableAdapter.Fill(this.pOCS.tblMSRReceipts);
                    IsEditMode = false;

                }
                else
                {
                    MessageBox.Show("Please Check the Entries for Validity", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }
        // Displays the drop-down list when the user presses 
        // ALT+DOWN ARROW or ALT+UP ARROW.
        private void dgvMSRListing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up))
            {
                DataGridViewAutoFilterColumnHeaderCell filterCell =
                    dgvMSRListing.CurrentCell.OwningColumn.HeaderCell as
                    DataGridViewAutoFilterColumnHeaderCell;
                if (filterCell != null)
                {
                    filterCell.ShowDropDownList();
                    e.Handled = true;
                }
            }
        }

        // Updates the filter status label. 
        private void dgvMSRListing_DataBindingComplete(object sender,
            DataGridViewBindingCompleteEventArgs e)
        {
            String filterStatus = DataGridViewAutoFilterColumnHeaderCell
                .GetFilterStatus(dgvMSRListing);
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
            DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvMSRListing);
        }
        private bool IsValidEntry()
        {
            bool bValidMSRNo = ValidateIsNotEmptyTextBox(txtMSRNo, "Enter MSRNo");
            bool bValidNosofItems = ValidateIsNotEmptyTextBox(txtNosofItems, "Enter No. of Items");
            bool bValidDescription = ValidateIsNotEmptyTextBox(txtDescription, "Enter Description");
            bool bValidRequestor = ValidateIsNotEmptyTextBox(txtRequestor, "Enter Resquestor");
            bool bValidDepartment = ValidateIsNotEmptyTextBox(txtDepartment, "Enter Department");
            bool bValidApprovedBy = ValidateIsNotEmptyTextBox(txtApprovedBy, "Enter Approver");
            bool bValidBuyer = ValidateIsNotEmptyTextBox(cboBuyer, "Enter Buyer");
            bool bValidProject = ValidateIsNotEmptyTextBox(txtProject, "Enter Project");
            if (bValidMSRNo && bValidNosofItems && bValidDescription && bValidRequestor && bValidDepartment && bValidDepartment && bValidApprovedBy && bValidBuyer && bValidProject)
                return true;
            else
                return false;
        }
        private bool ValidateIsNotEmptyTextBox(Control txtToValidate, string MessageToShow)
        {
            bool bStatus = true;
            if (txtToValidate.Text == "")
            {
                warningProvider.SetError(txtToValidate, MessageToShow);
                bStatus = false;
                txtToValidate.Focus();
                //set main form status
                ((FrmMain)this.ParentForm).WriteToStatusBar(MessageToShow);
            }
            else
                warningProvider.SetError(txtToValidate, "");
            return bStatus;
        }

        private void dgvMSRListing_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                decMSRId = Convert.ToDecimal(dgvMSRListing.SelectedRows[0].Cells[0].Value);
                txtMSRNo.Text = dgvMSRListing.SelectedRows[0].Cells[1].Value.ToString();
                dtpMSRDate.Value = Convert.ToDateTime(dgvMSRListing.SelectedRows[0].Cells[2].Value);
                dtpReceivedDate.Value = Convert.ToDateTime(dgvMSRListing.SelectedRows[0].Cells[3].Value);
                dtpRequiredDate.Value = Convert.ToDateTime(dgvMSRListing.SelectedRows[0].Cells[4].Value);
                txtNosofItems.Text = dgvMSRListing.SelectedRows[0].Cells[5].Value.ToString();
                txtRequestor.Text = dgvMSRListing.SelectedRows[0].Cells[6].Value.ToString();
                txtDepartment.Text = dgvMSRListing.SelectedRows[0].Cells[7].Value.ToString();
                txtApprovedBy.Text = dgvMSRListing.SelectedRows[0].Cells[8].Value.ToString();
                cboBuyer.Text = dgvMSRListing.SelectedRows[0].Cells[9].Value.ToString();
                txtProject.Text = dgvMSRListing.SelectedRows[0].Cells[10].Value.ToString();
                txtDescription.Text = dgvMSRListing.SelectedRows[0].Cells[11].Value.ToString();
                IsEditMode = true;
            }
            catch
            { }
        }
    }
}