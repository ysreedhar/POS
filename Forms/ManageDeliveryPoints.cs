using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace POCS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ManageDeliveryPoints : System.Windows.Forms.Form
  {
    private System.Windows.Forms.Button button1;
        private GroupBox groupBox2;
        private DataGrid dgvDeliveryPoints;
        private POCS.Ds.POCSTableAdapters.DeliveryPointsTableAdapter deliveryPointsTableAdapter;
        private BindingSource deliveryPointsBindingSource;
        private POCS.Ds.POCS pOCS;
        private IContainer components;

        public ManageDeliveryPoints()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDeliveryPoints));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDeliveryPoints = new System.Windows.Forms.DataGrid();
            this.deliveryPointsTableAdapter = new POCS.Ds.POCSTableAdapters.DeliveryPointsTableAdapter();
            this.deliveryPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOCS = new POCS.Ds.POCS();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Delivery Point";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDeliveryPoints);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 311);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Available Delivery Points";
            // 
            // dgvDeliveryPoints
            // 
            this.dgvDeliveryPoints.CaptionText = "Delivery Points";
            this.dgvDeliveryPoints.DataMember = "";
            this.dgvDeliveryPoints.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDeliveryPoints.Location = new System.Drawing.Point(15, 20);
            this.dgvDeliveryPoints.Name = "dgvDeliveryPoints";
            this.dgvDeliveryPoints.Size = new System.Drawing.Size(679, 248);
            this.dgvDeliveryPoints.TabIndex = 1;
            // 
            // deliveryPointsTableAdapter
            // 
            this.deliveryPointsTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryPointsBindingSource
            // 
            this.deliveryPointsBindingSource.DataMember = "DeliveryPoints";
            this.deliveryPointsBindingSource.DataSource = this.pOCS;
            // 
            // pOCS
            // 
            this.pOCS.DataSetName = "POCS";
            this.pOCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManageDeliveryPoints
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(788, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageDeliveryPoints";
            this.Text = "Manage Delivery Points";
            this.Load += new System.EventHandler(this.ManageDeliveryPoints_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOCS)).EndInit();
            this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

    
    private void button1_Click(object sender, System.EventArgs e) {
      try {
          DpPopup dlg = new DpPopup();
        dlg.ShowDialog();
      }
      catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
    }

        private void ManageDeliveryPoints_Load(object sender, EventArgs e)
        {
            ShowRecsDataGrid();
        }
        public void ShowRecsDataGrid()
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
	}
}
