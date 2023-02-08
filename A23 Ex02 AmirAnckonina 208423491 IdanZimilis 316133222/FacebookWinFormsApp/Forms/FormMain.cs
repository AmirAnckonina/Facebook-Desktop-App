using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsApp.Forms.Controls;
using FBServiceLogic;
using FBServiceLogic.DTOs;

namespace FacebookWinFormsApp
{
    public partial class FormMain : Form
    {
        private readonly FbApiClient r_FbApiClient;

        public FormMain(FbApiClient i_FbApiClient)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_FbApiClient = i_FbApiClient;
            r_FbApiClient.m_StatusPosted += this.updatePosts;
        }

        private void updatePosts(PostDTO newPost)
        {
            statusTextBox.Text = postTextBox.Text;
            this.postDTOBindingSource.Add(newPost);
            this.postDTOBindingSource.EndEdit();
            new Thread(() => initPosts()).Start();
        }

        private void initForm()
        {
            Invoke(new Action(() =>
            {
                testBoxLoggedInUser.Text = $"Logged in as {r_FbApiClient.CurrentUser.Name}";

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
                UserBasicInfoDTO i_UserBasicInfoDTO = r_FbApiClient.GetUserBasicInfoDTO();

                profilePictureBox.LoadAsync(i_UserBasicInfoDTO.PictureURL);
                Invoke(new Action(() =>
                {
                    genderLabel.Text = i_UserBasicInfoDTO.Gender;
                    birthdayLabel.Text = i_UserBasicInfoDTO.Birthday;
                    statusLabel.Text = i_UserBasicInfoDTO.OnlineStatus;
                    homeTownLabel.Text = i_UserBasicInfoDTO.Hometown;
                    educationLabel.Text = i_UserBasicInfoDTO.Education;
                }));
            }
            catch (Exception)
            {
            }
        }

        private void initLikedPages()
        {
            try
            {
                List<LikedPageDTO> i_LikedPagesList = r_FbApiClient.GetLikedPages();

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
                    }));
                }
            }
            catch (Exception)
            {
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_FbApiClient.Logout();
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                initForm();
            });

            thread.Start();
        }

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMeCheckBox.Checked)
            {
                r_FbApiClient.AppSettings.RememberUserActivated = true;
                r_FbApiClient.AppSettings.LastAccessToken = r_FbApiClient.LoginResult.AccessToken;
            }
            else
            {
                r_FbApiClient.AppSettings.RememberUserActivated = false;
                r_FbApiClient.AppSettings.LastAccessToken = null;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (rememberMeCheckBox.Checked)
            {
                r_FbApiClient.AppSettings.SaveToFile();
                r_FbApiClient.ResetCurrentFbState();
            }
            else
            {
                r_FbApiClient.NormalExit();
            }
        }

        private void fetchPostsByDate()
        {
            List<PostDTO> allPostsInSingleDay;
            try
            {
                allPostsInSingleDay = r_FbApiClient.GetPostsByDate(dateTimePicker1.Value);

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
            }
            catch (Exception)
            {
            }
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
                this.postDTOBindingSource.DataSource = r_FbApiClient.GetPostsList();
            }
            catch (Exception)
            {
            }
        }

        private void initAlbums(bool i_FilterApplied = false)
        {
            try
            {
                List<TextAndImageDTO> albumsDTO = r_FbApiClient.GetAlbumsList(i_FilterApplied);

                Invoke(new Action(() =>
                {
                    albumsLayoutPanel.Controls.Clear();
                    foreach (TextAndImageDTO albumDTO in albumsDTO)
                    {
                        AlbumBox album = new AlbumBox();
                        album.SetGroupNameLabel(albumDTO.Name);
                        album.SetGroupPictureInPictureBox(albumDTO.PictureURL);
                        albumsLayoutPanel.Controls.Add(album);
                        albumsLayoutPanel.AutoScroll = true;
                    }
                }));
            }
            catch (Exception)
            {
            }
        }

        private void initFriends(string i_SortingMethod = null)
        {
            try
            {
                List<FriendDTO> friendsDTOList = r_FbApiClient.GetFriendsList(i_SortingMethod);

                friendsFlowLayoutPanel.Invoke(new Action(() =>
                {
                    friendsFlowLayoutPanel.Controls.Clear();
                    foreach (FriendDTO friendDTO in friendsDTOList)
                    {
                            FriendBox friendBox = new FriendBox();
                            friendBox.SetFriendName(friendDTO.Name);
                            friendBox.SetPictureBox(friendDTO.PictureURL);
                            friendBox.SetStatus(friendDTO.OnlineStatus);
                            friendsFlowLayoutPanel.Controls.Add(friendBox);
                            groupLayoutPanel.AutoScroll = true;
                    }
                }));
            }
            catch (Exception)
            {
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
                List<GroupDTO> groupsListDTO = r_FbApiClient.GetGroupsList();

                foreach (GroupDTO groupDTO in groupsListDTO)
                {
                    Forms.Controls.GroupBox groupBox = new Forms.Controls.GroupBox();
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
            catch (Exception)
            {
            }
        }

        private void fetchHometownFriends()
        {
            try
            {
                List<HometownFriendDTO> hometownFriendsDTOList = r_FbApiClient.GetMyHometownFriends();

                if (hometownFriendsDTOList.Count > 0)
                {
                    labelhomeTown.Text = hometownFriendsDTOList[0].Hometown;
                }
                else
                {
                    labelhomeTown.Text = "THERE ARE NO MUTUAL FRIENDS IN HOMETOWN";
                }

                foreach (HometownFriendDTO homeTownFriendDTO in hometownFriendsDTOList)
                {
                    FriendBox friendBox = new FriendBox();
                    friendBox.SetFriendName(homeTownFriendDTO.Name);
                    friendBox.SetPictureBox(homeTownFriendDTO.PictureURL);
                    friendBox.SetStatus(homeTownFriendDTO.Status.ToString());
                    hometownFriendFlowPanel.Controls.Add(friendBox);
                }

                hometownFriendFlowPanel.AutoScroll = true;
            }
            catch (Exception)
            {
            }
        }

        private void fetchHomwtownFriendsButton_Click(object sender, EventArgs e)
        {
            hometownFriendFlowPanel.Controls.Clear();
            try
            {
                fetchHometownFriends();
            }
            catch (Exception)
            {
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            r_FbApiClient.PostStatus(postTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "My status...";
            postTextBox.Text = string.Empty;
        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortingMethodItem = sortByComboBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedSortingMethodItem))
            {
                new Thread(() => initFriends(selectedSortingMethodItem)).Start();
            }
        }

        private void filteredAlbumsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool filterApplied;

            if (filteredAlbumsCheckbox.Checked)
            {
                filterApplied = true;
            }
            else
            {
                filterApplied = false;
            }

            new Thread(() => initAlbums(filterApplied)).Start();
        }
    }
}
