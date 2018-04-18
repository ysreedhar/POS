namespace POCS
{
    partial class FrmOrdersSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdersSummary));
            this.btnGetSummary = new System.Windows.Forms.Button();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.nudNoWeeks = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrdersSummary = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetSummary
            // 
            this.btnGetSummary.Location = new System.Drawing.Point(362, 41);
            this.btnGetSummary.Name = "btnGetSummary";
            this.btnGetSummary.Size = new System.Drawing.Size(116, 23);
            this.btnGetSummary.TabIndex = 0;
            this.btnGetSummary.Text = "Get Summary";
            this.btnGetSummary.UseVisualStyleBackColor = true;
            this.btnGetSummary.Click += new System.EventHandler(this.btnGetSummary_Click);
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartingDate.Location = new System.Drawing.Point(109, 42);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(89, 21);
            this.dtpStartingDate.TabIndex = 1;
            // 
            // nudNoWeeks
            // 
            this.nudNoWeeks.Location = new System.Drawing.Point(296, 43);
            this.nudNoWeeks.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudNoWeeks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoWeeks.Name = "nudNoWeeks";
            this.nudNoWeeks.Size = new System.Drawing.Size(34, 21);
            this.nudNoWeeks.TabIndex = 2;
            this.nudNoWeeks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Starting Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. of Weeks";
            // 
            // dgvOrdersSummary
            // 
            this.dgvOrdersSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvOrdersSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersSummary.Location = new System.Drawing.Point(35, 82);
            this.dgvOrdersSummary.Name = "dgvOrdersSummary";
            this.dgvOrdersSummary.Size = new System.Drawing.Size(871, 455);
            this.dgvOrdersSummary.TabIndex = 5;
            this.dgvOrdersSummary.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvOrdersSummary_CellPainting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Information on Purchases for the Period Range in terms of Value in RM";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(484, 41);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(116, 23);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export To Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Visible = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // FrmOrdersSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOrdersSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNoWeeks);
            this.Controls.Add(this.dtpStartingDate);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnGetSummary);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrdersSummary";
            this.Text = "Orders Summary Period on Period";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOrdersSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNoWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSummary;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.NumericUpDown nudNoWeeks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOrdersSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}