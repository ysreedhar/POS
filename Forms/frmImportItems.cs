using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;

namespace POCS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmImportItems :KryptonForm
    {
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtExcelSheetName;
		private System.Windows.Forms.Button CmdReset;
		private System.Windows.Forms.Button CmdPreview;
		private System.Windows.Forms.Button CmdBrowse;
        private System.ComponentModel.IContainer components;
        private DataGridView dgvImportData;
		
		public DataTable table;
        public frmImportItems()
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportItems));
            this.label4 = new System.Windows.Forms.Label();
            this.txtExcelSheetName = new System.Windows.Forms.TextBox();
            this.CmdPreview = new System.Windows.Forms.Button();
            this.CmdReset = new System.Windows.Forms.Button();
            this.CmdBrowse = new System.Windows.Forms.Button();
            this.dgvImportData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Excel Sheet:";
            // 
            // txtExcelSheetName
            // 
            this.txtExcelSheetName.Enabled = false;
            this.txtExcelSheetName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcelSheetName.Location = new System.Drawing.Point(85, 11);
            this.txtExcelSheetName.Name = "txtExcelSheetName";
            this.txtExcelSheetName.Size = new System.Drawing.Size(152, 21);
            this.txtExcelSheetName.TabIndex = 7;
            this.txtExcelSheetName.TextChanged += new System.EventHandler(this.txtExcelSheetName_TextChanged);
            // 
            // CmdPreview
            // 
            this.CmdPreview.Enabled = false;
            this.CmdPreview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPreview.Location = new System.Drawing.Point(313, 9);
            this.CmdPreview.Name = "CmdPreview";
            this.CmdPreview.Size = new System.Drawing.Size(104, 24);
            this.CmdPreview.TabIndex = 9;
            this.CmdPreview.Text = "&Preview Items";
            this.CmdPreview.Click += new System.EventHandler(this.CmdPreview_Click);
            // 
            // CmdReset
            // 
            this.CmdReset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdReset.Location = new System.Drawing.Point(423, 9);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(88, 24);
            this.CmdReset.TabIndex = 10;
            this.CmdReset.Text = "&Reset Fields";
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // CmdBrowse
            // 
            this.CmdBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdBrowse.Location = new System.Drawing.Point(243, 9);
            this.CmdBrowse.Name = "CmdBrowse";
            this.CmdBrowse.Size = new System.Drawing.Size(64, 24);
            this.CmdBrowse.TabIndex = 14;
            this.CmdBrowse.Text = "&Browse...";
            this.CmdBrowse.Click += new System.EventHandler(this.CmdBrowse_Click);
            // 
            // dgvImportData
            // 
            this.dgvImportData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvImportData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportData.Location = new System.Drawing.Point(12, 39);
            this.dgvImportData.Name = "dgvImportData";
            this.dgvImportData.Size = new System.Drawing.Size(700, 416);
            this.dgvImportData.TabIndex = 15;
            // 
            // frmImportItems
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(724, 467);
            this.Controls.Add(this.dgvImportData);
            this.Controls.Add(this.CmdBrowse);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.CmdPreview);
            this.Controls.Add(this.txtExcelSheetName);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportItems";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Items from Excel Template";
            this.Load += new System.EventHandler(this.FrmImportWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		

		private void CmdBrowse_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fdlg = new OpenFileDialog(); 
			fdlg.Title = "Choose the Excel File to Import from..." ; 
			fdlg.InitialDirectory = @"c:\" ; 
			fdlg.Filter = "Excel files (*.xls)|*.xls" ; 
			fdlg.FilterIndex = 2 ; 
			fdlg.RestoreDirectory = true ; 
			if(fdlg.ShowDialog() == DialogResult.OK) 
			{ 
				txtExcelSheetName.Text = fdlg.FileName ; 
				
			} 
		}
        public delegate void PassControl(object sender);

        public PassControl passControl;
        public DataView getDataSet()
        {
            DataView _newDV = (DataView)dgvImportData.DataSource;
            return _newDV;
        }
		private void ClearControls()
		{
		
			txtExcelSheetName.Text="";
		}
		private void CmdReset_Click(object sender, System.EventArgs e)
		{
			ClearControls();
		}
		protected string vExcelPath;

		
		private void CmdPreview_Click(object sender, System.EventArgs e)
		{
			//************Preview Data
			if (CmdPreview.Text.ToString() == "&Preview Data") 
			{
				try
				{
					vExcelPath=txtExcelSheetName.Text.ToString();
					BindData();
					
				}
				catch(Exception exp)
				{
					MessageBox.Show ("Error Occured : " + exp, "Import Wizard",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
				//****************Import Data
			else if (CmdPreview.Text.ToString() == "&Import Data") 
			{
				try
				{
					funcPostData();
					
				}
				catch(Exception exp)
				{
					MessageBox.Show ("Error Occured : " + exp, "Import Wizard",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}

			}
		}

        void funcPostData()
        {
            if (passControl != null)
            {
                passControl((DataTable)dgvImportData.DataSource);
            }
        }
		private System.Data.DataTable GetData()
		{
			string  connectionStringForExcel  = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ vExcelPath + ";Extended Properties=\"Excel 8.0;HDR=YES\"";
			OleDbConnection conn= new OleDbConnection(connectionStringForExcel);
			OleDbDataAdapter adapter= new OleDbDataAdapter(" SELECT  * FROM [Sheet1$]",conn);
			DataSet myDataSet= new DataSet();
			try
			{
				adapter.Fill(myDataSet,"Sheet1");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
			return myDataSet.Tables[0];
			
		}
		private void BindData()
		{
			try
			{
				table=GetData();
				dgvImportData.DataSource	= table.DataSet.Tables["Sheet1"];
				CmdPreview.Text= "&Import Data";
				
			}
			catch (Exception exp)
			{
				MessageBox.Show ("Error Occured : " + exp, "Import Wizard",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{
			
			}
			
		}

		private void txtExcelSheetName_TextChanged(object sender, System.EventArgs e)
		{
			if (txtExcelSheetName.Text!="")
				CmdPreview.Enabled= true;
			else
				CmdPreview.Enabled= false;
				CmdPreview.Text= "&Preview Data";
		}

		#region ToolTip Implementation

		// Checks mouse position to see if it is over a discontinued row, 
		//        or reorder row. If so, set the tiptext and reset the tooltip.
		private void dgrdImportData_KeyUp(object sender, KeyEventArgs e)
		{
			//DataGrid.HitTestInfo hti = this.dgvImportData.HitTest(new Point(e.X, e.Y));
			//BindingManagerBase bmb = this.BindingContext[this.dgvImportData.DataSource, this.dgvImportData.DataMember];
			
			
		}
		#endregion

        private void FrmImportWizard_Load(object sender, EventArgs e)
        {

        }
		

		
	}
		

	}


