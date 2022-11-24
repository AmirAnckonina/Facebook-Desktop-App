
namespace FacebookWinFormsApp
{
    partial class AlbumsForm
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
            this.albumsLabel = new System.Windows.Forms.Label();
            this.albumsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // albumsLabel
            // 
            this.albumsLabel.AutoSize = true;
            this.albumsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.albumsLabel.Location = new System.Drawing.Point(387, 26);
            this.albumsLabel.Name = "albumsLabel";
            this.albumsLabel.Size = new System.Drawing.Size(74, 24);
            this.albumsLabel.TabIndex = 0;
            this.albumsLabel.Text = "Albums";
            // 
            // albumsFlowLayoutPanel
            // 
            this.albumsFlowLayoutPanel.AutoScroll = true;
            this.albumsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.albumsFlowLayoutPanel.Location = new System.Drawing.Point(12, 53);
            this.albumsFlowLayoutPanel.Name = "albumsFlowLayoutPanel";
            this.albumsFlowLayoutPanel.Size = new System.Drawing.Size(823, 396);
            this.albumsFlowLayoutPanel.TabIndex = 1;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 487);
            this.Controls.Add(this.albumsFlowLayoutPanel);
            this.Controls.Add(this.albumsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlbumsForm";
            this.Text = "FriendsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label albumsLabel;
        private System.Windows.Forms.FlowLayoutPanel albumsFlowLayoutPanel;
    }
}