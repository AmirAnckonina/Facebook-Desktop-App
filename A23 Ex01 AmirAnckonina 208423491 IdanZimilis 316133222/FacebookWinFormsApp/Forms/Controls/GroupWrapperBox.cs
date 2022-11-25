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
    public partial class GroupWrapperBox : UserControl
    {

        public GroupWrapperBox()
        {
            InitializeComponent();
        }

        public void setName(string i_AlbumName)
        {
            groupNameLabel.Text = i_AlbumName;
        }

        public void setPictureBox(string i_albumPictureURL)
        {
            groupPictureBox.LoadAsync(i_albumPictureURL);
        }

    }
}
