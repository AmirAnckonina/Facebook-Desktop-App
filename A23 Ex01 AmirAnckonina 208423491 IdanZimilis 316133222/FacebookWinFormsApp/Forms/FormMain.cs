using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FBServiceLogic;
using FBServiceLogic.DTOs;
using FacebookWinFormsApp.Forms.Controls;


namespace FacebookWinFormsApp
{
    public partial class FormMain : Form
    {
        private FormLogin m_FormLogin;
        private readonly FBAPIClient r_FBAPIClient;
        //private AlbumsForm m_AlbumsForm;

        public FormMain(FBAPIClient i_FBAPIClient)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_FBAPIClient = i_FBAPIClient;
            m_FormLogin = new FormLogin(r_FBAPIClient);
            //m_AlbumsForm = new AlbumsForm();
            //m_AppSettings = AppSettings.LoadFromFile();
        }

        public void FetchUserInfo()
        {
            UserBasicInfoDTO userBasicInfoDTO = r_FBAPIClient.GetUserBasicInfoDTO();
            testBoxLoggedInUser.Text = $"Logged in as {r_FBAPIClient.CurrentUser.Name}";
            profilePictureBox.LoadAsync(userBasicInfoDTO.ProfilePictureURL);
            genderLabel.Text = userBasicInfoDTO.Gender;
            birthdayLabel.Text = userBasicInfoDTO.Birthday;
            aboutLabel.Text = userBasicInfoDTO.About;
            statusLabel.Text = userBasicInfoDTO.OnlineStatus;
            homeTownLabel.Text = userBasicInfoDTO.Hometown;
            FetchAlbums(r_FBAPIClient.GetAlbumsList());
            FetchGroups(r_FBAPIClient.GetGroupsNamesList());


            /*if (m_FBAPIClient.LoggedInUser.Posts.Count > 0)
            {
              //textBoxStatus.Text = m_FBAPIClient.LoggedInUser.Posts[0].Message;
            }*/
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_FBAPIClient.Logout();
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FetchUserInfo();
        }

        private void fetchAlbumsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMeCheckBox.Checked)
            {
                r_FBAPIClient.AppSettings.RememberUserActivated = true;
            }

            else
            {
                r_FBAPIClient.AppSettings.RememberUserActivated = false;
            } 
        }

        private void searchPostsByDateButton_Click(object sender, EventArgs e)
        {
            foreach (PostDTO post in r_FBAPIClient.GetPostsByDate(dateTimePicker1.Value))
            {
                postsByDateListBox.Items.Add(post.Message);
            }

        }

        internal void FetchAlbums(List<TextAndImageDTO> albumDTOs)
        {
            foreach (TextAndImageDTO albumDTO in albumDTOs)
            {
                AlbumBox album = new AlbumBox();
                album.setName(albumDTO.Name);
                album.setPictureBox(albumDTO.PictureURL);

                albumsLayoutPanel.Controls.Add(album);
            }
        }
    }
}
