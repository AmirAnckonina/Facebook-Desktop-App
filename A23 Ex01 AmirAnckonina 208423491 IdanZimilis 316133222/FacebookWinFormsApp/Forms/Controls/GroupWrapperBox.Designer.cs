
namespace FacebookWinFormsApp.Forms.Controls
{
    partial class GroupWrapperBox
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
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.groupPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupNameLabel.Location = new System.Drawing.Point(167, 24);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(28, 24);
            this.groupNameLabel.TabIndex = 0;
            this.groupNameLabel.Text = "---";
            // 
            // groupPictureBox
            // 
            this.groupPictureBox.Location = new System.Drawing.Point(32, 62);
            this.groupPictureBox.Name = "groupPictureBox";
            this.groupPictureBox.Size = new System.Drawing.Size(302, 192);
            this.groupPictureBox.TabIndex = 1;
            this.groupPictureBox.TabStop = false;
            // 
            // GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPictureBox);
            this.Controls.Add(this.groupNameLabel);
            this.Name = "GroupBox";
            this.Size = new System.Drawing.Size(360, 281);
            ((System.ComponentModel.ISupportInitialize)(this.groupPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.PictureBox groupPictureBox;
    }
}
