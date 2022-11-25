
namespace FacebookWinFormsApp.Forms.Controls
{
    partial class AlbumBox
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
            this.albumNameLabel = new System.Windows.Forms.Label();
            this.albumPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // albumNameLabel
            // 
            this.albumNameLabel.AutoSize = true;
            this.albumNameLabel.Location = new System.Drawing.Point(198, 22);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(23, 17);
            this.albumNameLabel.TabIndex = 0;
            this.albumNameLabel.Text = "---";
            // 
            // albumPictureBox
            // 
            this.albumPictureBox.Location = new System.Drawing.Point(29, 54);
            this.albumPictureBox.Name = "albumPictureBox";
            this.albumPictureBox.Size = new System.Drawing.Size(363, 223);
            this.albumPictureBox.TabIndex = 1;
            this.albumPictureBox.TabStop = false;
            // 
            // AlbumBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.albumPictureBox);
            this.Controls.Add(this.albumNameLabel);
            this.Name = "AlbumBox";
            this.Size = new System.Drawing.Size(434, 304);
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.PictureBox albumPictureBox;
    }
}
