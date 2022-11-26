using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBServiceLogic.DTOs;
using System;
using System.Collections.Generic;


namespace FBServiceLogic
{
    public class FBAPIClient
    {
        public enum UserData
        {
            Friends,
            Albums,
            Alumnus,
            HometowmFriends,
            Posts,
            LikedPages,
            Groups
        }

        private User m_CurrentUser;
        private SingleDummyUser m_CurrentUserDummyData;
        private LoginResult m_LoginResult;
        private readonly AppSettings r_AppSettings;
        private DummyUsers r_DummyUsers;

        public FBAPIClient()
        {
            m_CurrentUser = null;
            m_LoginResult = null;
            m_CurrentUser = null;
            r_AppSettings = AppSettings.LoadSettings();
            r_DummyUsers = DummyUsers.ImportDummyUsersFromXMLFile();
        }

        public User CurrentUser { get => m_CurrentUser; set => m_CurrentUser = value; }
        public LoginResult LoginResult { get => m_LoginResult; set => m_LoginResult = value; }
        public AppSettings AppSettings { get => r_AppSettings; }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(r_AppSettings.AppID, r_AppSettings.Permissions.ToArray());

            CompleteLoginProcedure(m_LoginResult.AccessToken);
        }

        public void AutomaticLogin()
        {
            m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);

