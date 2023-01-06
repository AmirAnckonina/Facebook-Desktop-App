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

                new Thread(initBasicUserInfo).Start();
                new Thread(()=>initAlbums(r_FBAPIClient.GetAlbumsList())).Start();
                new Thread(()=>initGroups(r_FBAPIClient.GetGroupsList())).Start();
                new Thread(() => initPosts(r_FBAPIClient.GetPostsList())).Start();
                new Thread(() => initLikedPages(r_FBAPIClient.GetLikedPages())).Start();
                new Thread(() => initFriends(r_FBAPIClient.GetFriendsList())).Start();
            }));
        }

        private void initBasicUserInfo()
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

        private void initLikedPages(List<LikedPageDTO> i_LikedPagesList)
        {
            foreach (LikedPageDTO pageDTO in i_LikedPagesList)
            {
                PageBox pageBox = new PageBox();
                pageBox.setName(pageDTO.Name);
                pageBox.setPictureBox(pageDTO.PictureURL);
                pageBox.setNumOfLikes(pageDTO.LikesCount);
                likedPagesFlowLayoutPanel.Invoke(new Action(() => likedPagesFlowLayoutPanel.Controls.Add(pageBox)));
            }

            likedPagesFlowLayoutPanel.Invoke(new Action(()=>likedPagesFlowLayoutPanel.AutoScroll = true));
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
                        postsByDateListBox.Items.Add(word + Environment.NewLine);
                    }
                  
                    postsByDateListBox.Items.Add(Environment.NewLine);
                }
            }
        }

        private void initPosts(List<PostDTO> i_PostsDTOList)
        {
            if (i_PostsDTOList != null)
            {
                foreach (PostDTO post in i_PostsDTOList)
                {
                    if (!string.IsNullOrEmpty(post.Message))
                    {
                        string[] postString = post.Message.Split(char.Parse("\n"));
                        foreach (string word in postString)
                        {
                            postsListBox.Invoke(new Action(() => postsListBox.Items.Add(word + Environment.NewLine)));
                        }

                        postsByDateListBox.Invoke(new Action(() => postsByDateListBox.Items.Add(Environment.NewLine)));
                    }
                }
            }
        }

        private void initAlbums(List<TextAndImageDTO> i_AlbumDTOs)
        {
            foreach (TextAndImageDTO albumDTO in i_AlbumDTOs)
            {
                AlbumBox album = new AlbumBox();
                album.SetGroupNameLabel(albumDTO.Name);
                album.SetGroupPictureInPictureBox(albumDTO.PictureURL);

                albumsLayoutPanel.Invoke(new Action(() =>
                {
                    albumsLayoutPanel.Controls.Add(album);
                    albumsLayoutPanel.AutoScroll = true;
                }));
            }

        }

        private void initFriends(List<FriendDTO> i_FriendsDTOList)
        {
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
        
        public void CheckRememberMe()
        {
            rememberMeCheckBox.Checked = true;
        }

        private void initGroups(List<GroupDTO> i_GroupsListDTO)
        {
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

        private void fetchHometownFriends(List<HometownFriendDTO> i_HometownFriendsDTOList)
        {
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

        private void fetchHomwtownFriendsButton_Click(object sender, EventArgs e)
        {
            hometownFriendFlowPanel.Controls.Clear();
            fetchHometownFriends(r_FBAPIClient.GetMyHometownFriends());
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
