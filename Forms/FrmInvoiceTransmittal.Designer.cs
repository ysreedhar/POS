namespace POCS
{
    partial class FrmInvoiceTransmittal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceTransmittal));
            this.txtTransmitToDept = new System.Windows.Forms.TextBox();
            this.lstInvoiceNos = new System.Windows.Forms.CheckedListBox();
            this.txtTransmitToName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnPageSetup = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTransmitToDept
            // 
            this.txtTransmitToDept.AcceptsReturn = true;
            this.txtTransmitToDept.BackColor = System.Drawing.SystemColors.Window;
            this.txtTransmitToDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransmitToDept.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransmitToDept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransmitToDept.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTransmitToDept.Location = new System.Drawing.Point(129, 66);
            this.txtTransmitToDept.MaxLength = 0;
            this.txtTransmitToDept.Name = "txtTransmitToDept";
            this.txtTransmitToDept.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTransmitToDept.Size = new System.Drawing.Size(305, 21);
            this.txtTransmitToDept.TabIndex = 14;
            // 
            // lstInvoiceNos
            // 
            this.lstInvoiceNos.BackColor = System.Drawing.Color.White;
            this.lstInvoiceNos.CheckOnClick = true;
            this.lstInvoiceNos.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstInvoiceNos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvoiceNos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstInvoiceNos.Location = new System.Drawing.Point(129, 98);
            this.lstInvoiceNos.Name = "lstInvoiceNos";
            this.lstInvoiceNos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstInvoiceNos.Size = new System.Drawing.Size(508, 79);
            this.lstInvoiceNos.TabIndex = 13;
            // 
            // txtTransmitToName
            // 
            this.txtTransmitToName.AcceptsReturn = true;
            this.txtTransmitToName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTransmitToName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransmitToName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransmitToName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransmitToName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTransmitToName.Location = new System.Drawing.Point(129, 34);
            this.txtTransmitToName.MaxLength = 0;
            this.txtTransmitToName.Name = "txtTransmitToName";
            this.txtTransmitToName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTransmitToName.Size = new System.Drawing.Size(305, 21);
            this.txtTransmitToName.TabIndex = 11;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(25, 42);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(34, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(25, 70);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(64, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Department";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(25, 106);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(67, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Invoice Nos.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(25, 18);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(65, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Transmit to:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(129, 246);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(786, 337);
            this.webBrowser1.TabIndex = 17;
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageSetup.Location = new System.Drawing.Point(402, 202);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(75, 23);
            this.btnPageSetup.TabIndex = 21;
            this.btnPageSetup.Text = "Page &Setup";
            this.btnPageSetup.UseVisualStyleBackColor = true;
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(210, 202);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Location = new System.Drawing.Point(291, 202);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(105, 23);
            this.btnPrintPreview.TabIndex = 19;
            this.btnPrintPreview.Text = "Print Pr&eview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(129, 203);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 18;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // FrmInvoiceTransmittal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 595);
            this.Controls.Add(this.btnPageSetup);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtTransmitToDept);
            this.Controls.Add(this.lstInvoiceNos);
            this.Controls.Add(this.txtTransmitToName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInvoiceTransmittal";
            this.Text = "Invoice Transmittal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInvoiceTransmittal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTransmitToDept;
        public System.Windows.Forms.CheckedListBox lstInvoiceNos;
        public System.Windows.Forms.TextBox txtTransmitToName;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnPageSetup;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnView;
    }
}