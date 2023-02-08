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
    public partial class GroupBox : UserControl
    {
        public GroupBox()
        {
            InitializeComponent();
        }

        public void SetGroupNameLabel(string i_AlbumName)
        {
           groupNameLabel.Text = i_AlbumName;
        }

        public void SetGroupPictureInPictureBox(string i_AlbumPictureURL)
        {
            groupPictureBox.LoadAsync(i_AlbumPictureURL);
        }

        public void SetGroupMembersCount(string i_MembersCount)
        {
            groupMembersLabel.Text = i_MembersCount;
        }

        public void SetGroupPrivacy(string i_GroupPrivacy)
        {
            privacyLabel.Text = i_GroupPrivacy;
        }
    }
}
