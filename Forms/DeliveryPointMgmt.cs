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
    public partial class DeliveryPointMgmt : Form
    {
        DPDetails[] dpInfo;
        public DeliveryPointMgmt()
        {
            InitializeComponent();
        }

        private void DeliveryPointMgmt_Load(object sender, EventArgs e)
        {
            ShowAllRecords();
            BindControls();
            ShowRecsDataGrid();
            btnSave.Enabled = false;
        }
        private void ShowRecsDataGrid()
        {
            clsPOSDB dp = new clsPOSDB();
            DPDetails[] dpInfo = dp.GetAllDeliveryPoint();

            if (dpInfo != null)
            {
                dgvDeliveryPoints.DataSource = dpInfo;
                dgvDeliveryPoints.CaptionText = "Delivery Points :: Records(" + dpInfo.Length.ToString() + ")";

            }
            else
            {

                dgvDeliveryPoints.CaptionText += " :: No Records Found";
            }
        }

        private void BindControls()
        {
            this.Cursor = Cursors.WaitCursor;
            //Binding TextBox with DataSource
            txtDeliveryPointId.DataBindings.Add("Text", dpInfo, "DeliveryPointId");
            txtDeliveryPointName.DataBindings.Add("Text", dpInfo, "DeliveryPointName");
            txtDeliveryPointAddress.DataBindings.Add("Text", dpInfo, "DeliveryPointAddress");
            this.Cursor = Cursors.Default;
        }

        //UnBind the Controls from DataSource
        private void UnBindControls()
        {
            this.Cursor = Cursors.WaitCursor;
            //Binding TextBox with DataSource
            txtDeliveryPointId.DataBindings.Clear();
            txtDeliveryPointName.DataBindings.Clear();
            txtDeliveryPointAddress.DataBindings.Clear();
            this.Cursor = Cursors.Default;
        }

        //Returns Specific Record
        private void ShowRecord(int RecordId)
        {
            clsPOSDB dp = new clsPOSDB();
            DPDetails dpDetailRec = dp.GetDeliveryPoint(RecordId);
            if (dpDetailRec != null)
            {
                txtDeliveryPointId.Text = dpDetailRec.DeliveryPointId.ToString();
                txtDeliveryPointName.Text = dpDetailRec.DeliveryPointName;
                txtDeliveryPointAddress.Text = dpDetailRec.DeliveryPointAddress;
            }
            else
            {
                //FrmMain.statusBarMain.Text = "Record Not Found";
            }
        }

        //Returns All Record
        private void ShowAllRecords()
        {
            this.Cursor = Cursors.WaitCursor;
            clsPOSDB dp = new clsPOSDB();
            dpInfo = dp.GetAllDeliveryPoint();
            int recPos = this.BindingContext[dpInfo].Position;
            if (dpInfo != null)
            {
                txtDeliveryPointId.Text = dpInfo[recPos].DeliveryPointId.ToString();
                txtDeliveryPointName.Text = dpInfo[recPos].DeliveryPointName;
                txtDeliveryPointAddress.Text = dpInfo[recPos].DeliveryPointAddress;
            }
            else
            {
                //FrmMain.statusBarMain.Text = "Record Not Found";
            }
            this.Cursor = Cursors.Default;
        }

        //Move to First Record
        private void btnMoveFirst_Click(object sender, System.EventArgs e)
        {
            this.BindingContext[dpInfo].Position = 0;
        }

        //Move to First Record
        private void btnMoveLast_Click(object sender, System.EventArgs e)
        {
            this.BindingContext[dpInfo].Position = dpInfo.Length;
        }

        //Move to Previous Record
        private void btnMovePrev_Click(object sender, System.EventArgs e)
        {
            if (this.BindingContext[dpInfo].Position == 0) //First Record
            {
                this.BindingContext[dpInfo].Position = dpInfo.Length;
            }
            else
            {
                this.BindingContext[dpInfo].Position -= 1;
            }
        }

        //Move to Next Record
        private void btnMoveNext_Click(object sender, System.EventArgs e)
        {
            if (this.BindingContext[dpInfo].Position == dpInfo.Length - 1) //Last Record
            {
                this.BindingContext[dpInfo].Position = 0;
            }
            else
            {
                this.BindingContext[dpInfo].Position += 1;
            }
        }

        //Make textBox blank so that user can enter NEW data
        //And toggles the button enabled.
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            int recPos = this.BindingContext[dpInfo].Position;
            if (btnAdd.Text == "Add")
            {
                btnAdd.Text = "Cancel";
                txtDeliveryPointId.Text = "";
                txtDeliveryPointName.Text = "";
                txtDeliveryPointAddress.Text = "";
                DisableButtons();
                
                
                //FrmMain.statusBarMain.Text = "Add New Record";
            }
            else //Cancel is Clicked
            {
                btnAdd.Text = "Add";
                EnableButtons();
                //FrmMain.statusBarMain.Text = "";								
                UnBindControls();
                ShowAllRecords();
                BindControls();
            }
        }

        //Enable button on Save or Cancel Clicked
        private void EnableButtons()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnMoveFirst.Enabled = true;
            btnMoveLast.Enabled = true;
            btnMovePrev.Enabled = true;
            btnMoveNext.Enabled = true;
        }

        //Disable button on Add Clicked
        private void DisableButtons()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnMoveFirst.Enabled = false;
            btnMoveLast.Enabled = false;
            btnMovePrev.Enabled = false;
            btnMoveNext.Enabled = false;
        }

        //Insert New Record 
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            clsPOSDB dp = new clsPOSDB();
            DPDetails dpDetailRec = new DPDetails(0, txtDeliveryPointName.Text, txtDeliveryPointAddress.Text);

            EnableButtons();

            int iEmpId = dp.InsertDeliveryPoint(dpDetailRec);
            if (iEmpId != -1)
            {
                //FrmMain.statusBarMain.Text = "Record Saved Successfully";						

                //Refresh Display after addition of record and
                //Display last record inserted
                UnBindControls();
                ShowAllRecords();
                BindControls();
                this.BindingContext[dpInfo].Position = dpInfo.Length - 1;
            }
            else
            {
                //FrmMain.statusBarMain.Text = "Save Operation Failed";
            }
        }

        //Update Record
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            clsPOSDB dp = new clsPOSDB();
            DPDetails dpDetailRec = new DPDetails(Convert.ToInt32(txtDeliveryPointId.Text), txtDeliveryPointName.Text, txtDeliveryPointAddress.Text);

            int iRecAffected = dp.UpdateDeliveryPoint(dpDetailRec);
            if (iRecAffected != 0)
            {
                //FrmMain.statusBarMain.Text = "Record Updated Successfully";								
            }
            else
            {
                //FrmMain.statusBarMain.Text = "Update Operation Failed";
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            clsPOSDB dp = new clsPOSDB();

            int iRecDeleted = this.BindingContext[dpInfo].Position;
            int iRecAffected = dp.DeleteDeliveryPoint(Convert.ToInt32(txtDeliveryPointId.Text));
            if (iRecAffected != 0)
            {
                //FrmMain.statusBarMain.Text = "Record Deleted Successfully";				

                //Refresh Display after deletion of record and				
                if (dpInfo != null)
                {
                    UnBindControls();
                    ShowAllRecords();
                    BindControls();
                    if (iRecDeleted == dpInfo.Length) //If record deleted at last position thn display previous record.
                    {
                        this.BindingContext[dpInfo].Position = iRecDeleted - 1;
                    }
                    else //display next record
                    {
                        this.BindingContext[dpInfo].Position = iRecDeleted + 1;
                    }
                }
                else
                {
                    //FrmMain.statusBarMain.Text = "No Records Found";
                }
            }
            else
            {
                //FrmMain.statusBarMain.Text = "Delete Operation Failed";
            }
        }

        private void btnDispDGrid_Click(object sender, System.EventArgs e)
        {
            //frmShowAll obj = new frmShowAll();
            //obj.Show();
            ShowRecsDataGrid();
        }

    }
}