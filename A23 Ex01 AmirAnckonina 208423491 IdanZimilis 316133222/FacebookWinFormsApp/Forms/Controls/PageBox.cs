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
    public partial class PageBox : UserControl
    {
        public PageBox()
        {
            InitializeComponent();
        }

        public void setName(string i_PageName)
        {
            pageNameLabel.Text = i_PageName;
        }

        public void setPictureBox(string i_PagePictureURL)
        {
            pagePictureBox.LoadAsync(i_PagePictureURL);
        }

        public void setNumOfLikes(long? i_NumOfLikes)
        {
            likesLabel.Text = i_NumOfLikes.ToString();//check if null or zero
        }
    }
}
