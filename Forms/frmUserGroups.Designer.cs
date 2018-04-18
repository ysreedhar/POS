namespace POCS.Forms
{
    partial class frmUserGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserGroups));
            this.clbUsers = new System.Windows.Forms.CheckedListBox();
            this.btnModifyGroup = new System.Windows.Forms.Button();
            this.clbUsersGroup = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbUsers
            // 
            this.clbUsers.CheckOnClick = true;
            this.clbUsers.FormattingEnabled = true;
            this.clbUsers.Location = new System.Drawing.Point(19, 36);
            this.clbUsers.Name = "clbUsers";
            this.clbUsers.Size = new System.Drawing.Size(284, 340);
            this.clbUsers.TabIndex = 0;
            // 
            // btnModifyGroup
            // 
            this.btnModifyGroup.Location = new System.Drawing.Point(518, 7);
            this.btnModifyGroup.Name = "btnModifyGroup";
            this.btnModifyGroup.Size = new System.Drawing.Size(75, 23);
            this.btnModifyGroup.TabIndex = 2;
            this.btnModifyGroup.Text = "Group";
            this.btnModifyGroup.UseVisualStyleBackColor = true;
            this.btnModifyGroup.Click += new System.EventHandler(this.btnGrantPermissions_Click);
            // 
            // clbUsersGroup
            // 
            this.clbUsersGroup.CheckOnClick = true;
            this.clbUsersGroup.FormattingEnabled = true;
            this.clbUsersGroup.Location = new System.Drawing.Point(309, 36);
            this.clbUsersGroup.Name = "clbUsersGroup";
            this.clbUsersGroup.Size = new System.Drawing.Size(284, 340);
            this.clbUsersGroup.TabIndex = 1;
            // 
            // frmUserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 390);
            this.Controls.Add(this.btnModifyGroup);
            this.Controls.Add(this.clbUsersGroup);
            this.Controls.Add(this.clbUsers);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserGroups";
            this.Text = "Create and Maintain User Groups";
            this.Load += new System.EventHandler(this.frmCreateTrusting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbUsers;
        private System.Windows.Forms.Button btnModifyGroup;
        private System.Windows.Forms.CheckedListBox clbUsersGroup;
    }
}