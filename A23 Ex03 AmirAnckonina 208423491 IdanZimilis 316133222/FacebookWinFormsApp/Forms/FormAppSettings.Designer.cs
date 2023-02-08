namespace FacebookWinFormsApp
{
    public partial class FormAppSettings
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
            this.comboAppID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPermissionToAdd = new System.Windows.Forms.TextBox();
            this.buttonAddPermission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboAppID
            // 
            this.comboAppID.Items.AddRange(new object[] {
            "3456972604533289",
            "1450160541956417"});
            this.comboAppID.Location = new System.Drawing.Point(80, 8);
            this.comboAppID.Margin = new System.Windows.Forms.Padding(4);
            this.comboAppID.Name = "comboAppID";
            this.comboAppID.Size = new System.Drawing.Size(203, 24);
            this.comboAppID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "APP ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Permissions:";
            // 
            // listBoxPermissions
            // 
            this.listBoxPermissions.CheckOnClick = true;
            this.listBoxPermissions.FormattingEnabled = true;
            this.listBoxPermissions.Items.AddRange(new object[] {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"});
            this.listBoxPermissions.Location = new System.Drawing.Point(19, 77);
            this.listBoxPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPermissions.Name = "listBoxPermissions";
            this.listBoxPermissions.Size = new System.Drawing.Size(400, 346);
            this.listBoxPermissions.Sorted = true;
            this.listBoxPermissions.TabIndex = 8;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(324, 479);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(95, 35);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPermissionToAdd
            // 
            this.textBoxPermissionToAdd.Location = new System.Drawing.Point(19, 447);
            this.textBoxPermissionToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissionToAdd.Name = "textBoxPermissionToAdd";
            this.textBoxPermissionToAdd.Size = new System.Drawing.Size(210, 23);
            this.textBoxPermissionToAdd.TabIndex = 12;
            // 
            // buttonAddPermission
            // 
            this.buttonAddPermission.Location = new System.Drawing.Point(236, 447);
            this.buttonAddPermission.Name = "buttonAddPermission";
            this.buttonAddPermission.Size = new System.Drawing.Size(183, 26);
            this.buttonAddPermission.TabIndex = 13;
            this.buttonAddPermission.Text = "Add Permission";
            this.buttonAddPermission.UseVisualStyleBackColor = true;
            this.buttonAddPermission.Click += new System.EventHandler(this.buttonAddPermission_Click);
            // 
            // FormAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 526);
            this.Controls.Add(this.buttonAddPermission);
            this.Controls.Add(this.textBoxPermissionToAdd);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.listBoxPermissions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAppID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FormAppSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApplicationSettings";
            this.Load += new System.EventHandler(this.FormAppSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAppID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listBoxPermissions;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxPermissionToAdd;
        private System.Windows.Forms.Button buttonAddPermission;
    }
}