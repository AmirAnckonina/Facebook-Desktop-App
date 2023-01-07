using System;
using System.Collections.Generic;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBServiceLogic.DTOs;
using FBServiceLogic.DummyData;

namespace FBServiceLogic
{
    public class FBAPIClient
    {
        private readonly AppSettings r_AppSettings;
        private User m_CurrentUser;
        private LoginResult m_LoginResult;

        public FBAPIClient()
        {
            m_CurrentUser = null;
            m_LoginResult = null;
            m_CurrentUser = null;
            r_AppSettings = AppSettings.LoadSettings();
        }

        public User CurrentUser { get => m_CurrentUser; set => m_CurrentUser = value; }

        public LoginResult LoginResult { get => m_LoginResult; set => m_LoginResult = value; }

        public AppSettings AppSettings { get => r_AppSettings; }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(r_AppSettings.AppID, r_AppSettings.Permissions.ToArray());

            completeLoginProcedure(m_LoginResult.AccessToken);
        }

        public void AutomaticLogin()
        {
            m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);

            completeLoginProcedure(m_LoginResult.AccessToken);
        }

        private void completeLoginProcedure(string i_AccessToken)
        {
            if (!string.IsNullOrEmpty(i_AccessToken))
            {
                m_CurrentUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new FacebookApiException("Login Failed");
            }
        }
        
        public void NormalExit()
        {
            FacebookService.Logout();
            reset();
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI();
            reset();
        }

        private void reset()
        {
            ResetCurrentFBState();
            r_AppSettings.ResetAppSettings();
        }

        public void ResetCurrentFBState()
        {
            m_CurrentUser = null;
            m_LoginResult = null;
        }

        public UserBasicInfoDTO GetUserBasicInfoDTO()
        {
            UserBasicInfoDTO userBasicInfoDTO = new UserBasicInfoDTO();
            DummyUser dummyUserData = FBDummyDataFactory.CreateDummyData("User") as DummyUser;

            userBasicInfoDTO.Name = m_CurrentUser.Name;
            userBasicInfoDTO.PictureURL = m_CurrentUser.PictureNormalURL;
            userBasicInfoDTO.Birthday = m_CurrentUser.Birthday;
            userBasicInfoDTO.Gender = m_CurrentUser.Gender.ToString();
            userBasicInfoDTO.Education = dummyUserData.Education;
            userBasicInfoDTO.Hometown = dummyUserData.Hometown;
            userBasicInfoDTO.OnlineStatus = dummyUserData.OnlineStatus.ToString();

            return userBasicInfoDTO;
        }

        public List<FriendDTO> GetFriendsList()
        {
            List<FriendDTO> friendDTOList = new List<FriendDTO>();
            FriendDTO newFriendDTO;
            DummyFriends dummyFriendsData;

            if (m_CurrentUser.Friends.Count > 0)
            {
                foreach (User friend in m_CurrentUser.Friends)
                {
                    newFriendDTO = new FriendDTO();
                    newFriendDTO.Name = friend.Name;
                    newFriendDTO.PictureURL = friend.PictureSqaureURL;
                    newFriendDTO.OnlineStatus = friend.OnlineStatus.ToString();
                    friendDTOList.Add(newFriendDTO);
                }
            }

            else
            {
                dummyFriendsData = FBDummyDataFactory.CreateDummyData("Friends") as DummyFriends;
                foreach (DummyUser dummyUser in dummyFriendsData.Friends)
                {
                    newFriendDTO = new FriendDTO();
                    newFriendDTO.Name = dummyUser.Name;
                    newFriendDTO.PictureURL = dummyUser.PictureURL;
                    newFriendDTO.OnlineStatus = dummyUser.OnlineStatus.ToString();
                    friendDTOList.Add(newFriendDTO);
                }
            }

            return friendDTOList;
        }

        public List<TextAndImageDTO> GetAlbumsList()
        {
            List<TextAndImageDTO> albumDTOList = new List<TextAndImageDTO>();
            TextAndImageDTO albumDTO;
            FacebookObjectCollection<Album> albums = m_CurrentUser.Albums;

            foreach (Album album in m_CurrentUser.Albums)
            {
                albumDTO = new TextAndImageDTO();
                albumDTO.Name = album.Name;
                albumDTO.PictureURL = album.PictureSmallURL;
                albumDTOList.Add(albumDTO);
            }

            return albumDTOList;
        }

        public List<PostDTO> GetPostsList()
        {
            List<PostDTO> postDTOList = new List<PostDTO>();
            PostDTO newPost;

            FacebookObjectCollection<Post> posts = m_CurrentUser.Posts;
           
            foreach (Post post in m_CurrentUser.Posts)
            {
                newPost = new PostDTO();
                newPost.Message = post.Message;
                newPost.Caption = post.Caption;
                newPost.CreatedTime = post.CreatedTime;
                postDTOList.Add(newPost);
            }

            return postDTOList;
        }

        public List<PostDTO> GetPostsByDate(DateTime i_DateTime)
        {
            List<PostDTO> postDTOList = new List<PostDTO>();
            PostDTO newPost;
            DateTime? dateTime; 
            int postCounter = 0;

            FacebookObjectCollection<Post> posts = m_CurrentUser.Posts;

            //new section
            //List<Post> postsByDate = new List<Post>();
            foreach (Post post in posts)
            {
                postCounter++;
                dateTime = post.CreatedTime.Value;
                if (dateTime?.Day == i_DateTime.Day && dateTime?.Month == i_DateTime.Month && dateTime?.Year == i_DateTime.Year)
                {
                    newPost = new PostDTO();
                    newPost.Message = post.Message;
                    newPost.Caption = post.Caption;
                    newPost.CreatedTime = post.CreatedTime;
                    postDTOList.Add(newPost);
                    //postsByDate.Add(post);
                }
            }

            //end of new section

            /* foreach (Post post in m_CurrentUser.Posts)
             {
                 postCounter++;
                 dateTime = post.CreatedTime.Value;
                 if (dateTime?.Day == i_DateTime.Day && dateTime?.Month == i_DateTime.Month && dateTime?.Year == i_DateTime.Year )
                 {
                     newPost = new PostDTO();
                     newPost.Message = post.Message;
                     newPost.Caption = post.Caption;
                     newPost.CreatedTime = post.CreatedTime;
                     postDTOList.Add(newPost);
                 }
             }

             return postDTOList;*/
            return postDTOList;
        }

        public List<GroupDTO> GetGroupsList()
        {
            List<GroupDTO> groupsDTOList = new List<GroupDTO>();
            GroupDTO newGroup;
            DummyGroups dummyGroupsData;

            if (m_CurrentUser.Groups.Count > 0)
            {
                foreach (Group group in m_CurrentUser.Groups)
                {
                    newGroup = new GroupDTO();
                    newGroup.Name = group.Name;
                    newGroup.PictureURL = group.PictureNormalURL;
                    newGroup.Privacy = group.Privacy.ToString();
                    newGroup.MembersCount = RandomDataGenerator.GenerateRandGroupMemebersCount();
                    groupsDTOList.Add(newGroup);
                }
            }
            else
            {
                dummyGroupsData = FBDummyDataFactory.CreateDummyData("Groups") as DummyGroups;
                foreach (DummyGroup group in dummyGroupsData.Groups)
                {
                    newGroup = new GroupDTO();
                    newGroup.Name = group.Name;
                    newGroup.PictureURL = group.PictureURL;
                    newGroup.Privacy = group.Privacy.ToString();
                    newGroup.MembersCount = RandomDataGenerator.GenerateRandGroupMemebersCount();
                    groupsDTOList.Add(newGroup);
                }
            }

            return groupsDTOList;
        }

        public List<HometownFriendDTO> GetMyHometownFriends()
        {
            List<HometownFriendDTO> myHometownFriends = new List<HometownFriendDTO>();
            HometownFriendDTO htFriend;
            DummyFriends dummyFriendsData;

            if (m_CurrentUser.Friends.Count > 0)
            {
                foreach (User friend in m_CurrentUser.Friends)
                {
                    htFriend = new HometownFriendDTO();
                    htFriend.Name = friend.Name;
                    htFriend.PictureURL = friend.PictureSqaureURL;
                    htFriend.Hometown = friend.Hometown.Name;
                    myHometownFriends.Add(htFriend);
                }
            }
            else
            {
                dummyFriendsData = FBDummyDataFactory.CreateDummyData("Friends") as DummyFriends;
                foreach (DummyUser dummyUser in dummyFriendsData.Friends)
                {
                    if (dummyUser.Hometown == dummyUser.Hometown)
                    {
                        htFriend = new HometownFriendDTO();
                        htFriend.Name = dummyUser.Name;
                        htFriend.PictureURL = dummyUser.PictureURL;
                        htFriend.Hometown = dummyUser.Hometown;
                        htFriend.Status = dummyUser.OnlineStatus;
                        myHometownFriends.Add(htFriend);
                    }
                }
            }
       
            return myHometownFriends;
        }

        public List<LikedPageDTO> GetLikedPages()
        {
            List<LikedPageDTO> likedPagesList = new List<LikedPageDTO>();
            LikedPageDTO newLikedPage;

            foreach (Page likedPage in m_CurrentUser.LikedPages)
            {
                newLikedPage = new LikedPageDTO();
                newLikedPage.Name = likedPage.Name;
                newLikedPage.PictureURL = likedPage.PictureSmallURL;
                newLikedPage.LikesCount = likedPage.LikesCount != null ? likedPage.LikesCount : RandomDataGenerator.GenerateRandLikesCount();
                likedPagesList.Add(newLikedPage);
            }

            return likedPagesList;
        }
    }
}