            CompleteLoginProcedure(m_LoginResult.AccessToken);
        }

        public void ImportAlternativeData()
        {
            ///r_DummyUsers.CreateDummyUsers();
            ///r_DummyUsers.SaveXMLExample();
        }

        private void CompleteLoginProcedure(string i_AccessToken)
        {
            if (!string.IsNullOrEmpty(i_AccessToken))
            {
                m_CurrentUser = m_LoginResult.LoggedInUser;
                SetDummyDataForCurrentUser();
            }

            else
            {
                throw new FacebookApiException("Login Failed");
            }
        }

        public void Logout()
        {
            FacebookService.Logout();
            r_AppSettings.ResetAppSettings();
            ResetCurrentFBState();
        }

        public void ResetCurrentFBState()
        {
            m_CurrentUser = null;
            m_LoginResult = null;
        }

        private void SetDummyDataForCurrentUser()
        {
            m_CurrentUserDummyData = new SingleDummyUser();

            m_CurrentUserDummyData.Name = m_CurrentUser.Name;
            m_CurrentUserDummyData.Hometown = "Givatayim";
            m_CurrentUserDummyData.Education = "Jaffa College";
            m_CurrentUserDummyData.ProfilePictureURL = m_CurrentUser.PictureSmallURL;
        }

        public UserBasicInfoDTO GetUserBasicInfoDTO()
        {
            UserBasicInfoDTO userBasicInfoDTO = new UserBasicInfoDTO();

            userBasicInfoDTO.FirstName = m_CurrentUser.Name;
            userBasicInfoDTO.ProfilePictureURL = m_CurrentUser.PictureNormalURL;
            userBasicInfoDTO.Birthday = m_CurrentUser.Birthday;
            userBasicInfoDTO.Gender = m_CurrentUser.Gender.ToString();
            userBasicInfoDTO.About = m_CurrentUser.About;
            userBasicInfoDTO.OnlineStatus = m_CurrentUser.OnlineStatus.ToString();

            return userBasicInfoDTO;
        }

        public List<TextAndImageDTO> GetFriendsList()
        {
            List<TextAndImageDTO> friendDTOList = new List<TextAndImageDTO>();

            if (m_CurrentUser.Friends.Count <= 0)
            {
                foreach (SingleDummyUser dummyUser in r_DummyUsers.FBUsers)
                {
                    TextAndImageDTO newFriendDTO = new TextAndImageDTO();
                    newFriendDTO.Name = dummyUser.Name;
                    newFriendDTO.Name = dummyUser.Name;
                    newFriendDTO.PictureURL = dummyUser.ProfilePictureURL;
                    friendDTOList.Add(newFriendDTO);
                }
            }

            else
            {
                foreach (User friend in m_CurrentUser.Friends)
                {
                    TextAndImageDTO newFriendDTO = new TextAndImageDTO();
                    newFriendDTO.Name = friend.Name;
                    newFriendDTO.PictureURL = friend.PictureSqaureURL;
                    friendDTOList.Add(newFriendDTO);
                }
            }

            return friendDTOList;
        }

        public List<TextAndImageDTO> GetAlbumsList()
        {
            List<TextAndImageDTO> albumDTOList = new List<TextAndImageDTO>();

            foreach (Album album in m_CurrentUser.Albums)
            {
                TextAndImageDTO albumDTO = new TextAndImageDTO();
                albumDTO.Name = album.Name;
                albumDTO.PictureURL = album.PictureSmallURL;
                albumDTOList.Add(albumDTO);
            }

            return albumDTOList;
        }

        public List<PostDTO> GetPostsList()
        {
            List<PostDTO> postDTOList = new List<PostDTO>();

            foreach (Post post in m_CurrentUser.Posts)
            {
                PostDTO newPost = new PostDTO();
                newPost.Message = post.Message;
                newPost.Caption = post.Caption;
                newPost.CreatedTime = post.CreatedTime;
                postDTOList.Add(newPost);
                /// postDTOList.Add(new PostDTO(post.Message, post.Caption, post.CreatedTime));
            }

            return postDTOList;
        }

        public List<PostDTO> GetPostsByDate(DateTime i_DateTime)
        {
            List<PostDTO> postDTOList = new List<PostDTO>();

            foreach (Post post in m_CurrentUser.Posts)
            {
                if (post.CreatedTime.Equals(i_DateTime))
                {
                    postDTOList.Add(new PostDTO(post.Message, post.Caption, post.CreatedTime));
                }
            }


            return postDTOList;
        }

        public List<TextAndImageDTO> GetGroupsNamesList()
        {
            List<TextAndImageDTO> groupsDTOList = new List<TextAndImageDTO>();

            foreach (Group group in m_CurrentUser.Groups)
            {
                TextAndImageDTO newGroup = new TextAndImageDTO();
                newGroup.Name = group.Name;
                newGroup.PictureURL = group.PictureNormalURL;
                groupsDTOList.Add(newGroup);
            }

            return groupsDTOList;
        }

        public List<TextAndImageDTO> GetMyAlumnus()
        {
            List<TextAndImageDTO> myAlumnusList = new List<TextAndImageDTO>();

            if (m_CurrentUser.Friends.Count <= 0)
            {
                foreach (SingleDummyUser friend in r_DummyUsers.FBUsers)
                {
                    if (m_CurrentUserDummyData.Education == friend.Education)
                    {
                        TextAndImageDTO newFriendDTO = new TextAndImageDTO();
                        newFriendDTO.Name = friend.Name;
                        newFriendDTO.PictureURL = friend.ProfilePictureURL;
                        myAlumnusList.Add(newFriendDTO);

                    }
                }
            }

            else
            {
                foreach (User friend in m_CurrentUser.Friends)
                {
                    if (m_CurrentUser.Educations[0].School.Name == friend.Educations[0].School.Name)
                    {
                        TextAndImageDTO newFriendDTO = new TextAndImageDTO();
                        newFriendDTO.Name = friend.Name;
                        newFriendDTO.PictureURL = friend.PictureSqaureURL;
                        myAlumnusList.Add(newFriendDTO);
                    }
                }
            }

            return myAlumnusList;
        }

        public List<TextAndImageDTO> GetMyHometownFriends()
        {
            List<TextAndImageDTO> myHometownFriends = new List<TextAndImageDTO>();


            if (m_CurrentUser.Friends.Count <= 0)
            {
                foreach (SingleDummyUser dummyUser in r_DummyUsers.FBUsers)
                {
                    if (m_CurrentUserDummyData.Hometown == dummyUser.Hometown)
                    {
                        TextAndImageDTO newFriendDTO = new TextAndImageDTO();
                        newFriendDTO.Name = dummyUser.Name;
                        newFriendDTO.PictureURL = dummyUser.ProfilePictureURL;
                        myHometownFriends.Add(newFriendDTO);
                    }
                }
            }

            else
            {
                foreach (User friend in m_CurrentUser.Friends)
                {
                    TextAndImageDTO newFriendDTO = new TextAndImageDTO();
                    newFriendDTO.Name = friend.Name;
                    newFriendDTO.PictureURL = friend.PictureSqaureURL;
                    myHometownFriends.Add(newFriendDTO);
                }
            }

            return myHometownFriends;
        }
    }
}

