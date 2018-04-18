using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace POCS
{
	public class IssuePO : POCS.UI.WizardSheet
	{
		private System.ComponentModel.IContainer components = null;

		public IssuePO()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.Pages.Add(new WelcomePage());
			this.Pages.Add(new MiddlePage());
			this.Pages.Add(new CompletePage());
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuePO));
            this.SuspendLayout();
            // 
            // IssuePO
            // 
            //this.AcceptButton = this.nextButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IssuePO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purchase Order Entry";
            this.Load += new System.EventHandler(this.IssuePO_Load);
            this.ResumeLayout(false);

		}
		#endregion

        private void IssuePO_Load(object sender, EventArgs e)
        {
            this.Top = 10;
            this.Left = 10;
        }

	}
}

