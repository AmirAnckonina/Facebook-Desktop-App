using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms.Controls
{
    public partial class AlbumBox : UserControl
    {
        public AlbumBox()
        {
            InitializeComponent();
        }

        public void SetGroupNameLabel(string i_AlbumName)
        {
            albumNameLabel.Text = i_AlbumName;
        }

        public void SetGroupPictureInPictureBox(string i_albumPictureURL)
        {
            albumPictureBox.LoadAsync(i_albumPictureURL);
        }

    }
}
