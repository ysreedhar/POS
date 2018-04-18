#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
#endregion

namespace RDB_test.myControls {
    public partial class employeeControl : UserControl {
        //  The current checked item.
        internal ToolStripMenuItem tsmCurrent;
        //
        //  Constructor
        //
        public employeeControl() {
            InitializeComponent();
            }
        //
        //  EmployeeControl Load
        //
        private void employeeControl_Load(object sender, EventArgs e) {
            this.peopleTableAdapter.Fill(this.myReportDataSet.People);
            }
        //
        //  PeopleBindingNavigatorSaveItem
        //
        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            //  Todo:Change the limit to PhoneLine1 and PhoneLine2 to (14).
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.peopleTableAdapter.Update(this.myReportDataSet.People);
            }
        //
        //  OpenFileDialog Clicked Ok
        //
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            this.ImportImage(this.openFileDialog1.FileName);
            }
        //
        //  ImportImage
        //
        private void ImportImage(string filename) {
            try {
                //check for boundaries before performing delete: datatable is empty, or there is no selection
                if (this.peopleBindingSource.Current != null) {
                    //convert generic Current object returned by DataConnector to the typed movie row object
                    DataRowView rowView = (DataRowView)this.peopleBindingSource.Current;
                    RDB_test.myData.myReportDataSet.PeopleRow peopleRow = (RDB_test.myData.myReportDataSet.PeopleRow)rowView.Row;

                    //open file as Readonly from file system, copy bytes, and assign to the image property of the current row
                    peopleRow.ImageBinary = File.ReadAllBytes(filename);

                    this.peopleBindingSource.ResetCurrentItem();
                    }
                }
            catch (Exception ex) {
                MessageBox.Show(String.Format("There was a problem loading the image: {0}", ex.Message));
                //Debug.WriteLine(ex.ToString());
                }
            }
        //
        //  ImportToolStripButton
        //
        private void importToolStripButton_Click(object sender, EventArgs e) {
            this.openFileDialog1.ShowDialog();
            }
        //
        //  FindToolStripButton
        //
        private void findToolStripButton_Click(object sender, EventArgs e) {
            if((this.tsmCurrent != null) || (this.firstNameTextBox.Text != null)) {
                if (this.peopleBindingSource.SupportsSearching != false) {
                    int found = this.peopleBindingSource.Find(this.tsmCurrent.Tag.ToString(), this.findToolStripTextBox.Text);
                    if ((found > -1) && this.peopleBindingSource.SupportsFiltering != false) {
                        this.peopleBindingSource.Filter = String.Format
                            ("{0}='{1}'", this.tsmCurrent.Tag, this.findToolStripTextBox.Text);
                        }
                    }
                }
            }
        //
        //  ShowAllToolStripButton
        //
        private void showAllToolStripButton_Click(object sender, EventArgs e) {
            this.peopleBindingSource.Filter = "";
            }
        //
        //  Find Buttons
        //
        private void FindButtonsClick(object sender, EventArgs e) {
            ToolStripMenuItem tsmItem = sender as ToolStripMenuItem;
            tsmItem.Checked = true;
            if (tsmCurrent != null) {
                tsmCurrent.Checked = false;
                }
            tsmCurrent = tsmItem;
            tsmItem = null;
            }
        }
    }
