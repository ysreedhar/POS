using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POCS
{
    public partial class FrmOrdersSummary : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public FrmOrdersSummary()
        {
            InitializeComponent();
        }

        private void FrmOrdersSummary_Load(object sender, EventArgs e)
        {
            dtpStartingDate.Text = DateTime.Now.ToString();
            nudNoWeeks.Value = 4;
        }
        void RetriveData()
        {
            this.dgvOrdersSummary.Columns.Clear();
            // retrieve the data
            DataSet ds = clsDynamicOrdersPOP.DynamicCategorySalesByWeek(Convert.ToDateTime(dtpStartingDate.Text), Convert.ToInt32(nudNoWeeks.Value));

            // our datagrid has AutoGenerateColumns set to False; we'll
            // add columns here so we can specify column formatting along the way
            /* foreach (DataColumn c in ds.Tables[0].Columns)
             {
                 DataGridViewColumn bc = new DataGridViewColumn();
                 bc.HeaderText = c.ColumnName.Replace("Week of ", "Week of ");
                 bc.DataPropertyName = c.ColumnName;
                 //bc.CellType = 
                 DataGridViewCell cell = new DataGridViewTextBoxCell();
                 bc.CellTemplate = cell;
                 if (c.DataType != typeof(System.String))
                 {
                     bc.DefaultCellStyle.Format = "{0:#,##0.00}";
                     //  bc.DefaultCellStyle.Alignment = DefaultCellStyle.Right;
                     //  bc.DefaultCellStyle.HorizontalAlign = DefaultCellStyle.Center;
                 }
                 // Populate a new data table and bind it to the BindingSource.
                 dgvOrdersSummary.Columns.Add(bc);
             }*/


            // bind the data
            dgvOrdersSummary.DataSource = ds.Tables[0];
            //  dgvOrdersSummary.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.dgvOrdersSummary.Columns[1].ValueType = typeof(System.Double);
            this.dgvOrdersSummary.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvOrdersSummary.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            this.dgvOrdersSummary.Columns[0].Width = 400;



        }
        void dgvOrdersSummary_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 && e.RowIndex > -1 && e.RowIndex != this.dgvOrdersSummary.NewRowIndex)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                if (this.dgvOrdersSummary[e.ColumnIndex, e.RowIndex].Selected)
                {

                    e.PaintBackground(e.CellBounds, true);

                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.White, e.CellBounds);

                }

                else
                {

                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), e.CellBounds);

                }

                this.dgvOrdersSummary.Rows[e.RowIndex].Height = 80;

                e.Handled = true;

            }


        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Worksheet files|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = clsDynamicOrdersPOP.DynamicCategorySalesByWeek(Convert.ToDateTime(dtpStartingDate.Text), Convert.ToInt32(nudNoWeeks.Value));
                POCS.clsExportToExcel exportObj = new clsExportToExcel();
                exportObj.ExportToExcel(saveFileDialog1.FileName, ds);
            }
        }
        private void btnGetSummary_Click(object sender, EventArgs e)
        {
            RetriveData();
            if (dgvOrdersSummary.RowCount > 1)
            {
                btnExportExcel.Visible = true;
            }
            else
            {
                btnExportExcel.Visible = false;
            }
        }

    }
}