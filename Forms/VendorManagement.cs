using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POCS
{
    public partial class VendorManagement : Form
    {
        public VendorManagement()
        {
            InitializeComponent();
        }
        public bool IsEditMode;
        public decimal VendorID;
        private void txtVendorEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControlValues(this.Frame1);
        }
        void ClearControlValues(System.Windows.Forms.Control Container)
        {
            try
            {
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).Text = "";
                    if (ctrl.GetType() == typeof(ComboBox))
                        ((ComboBox)ctrl).SelectedIndex = -1;
                    if (ctrl.GetType() == typeof(CheckBox))
                        ((CheckBox)ctrl).Checked = false;
                    // if (ctrl.GetType() == typeof(Label))
                    //   ((Label)ctrl).Text = "";
                    if (ctrl.GetType() == typeof(DateTimePicker))
                        ((DateTimePicker)ctrl).Text = DateTime.Now.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VendorManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOS_DBDataSet.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.pOCS.Vendor);

        }
        private DataRow LastDataRow = null;
        private void UpdateRowToDatabase()
        {
            if (LastDataRow != null)
            {
                if (LastDataRow.RowState == DataRowState.Modified)
                {
                    vendorTableAdapter.Update(LastDataRow);
                }
            }
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            // if the user moves to a new row, check if the last row was changed
            BindingSource thisBindingSource = (BindingSource)sender;
            DataRow ThisDataRow = ((DataRowView)thisBindingSource.Current).Row;
            if (ThisDataRow == LastDataRow)
            {
                // we need to avoid to write a datarow to the database when it is still processed. Otherwise we get a problem
                // with the event handling of the dataTable.
                throw new ApplicationException("It seems the PositionChanged event was fired twice for the same row");
            }

            UpdateRowToDatabase();
            //track the current row for next PositionChanged event
            LastDataRow = ThisDataRow;
        }

        private void txtVendorAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                POCS.Ds.POCSTableAdapters.VendorTableAdapter tAdapter = new POCS.Ds.POCSTableAdapters.VendorTableAdapter();
                if (!IsEditMode)
                {

                    if (IsValidEntry(this.Frame1))
                    {

                        tAdapter.Insert(txtVendorFirmName.Text, txtVendorCnctPerson.Text, txtVendorAdd.Text, txtVendorPh.Text, txtVendorMob.Text, txtVendorZip.Text, txtVendorFax.Text, txtVendorEmail.Text, "1", txtVendorCity.Text, "-", txtVendorCountry.Text, TxtRegNo.Text, dtpRegDate.Value, txtVendorCode.Text, chkAVL.Checked, 45);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter all Required Vendor Detail Entries", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    tAdapter.UpdateVendorDetails(txtVendorFirmName.Text, txtVendorCnctPerson.Text, txtVendorAdd.Text, txtVendorPh.Text, txtVendorMob.Text, txtVendorZip.Text, txtVendorFax.Text, txtVendorEmail.Text, "1", txtVendorCity.Text, "-", txtVendorCountry.Text, TxtRegNo.Text, dtpRegDate.Value, txtVendorCode.Text, chkAVL.Checked, 45, VendorID);
                    vendorTableAdapter.Update(this.pOCS.Vendor);
                    
                    dgvVendors.Refresh();
                    MessageBox.Show("Vendor Information Updated Succesfully", Application.ProductName, MessageBoxButtons.OK);
                }
            }
            catch { }
        }
        private bool IsValidEntry(System.Windows.Forms.Control Container)
        {
            bool blValid = true;
            foreach (Control ctrl in Container.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    if (string.IsNullOrEmpty(((TextBox)ctrl).Text))
                        blValid = false;


            }
            return blValid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            UpdateRowToDatabase();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            try
            {
                //UpdateRowToDatabase();
                vendorTableAdapter.Update(this.pOCS.Vendor);
                MessageBox.Show("Vendor Information Updated Succesfully", Application.ProductName, MessageBoxButtons.OK);
                
                foreach (DataGridViewRow theRow in dgvVendors.Rows)
                {
                    if(theRow.DefaultCellStyle.BackColor == Color.Red)
                    theRow.DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch
            { }

        }

        private void vendorBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // if the user moves to a new row, check if the last row was changed
            BindingSource thisBindingSource = (BindingSource)sender;
            DataRow ThisDataRow = ((DataRowView)thisBindingSource.Current).Row;
            if (ThisDataRow == LastDataRow)
            {
                // we need to avoid to write a datarow to the database when it is still processed. Otherwise we get a problem
                // with the event handling of the dataTable.
                throw new ApplicationException("It seems the PositionChanged event was fired twice for the same row");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && colIndex >= 0)
            {
                DataGridViewRow theRow = dgvVendors.Rows[rowIndex];
                    theRow.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtVendorId_TextChanged(object sender, EventArgs e)
        {
            POCS.Ds.POCSTableAdapters.VendorTableAdapter dAdapter = new POCS.Ds.POCSTableAdapters.VendorTableAdapter();
           txtVendorFirmName.Text = dAdapter.GetDataByVendorID(Decimal.Parse(txtVendorId.Text)).v_nameColumn.Table.Columns[0].ToString();
           
        }

        private void btnShowEditDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = this.dgvVendors.CurrentRow;
            txtVendorId.Text = dt.Cells[0].Value.ToString();
            txtVendorFirmName.Focus();
        }

        private void cmdPrintListing_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dgvVendors);
        }

        private void dgvVendors_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // tabControl1.SelectedIndex[0];
           // LoadVendorData(e.RowIndex);
        }
        void LoadVendorData(int Rindex)
        {
           // dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
           // txtVendorFirmName.Text, txtVendorCnctPerson.Text, txtVendorAdd.Text, txtVendorPh.Text, txtVendorMob.Text, txtVendorZip.Text, txtVendorFax.Text, txtVendorEmail.Text, "1", txtVendorCity.Text,"-", txtVendorCountry.Text, TxtRegNo.Text, dtpRegDate.Value, txtVendorCode.Text, 
           // chkAVL.Checked
 
        }

        private void dgvVendors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtVendorFirmName.Text = dgvVendors.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtRegNo.Text = dgvVendors.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtVendorAdd.Text = dgvVendors.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtVendorCity.Text = dgvVendors.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtVendorCountry.Text = dgvVendors.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtVendorZip.Text = dgvVendors.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtVendorPh.Text = dgvVendors.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtVendorMob.Text = dgvVendors.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtVendorFax.Text = dgvVendors.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtVendorCnctPerson.Text = dgvVendors.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtVendorEmail.Text = dgvVendors.Rows[e.RowIndex].Cells[8].Value.ToString();
                dtpRegDate.Text = dgvVendors.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtVendorCode.Text = dgvVendors.Rows[e.RowIndex].Cells[13].Value.ToString();
                chkAVL.Checked = Convert.ToBoolean(dgvVendors.Rows[e.RowIndex].Cells[15].Value);
                btnSave.Text = "Save Changes";
                btnReset.Text = "Discard Changes";
                IsEditMode = true;
                VendorID = Convert.ToDecimal(dgvVendors.Rows[e.RowIndex].Cells[0].Value);
            }
            catch { }
        }
    }
}