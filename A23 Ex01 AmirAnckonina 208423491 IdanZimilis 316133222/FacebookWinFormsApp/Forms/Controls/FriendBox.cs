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
    public partial class FriendBox : UserControl
    { 
        public FriendBox()
        {
            InitializeComponent();
        }

        public void SetFriendName(string i_FriendName)
        {
            nameLabel.Text = i_FriendName;
        }

        public void SetPictureBox(string i_FriendPictureURL)
        {
            friendPictureBox.LoadAsync(i_FriendPictureURL);
        }

        public void SetStatus(string i_Status)
        {
            statusLabel.Text = i_Status; 
        }
    }
}
