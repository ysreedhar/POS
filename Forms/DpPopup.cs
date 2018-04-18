using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using POCS.Ds.POCSTableAdapters;

namespace POCS
{
	/// <summary>
	/// Summary description for DpPopup.
	/// </summary>
	public class DpPopup : System.Windows.Forms.Form
  {
    private System.Windows.Forms.TextBox txtDpAddress;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public DpPopup()
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
				if(components != null)
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
            this.txtDpAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDpAddress
            // 
            this.txtDpAddress.AcceptsReturn = true;
            this.txtDpAddress.Location = new System.Drawing.Point(101, 37);
            this.txtDpAddress.Multiline = true;
            this.txtDpAddress.Name = "txtDpAddress";
            this.txtDpAddress.Size = new System.Drawing.Size(167, 94);
            this.txtDpAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(103, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDpName
            // 
            this.txtDpName.Location = new System.Drawing.Point(101, 12);
            this.txtDpName.Name = "txtDpName";
            this.txtDpName.Size = new System.Drawing.Size(167, 20);
            this.txtDpName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(195, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            // 
            // DpPopup
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(294, 188);
            this.Controls.Add(this.txtDpAddress);
            this.Controls.Add(this.txtDpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DpPopup";
            this.ShowInTaskbar = false;
            this.Text = "Add New Delivery Point";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
#endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidEntry())
            {
                try
                {
                    DeliveryPointsTableAdapter dAdapter = new DeliveryPointsTableAdapter();
                    dAdapter.Insert(txtDpName.Text, txtDpAddress.Text);
                    MessageBox.Show("New Delivery Point Added Successfully", Application.ProductName);
                }
                catch
                { }
            }
        }
        bool IsValidEntry()
        {

            return true;
        }

	}
}