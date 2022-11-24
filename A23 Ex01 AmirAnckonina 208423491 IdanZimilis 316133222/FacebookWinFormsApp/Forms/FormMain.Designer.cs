namespace FacebookWinFormsApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be FBAppGUId; otherwise, false.</param>
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.postLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.testBoxLoggedInUser = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.homeTownLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(912, 84);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(199, 28);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(912, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(197, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postButton.Location = new System.Drawing.Point(717, 189);
            this.postButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(135, 30);
            this.postButton.TabIndex = 53;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(12, 98);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(239, 153);
            this.profilePictureBox.TabIndex = 54;
            this.profilePictureBox.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(912, 50);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(199, 28);
            this.settingsButton.TabIndex = 55;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postLabel.Location = new System.Drawing.Point(281, 189);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(106, 24);
            this.postLabel.TabIndex = 56;
            this.postLabel.Text = "Post Status:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(393, 189);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 28);
            this.textBox1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(371, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Welcome To Facebook Desktop Application";
            // 
            // postsListBox
            // 
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 16;
            this.postsListBox.Location = new System.Drawing.Point(285, 238);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(567, 132);
            this.postsListBox.TabIndex = 59;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(27, 50);
            this.rememberMeCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(159, 28);
            this.rememberMeCheckBox.TabIndex = 60;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // testBoxLoggedInUser
            // 
            this.testBoxLoggedInUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.testBoxLoggedInUser.Location = new System.Drawing.Point(16, 20);
            this.testBoxLoggedInUser.Margin = new System.Windows.Forms.Padding(4);
            this.testBoxLoggedInUser.Name = "testBoxLoggedInUser";
            this.testBoxLoggedInUser.Size = new System.Drawing.Size(233, 22);
            this.testBoxLoggedInUser.TabIndex = 61;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.infoLabel.Location = new System.Drawing.Point(-4, 4);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(40, 24);
            this.infoLabel.TabIndex = 62;
            this.infoLabel.Text = "Info";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.aboutLabel);
            this.infoGroupBox.Controls.Add(this.statusLabel);
            this.infoGroupBox.Controls.Add(this.homeTownLabel);
            this.infoGroupBox.Controls.Add(this.birthdayLabel);
            this.infoGroupBox.Controls.Add(this.genderLabel);
            this.infoGroupBox.Controls.Add(this.label6);
            this.infoGroupBox.Controls.Add(this.label5);
            this.infoGroupBox.Controls.Add(this.label4);
            this.infoGroupBox.Controls.Add(this.label3);
            this.infoGroupBox.Controls.Add(this.label2);
            this.infoGroupBox.Controls.Add(this.infoLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.infoGroupBox.Location = new System.Drawing.Point(285, 50);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(567, 115);
            this.infoGroupBox.TabIndex = 63;
            this.infoGroupBox.TabStop = false;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(453, 42);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(27, 20);
            this.aboutLabel.TabIndex = 72;
            this.aboutLabel.Text = "---";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(305, 92);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(27, 20);
            this.statusLabel.TabIndex = 71;
            this.statusLabel.Text = "---";
            // 
            // homeTownLabel
            // 
            this.homeTownLabel.AutoSize = true;
            this.homeTownLabel.Location = new System.Drawing.Point(305, 42);
            this.homeTownLabel.Name = "homeTownLabel";
            this.homeTownLabel.Size = new System.Drawing.Size(27, 20);
            this.homeTownLabel.TabIndex = 70;
            this.homeTownLabel.Text = "---";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(90, 92);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(27, 20);
            this.birthdayLabel.TabIndex = 69;
            this.birthdayLabel.Text = "---";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(90, 48);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(27, 20);
            this.genderLabel.TabIndex = 68;
            this.genderLabel.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "About";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "HomeTown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Gender";
            // 
            // AlbumsButton
            // 
            this.AlbumsButton.Location = new System.Drawing.Point(912, 120);
            this.AlbumsButton.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumsButton.Name = "AlbumsButton";
            this.AlbumsButton.Size = new System.Drawing.Size(199, 28);
            this.AlbumsButton.TabIndex = 64;
            this.AlbumsButton.Text = "Albums";
            this.AlbumsButton.UseVisualStyleBackColor = true;
            this.AlbumsButton.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1123, 753);
            this.Controls.Add(this.AlbumsButton);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.testBoxLoggedInUser);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceBook Desktop App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.TextBox testBoxLoggedInUser;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label homeTownLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AlbumsButton;
    }
}

