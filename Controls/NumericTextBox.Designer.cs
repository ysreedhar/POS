namespace POCS.Controls
{
    partial class NumericTextbox
    {

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Constructor is largely blank.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumeric = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumeric
            // 
            this.txtNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeric.Location = new System.Drawing.Point(0, 0);
            this.txtNumeric.Name = "txtNumeric";
            this.txtNumeric.Size = new System.Drawing.Size(100, 20);
            this.txtNumeric.TabIndex = 0;
            this.txtNumeric.Leave += new System.EventHandler(this.txtNumeric_Leave);
            this.txtNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            this.txtNumeric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeric_KeyDown);
            // 
            // NumericTextbox
            // 
            this.Controls.Add(this.txtNumeric);
            this.Name = "NumericTextbox";
            this.Size = new System.Drawing.Size(104, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
