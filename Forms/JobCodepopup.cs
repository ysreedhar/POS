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
	public class JobCodePopUp : System.Windows.Forms.Form
    {
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private TextBox txtSubJobNo;
        private Label label3;
        private Label label4;
        private TextBox txtJobNoDesc;
        private TextBox txtSubNoDesc;
    
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public JobCodePopUp()
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSubJobNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobNoDesc = new System.Windows.Forms.TextBox();
            this.txtSubNoDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job No.";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(160, 72);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Add";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtJobNo
            // 
            this.txtJobNo.Location = new System.Drawing.Point(101, 12);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(77, 20);
            this.txtJobNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Job No.";
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(252, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            // 
            // txtSubJobNo
            // 
            this.txtSubJobNo.Location = new System.Drawing.Point(101, 37);
            this.txtSubJobNo.Name = "txtSubJobNo";
            this.txtSubJobNo.Size = new System.Drawing.Size(77, 20);
            this.txtSubJobNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(196, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job No. Desc.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(196, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sub Job No. Desc";
            // 
            // txtJobNoDesc
            // 
            this.txtJobNoDesc.Location = new System.Drawing.Point(295, 12);
            this.txtJobNoDesc.Name = "txtJobNoDesc";
            this.txtJobNoDesc.Size = new System.Drawing.Size(167, 20);
            this.txtJobNoDesc.TabIndex = 2;
            // 
            // txtSubNoDesc
            // 
            this.txtSubNoDesc.Location = new System.Drawing.Point(295, 38);
            this.txtSubNoDesc.Name = "txtSubNoDesc";
            this.txtSubNoDesc.Size = new System.Drawing.Size(167, 20);
            this.txtSubNoDesc.TabIndex = 4;
            // 
            // DpPopup
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(474, 120);
            this.Controls.Add(this.txtSubNoDesc);
            this.Controls.Add(this.txtSubJobNo);
            this.Controls.Add(this.txtJobNoDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJobNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DpPopup";
            this.ShowInTaskbar = false;
            this.Text = "Add New Job Code";
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
                    tblJobChargeTableAdapter dAdapter = new tblJobChargeTableAdapter();
                    dAdapter.Insert((txtJobNo.Text + "-" + txtSubJobNo.Text),txtJobNo.Text,txtSubJobNo.Text,txtJobNoDesc.Text,txtSubNoDesc.Text);
                    MessageBox.Show("New JobCode Added Successfully", Application.ProductName);
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