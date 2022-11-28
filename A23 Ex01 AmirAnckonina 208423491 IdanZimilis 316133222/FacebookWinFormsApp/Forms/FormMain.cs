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
        private readonly FBAPIClient r_FBAPIClient;

        public FormMain(FBAPIClient i_FBAPIClient)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_FBAPIClient = i_FBAPIClient;
        }

        public void FetchUserInfo()
        {
            testBoxLoggedInUser.Text = $"Logged in as {r_FBAPIClient.CurrentUser.Name}";
            FetchBasicUserInfo();
            FetchAlbums(r_FBAPIClient.GetAlbumsList());
            FetchGroups(r_FBAPIClient.GetGroupsNamesList());
            FetchPosts(r_FBAPIClient.GetPostsList());
            FetchLikedPages(r_FBAPIClient.GetLikedPages());
           
            /*if (m_FBAPIClient.LoggedInUser.Posts.Count > 0)
            {
              //textBoxStatus.Text = m_FBAPIClient.LoggedInUser.Posts[0].Message;
            }*/
        }

        private void FetchBasicUserInfo()
        {
            UserBasicInfoDTO userBasicInfoDTO = r_FBAPIClient.GetUserBasicInfoDTO();
            profilePictureBox.LoadAsync(userBasicInfoDTO.PictureURL);
            genderLabel.Text = userBasicInfoDTO.Gender;
            birthdayLabel.Text = userBasicInfoDTO.Birthday;
            statusLabel.Text = userBasicInfoDTO.OnlineStatus;
            homeTownLabel.Text = userBasicInfoDTO.Hometown;
        }

        private void FetchLikedPages(List<LikedPageDTO> i_LikedPagesList)
        {
            foreach (LikedPageDTO pageDTO in i_LikedPagesList)
            {
                PageBox pageBox = new PageBox();
                pageBox.setName(pageDTO.Name);
                pageBox.setPictureBox(pageDTO.PictureURL);
                pageBox.setNumOfLikes(pageDTO.LikesCount);
                likedPagesFlowLayoutPanel.Controls.Add(pageBox);

            }
            likedPagesFlowLayoutPanel.AutoScroll = true;
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
                // Consider do that with Event
                r_FBAPIClient.AppSettings.LastAccessToken = r_FBAPIClient.LoginResult.AccessToken;
            }

            else
            {
                r_FBAPIClient.AppSettings.RememberUserActivated = false;
                r_FBAPIClient.AppSettings.LastAccessToken.Remove(0);
            } 
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (rememberMeCheckBox.Checked)
            {
                r_FBAPIClient.AppSettings.SaveToFile();
                r_FBAPIClient.ResetCurrentFBState();
            }

            else
            {
                r_FBAPIClient.Logout();
            }

        }

        private void searchPostsByDateButton_Click(object sender, EventArgs e)
        {
            postsByDateListBox.Items.Clear();
            foreach (PostDTO post in r_FBAPIClient.GetPostsByDate(dateTimePicker1.Value))
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    string[] postString = post.Message.Split(char.Parse("\n"));
                    foreach (string word in postString)
                    {
                        //postsByDateTextBox.Text += word + Environment.NewLine;
                        postsByDateListBox.Items.Add(word + Environment.NewLine);
                    }
                    //postsByDateTextBox.Text +=  post.Message + Environment.NewLine;
                    //postsByDateTextBox.Text += "hey\nthis is idan\nits a new text";
                    //StringBuilder sb = new StringBuilder();
                    //postsByDateListBox.Items.Add(string.Format(post.Message));
                    postsByDateListBox.Items.Add(Environment.NewLine);
                }
            }

        }

        public void FetchPosts(List<PostDTO> postsDTOList)
        {
            foreach (PostDTO post in postsDTOList)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    string[] postString = post.Message.Split(char.Parse("\n"));
                    foreach (string word in postString)
                    {
                        //postsByDateTextBox.Text += word + Environment.NewLine;
                        postsListBox.Items.Add(word + Environment.NewLine);
                    }
                    //postsByDateTextBox.Text +=  post.Message + Environment.NewLine;
                    //postsByDateTextBox.Text += "hey\nthis is idan\nits a new text";
                    //StringBuilder sb = new StringBuilder();
                    //postsByDateListBox.Items.Add(string.Format(post.Message));
                    postsByDateListBox.Items.Add(Environment.NewLine);
                }
            }
        }

        internal void FetchAlbums(List<TextAndImageDTO> albumDTOs)
        {
            foreach (TextAndImageDTO albumDTO in albumDTOs)
            {
                AlbumBox album = new AlbumBox();
                album.SetGroupNameLabel(albumDTO.Name);
                album.SetGroupPictureInPictureBox(albumDTO.PictureURL);

                albumsLayoutPanel.Controls.Add(album);
                
            }
            albumsLayoutPanel.AutoScroll = true;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tabControl = sender as TabControl;

            if (tabControl != null)
            {
                TabPage currentTab = tabControl.SelectedTab;

                switch(currentTab.Name)
                {
                    case "Home":
                        FetchUserInfo();
                        break;

                    case "Friends":
                        /// FetchFriends();
                        break;

                    case "Albums":
                        /// FetchAlbums();
                        break;

                    case "Posts":
                        /// FetchPosts();
                        break;

                    case "Liked Pages":
                        /// FetchLikedPages();
                        break;
                    case "My Alumnus":
                        ///FetchMyAlumnus();
                        break; 

                    case "Search Post":
                        /// ?
                        break;

                    default:
                        break;
                       
                }
               
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            FetchFriends();
        }

        private void FetchFriends()
        {
            r_FBAPIClient.GetFriendsList();
        }


        public void CheckRememberMe()
        {
            rememberMeCheckBox.Checked = true;
        }


        private void FetchGroups(List<GroupDTO> groupsListDTO)
        {
            foreach (GroupDTO groupDTO in groupsListDTO)
            {
                AlbumBox groupAlbumBox = new AlbumBox();
                groupAlbumBox.SetGroupNameLabel(groupDTO.Name);
                groupAlbumBox.SetGroupPictureInPictureBox(groupDTO.PictureURL);
                /*groupAlbumBox.SetGroupMembersCountLabel(groupDTO.MembersCount);
                groupAlbumBox.SetGroupPrivacyLabel(groupDTO.Privacy);*/
                groupLayoutPanel.Controls.Add(groupAlbumBox);

            }
            groupLayoutPanel.AutoScroll = true;
        }

    }
}
