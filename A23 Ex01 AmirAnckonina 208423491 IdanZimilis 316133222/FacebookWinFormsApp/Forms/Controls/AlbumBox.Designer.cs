namespace FacebookWinFormsApp.Forms.Controls
{
    public partial class AlbumBox
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
            this.albumNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.albumNameLabel.Location = new System.Drawing.Point(6, 17);
            this.albumNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(23, 16);
            this.albumNameLabel.TabIndex = 0;
            this.albumNameLabel.Text = "---";
            // 
            // albumPictureBox
            // 
            this.albumPictureBox.Location = new System.Drawing.Point(9, 35);
            this.albumPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.albumPictureBox.Name = "albumPictureBox";
            this.albumPictureBox.Size = new System.Drawing.Size(182, 124);
            this.albumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumPictureBox.TabIndex = 1;
            this.albumPictureBox.TabStop = false;
            // 
            // AlbumBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.albumPictureBox);
            this.Controls.Add(this.albumNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlbumBox";
            this.Size = new System.Drawing.Size(194, 161);
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.PictureBox albumPictureBox;
    }
}
