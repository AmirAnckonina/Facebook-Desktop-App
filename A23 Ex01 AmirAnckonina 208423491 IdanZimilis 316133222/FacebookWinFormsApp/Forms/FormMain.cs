using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
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

        private void initForm()
        {
            Invoke(new Action(() =>
            {
                testBoxLoggedInUser.Text = $"Logged in as {r_FBAPIClient.CurrentUser.Name}";

                new Thread(() => initBasicUserInfo()).Start();
                new Thread(() => initAlbums()).Start();
                new Thread(() => initGroups()).Start();
                new Thread(() => initPosts()).Start();
                new Thread(() => initLikedPages()).Start();
                new Thread(() => initFriends()).Start();
            }));
        }

        private void initBasicUserInfo()
        {
            try
            {
                UserBasicInfoDTO userBasicInfoDTO = r_FBAPIClient.GetUserBasicInfoDTO();

                profilePictureBox.LoadAsync(userBasicInfoDTO.PictureURL);
                Invoke(new Action(() =>
                {
                    genderLabel.Text = userBasicInfoDTO.Gender;
                    birthdayLabel.Text = userBasicInfoDTO.Birthday;
                    statusLabel.Text = userBasicInfoDTO.OnlineStatus;
                    homeTownLabel.Text = userBasicInfoDTO.Hometown;
                    educationLabel.Text = userBasicInfoDTO.Education;
                }));
            }
            catch(Exception ex)
            { }
        }

        private void initLikedPages()
        {
            try
            {
                List<LikedPageDTO> i_LikedPagesList = r_FBAPIClient.GetLikedPages();

                foreach (LikedPageDTO pageDTO in i_LikedPagesList)
                {
                    Invoke(new Action(() =>
                    {

                    PageBox pageBox = new PageBox();
                    pageBox.setName(pageDTO.Name);
                    pageBox.setPictureBox(pageDTO.PictureURL);
                    pageBox.setNumOfLikes(pageDTO.LikesCount);
                    likedPagesFlowLayoutPanel.Controls.Add(pageBox);
                    likedPagesFlowLayoutPanel.AutoScroll = true;
                   /* likedPagesFlowLayoutPanel.Invoke(new Action(() => likedPagesFlowLayoutPanel.Controls.Add(pageBox)));
                    likedPagesFlowLayoutPanel.Invoke(new Action(() => likedPagesFlowLayoutPanel.AutoScroll = true));*/
                    }));
                }
            }
            catch(Exception ex)
            { }                
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_FBAPIClient.Logout();
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(()=>
            {
                initForm();
            });

            thread.Start();
        }

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMeCheckBox.Checked)
            {
                r_FBAPIClient.AppSettings.RememberUserActivated = true;
                r_FBAPIClient.AppSettings.LastAccessToken = r_FBAPIClient.LoginResult.AccessToken;
            }
            else
            {
                r_FBAPIClient.AppSettings.RememberUserActivated = false;
                r_FBAPIClient.AppSettings.LastAccessToken = null;
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
                r_FBAPIClient.NormalExit();

            }
        }

        private void fetchPostsByDate()
        {
            try
            {
                //List<PostDTO> allPostsInSingleDay = r_FBAPIClient.GetPostsByDate(dateTimePicker1.Value);
                List<PostDTO> allPostsInSingleDay = r_FBAPIClient.GetPostsByDate(dateTimePicker1.Value);


                foreach (PostDTO post in allPostsInSingleDay)
                {
                    if (!string.IsNullOrEmpty(post.Message))
                    {
                        string[] postString = post.Message.Split(char.Parse("\n"));
                        foreach (string word in postString)
                        {
                            postsByDateListBox.Items.Add(word + Environment.NewLine);
                        }

                        postsByDateListBox.Items.Add(Environment.NewLine);
                    }
                }

                //postBindingSource.DataSource = allPostsInSingleDay;

            }
            catch(Exception ex)
            { }
        }

        private void searchPostsByDateButton_Click(object sender, EventArgs e)
        {
            postsByDateListBox.Items.Clear();
            fetchPostsByDate();
            
        }

        private void initPosts()
        {
            try
            {
                List<PostDTO> postsDTOList = r_FBAPIClient.GetPostsList();

                if (postsDTOList != null)
                {

                    /*foreach (PostDTO post in i_PostsDTOList)
                    {
                        if (!string.IsNullOrEmpty(post.Message))
                        {
                            string[] postString = post.Message.Split(char.Parse("\n"));
                            foreach (string word in postString)
                            {
                                postsListBox.Invoke(new Action(() => postsListBox.Items.Add(word + Environment.NewLine)));
                            }

                           // postsByDateListBox.Invoke(new Action(() => postsByDateListBox.Items.Add(Environment.NewLine)));
                        }
                    }*/
                    postBindingSource.DataSource = postsDTOList;
                }
            }
            catch(Exception ex)
            { }
        }

        private void initAlbums()
        {
            try
            {
                List<TextAndImageDTO> albumsDTO = r_FBAPIClient.GetAlbumsList();

                foreach (TextAndImageDTO albumDTO in albumsDTO)
                {
                    Invoke(new Action(() =>
                    {
                        AlbumBox album = new AlbumBox();
                        album.SetGroupNameLabel(albumDTO.Name);
                        album.SetGroupPictureInPictureBox(albumDTO.PictureURL);
                        albumsLayoutPanel.Controls.Add(album);
                        albumsLayoutPanel.AutoScroll = true;

                    }));
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void initFriends()
        {
            try
            {
                List<FriendDTO> i_FriendsDTOList = r_FBAPIClient.GetFriendsList();
                foreach (FriendDTO friendDTO in i_FriendsDTOList)
                {
                    FriendBox friendBox = new FriendBox();
                    friendBox.SetFriendName(friendDTO.Name);
                    friendBox.SetPictureBox(friendDTO.PictureURL);
                    friendBox.SetStatus(friendDTO.OnlineStatus);
                    friendsFlowLayoutPanel.Invoke(new Action(() =>
                    {
                        friendsFlowLayoutPanel.Controls.Add(friendBox);
                        groupLayoutPanel.AutoScroll = true;
                    }));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured while fetching user friends. " + ex.Message);
            }

        }
        
        public void CheckRememberMe()
        {
            rememberMeCheckBox.Checked = true;
        }

        private void initGroups()
        {
            try
            {
                List<GroupDTO> i_GroupsListDTO = r_FBAPIClient.GetGroupsList();

                foreach (GroupDTO groupDTO in i_GroupsListDTO)
                {
                    FBGroupBox groupBox = new FBGroupBox();
                    groupBox.SetGroupNameLabel(groupDTO.Name);
                    groupBox.SetGroupPictureInPictureBox(groupDTO.PictureURL);
                    groupBox.SetGroupMembersCount(groupDTO.MembersCount.ToString());
                    groupBox.SetGroupPrivacy(groupDTO.Privacy);
                    groupLayoutPanel.Invoke(new Action(() =>
                    {
                        groupLayoutPanel.Controls.Add(groupBox);
                        groupLayoutPanel.AutoScroll = true;

                    }));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured while fetching user groups. " + ex.Message);
            }
        }

        private void fetchHometownFriends()
        {
            try
            {
                List<HometownFriendDTO> i_HometownFriendsDTOList = r_FBAPIClient.GetMyHometownFriends();

                if (i_HometownFriendsDTOList.Count > 0)
                {
                    labelhomeTown.Text = i_HometownFriendsDTOList[0].Hometown;
                }
                else
                {
                    labelhomeTown.Text = "THERE ARE NO MUTUAL FRIENDS IN HOMETOWN"; 
                }

                foreach (HometownFriendDTO homeTownFriendDTO in i_HometownFriendsDTOList)
                {
                    FriendBox friendBox = new FriendBox();
                    friendBox.SetFriendName(homeTownFriendDTO.Name);
                    friendBox.SetPictureBox(homeTownFriendDTO.PictureURL);
                    friendBox.SetStatus(homeTownFriendDTO.Status.ToString());
                    hometownFriendFlowPanel.Controls.Add(friendBox);
                }

                hometownFriendFlowPanel.AutoScroll = true;
            }
            catch(Exception ex)
            { }
        }

        private void fetchHomwtownFriendsButton_Click(object sender, EventArgs e)
        {
            hometownFriendFlowPanel.Controls.Clear();
            fetchHometownFriends();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = postTextBox.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "My status...";
            postTextBox.Text = string.Empty;
        }

       
    }
}
