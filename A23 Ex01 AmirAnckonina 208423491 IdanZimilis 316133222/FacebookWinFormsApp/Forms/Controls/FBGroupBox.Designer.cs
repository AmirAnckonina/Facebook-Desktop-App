
namespace FacebookWinFormsApp.Forms.Controls
{
    partial class FBGroupBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupMembersLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.privacyLabel = new System.Windows.Forms.Label();
            this.groupPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupNameLabel.Location = new System.Drawing.Point(88, 11);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(23, 16);
            this.groupNameLabel.TabIndex = 1;
            this.groupNameLabel.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Members";
            // 
            // groupMembersLabel
            // 
            this.groupMembersLabel.AutoSize = true;
            this.groupMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupMembersLabel.Location = new System.Drawing.Point(88, 40);
            this.groupMembersLabel.Name = "groupMembersLabel";
            this.groupMembersLabel.Size = new System.Drawing.Size(23, 16);
            this.groupMembersLabel.TabIndex = 3;
            this.groupMembersLabel.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Privacy";
            // 
            // privacyLabel
            // 
            this.privacyLabel.AutoSize = true;
            this.privacyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.privacyLabel.Location = new System.Drawing.Point(88, 67);
            this.privacyLabel.Name = "privacyLabel";
            this.privacyLabel.Size = new System.Drawing.Size(23, 16);
            this.privacyLabel.TabIndex = 5;
            this.privacyLabel.Text = "---";
            // 
            // groupPictureBox
            // 
            this.groupPictureBox.Location = new System.Drawing.Point(77, 92);
            this.groupPictureBox.Name = "groupPictureBox";
            this.groupPictureBox.Size = new System.Drawing.Size(111, 73);
            this.groupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupPictureBox.TabIndex = 6;
            this.groupPictureBox.TabStop = false;
            // 
            // FBGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.groupPictureBox);
            this.Controls.Add(this.privacyLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupMembersLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "FBGroupBox";
            this.Size = new System.Drawing.Size(191, 168);
            ((System.ComponentModel.ISupportInitialize)(this.groupPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label groupMembersLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label privacyLabel;
        private System.Windows.Forms.PictureBox groupPictureBox;
    }
}
