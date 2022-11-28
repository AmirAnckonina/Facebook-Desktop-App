﻿using System;
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
using System.Threading;


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

        private void InitForm()
        {
            Invoke(new Action(() =>
            {
                testBoxLoggedInUser.Text = $"Logged in as {r_FBAPIClient.CurrentUser.Name}";
                InitBasicUserInfo();
                InitAlbums(r_FBAPIClient.GetAlbumsList());
                InitGroups(r_FBAPIClient.GetGroupsNamesList());
                InitPosts(r_FBAPIClient.GetPostsList());
                InitLikedPages(r_FBAPIClient.GetLikedPages());
                InitFriends(r_FBAPIClient.GetFriendsList());
            }));
        }

        private void InitBasicUserInfo()
        {
            UserBasicInfoDTO userBasicInfoDTO = r_FBAPIClient.GetUserBasicInfoDTO();
            profilePictureBox.LoadAsync(userBasicInfoDTO.PictureURL);
            genderLabel.Text = userBasicInfoDTO.Gender;
            birthdayLabel.Text = userBasicInfoDTO.Birthday;
            statusLabel.Text = userBasicInfoDTO.OnlineStatus;
            homeTownLabel.Text = userBasicInfoDTO.Hometown;    
        }

        private void InitLikedPages(List<LikedPageDTO> i_LikedPagesList)
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
            rememberMeCheckBox.Checked = false;
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(()=>{
                InitForm();
            });

            thread.Start();
        }

        private void fetchAlbumsButton_Click(object sender, EventArgs e)
        {
            
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
                        postsByDateListBox.Items.Add(word + Environment.NewLine);
                    }
                  
                    postsByDateListBox.Items.Add(Environment.NewLine);
                }
            }
        }

        private void InitPosts(List<PostDTO> postsDTOList)
        {
            foreach (PostDTO post in postsDTOList)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    string[] postString = post.Message.Split(char.Parse("\n"));
                    foreach (string word in postString)
                    {
                        postsListBox.Items.Add(word + Environment.NewLine);
                    }
                  
                    postsByDateListBox.Items.Add(Environment.NewLine);
                }
            }
        }

        private void InitAlbums(List<TextAndImageDTO> albumDTOs)
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
      
        private void InitFriends(List<FriendDTO> i_FriendsDTOList)
        {
            foreach (FriendDTO friendDTO in i_FriendsDTOList)
            {
                FriendBox friendBox = new FriendBox();
                friendBox.SetFriendName(friendDTO.Name);
                friendBox.SetPictureBox(friendDTO.PictureURL);
                friendBox.SetStatus(friendDTO.OnlineStatus);
                friendsFlowLayoutPanel.Controls.Add(friendBox);
            }
            groupLayoutPanel.AutoScroll = true;
        }
        
        public void CheckRememberMe()
        {
            rememberMeCheckBox.Checked = true;
        }

        private void InitGroups(List<GroupDTO> groupsListDTO)
        {
            foreach (GroupDTO groupDTO in groupsListDTO)
            {
                FBGroupBox groupBox = new FBGroupBox();
                groupBox.SetGroupNameLabel(groupDTO.Name);
                groupBox.SetGroupPictureInPictureBox(groupDTO.PictureURL);
                groupBox.SetGroupMembersCount(groupDTO.MembersCount.ToString());
                groupBox.SetGroupPrivacy(groupDTO.Privacy);
                groupLayoutPanel.Controls.Add(groupBox);
            }
            groupLayoutPanel.AutoScroll = true;
        }

        private void FetchHometownFriends(List<HometownFriendDTO> i_HometownFriendsDTOList)
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
                //friendBox.SetStatus(friendDTO.OnlineStatus);
                hometownFriendFlowPanel.Controls.Add(friendBox);
            }
            hometownFriendFlowPanel.AutoScroll = true;
        }

        private void fetchHomwtownFriendsButton_Click(object sender, EventArgs e)
        {
            FetchHometownFriends(r_FBAPIClient.GetMyHometownFriends());
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = postTextBox.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "My status...";
            postTextBox.Text = "";
     
        }
    }
}
