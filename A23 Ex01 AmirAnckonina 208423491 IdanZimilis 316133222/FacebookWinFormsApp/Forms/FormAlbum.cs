using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBServiceLogic.DTOs;
using FacebookWinFormsApp.Forms.Controls;

namespace FacebookWinFormsApp
{
    public partial class AlbumsForm : Form
    {
        private AppManager m_FormsController;
        public AlbumsForm()
        {
            InitializeComponent();
        }


        internal void FetchAlbums(List<TextAndImageDTO> albumDTOs)
        {
            foreach (TextAndImageDTO albumDTO in albumDTOs)
            {
                AlbumBox album = new AlbumBox();
                album.SetGroupNameLabel(albumDTO.Name);
                album.SetGroupPictureInPictureBox(albumDTO.PictureURL);

                albumsFlowLayoutPanel.Controls.Add(album);
            }
        }
    }
}
