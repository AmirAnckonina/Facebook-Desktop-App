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

    
        public void  setController(AppManager i_FormsController)
        {
            this.m_FormsController = i_FormsController;
            
        }

        internal void fetchAlbums(List<AlbumDTO> albumDTOs)
        {
            foreach (AlbumDTO albumDTO in albumDTOs)
            {
                AlbumBox album = new AlbumBox();
                album.setName(albumDTO.Name);
                album.setPictureBox(albumDTO.PictureURL);

                albumsFlowLayoutPanel.Controls.Add(album);
            }
        }
    }
}
