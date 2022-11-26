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
        private User m_CurrentUser;
        private LoginResult m_LoginResult;
        private readonly AppSettings r_AppSettings;
        private DummyUsers r_DummyUsers;

        public FBAPIClient()
        {
            m_CurrentUser = null;
            m_LoginResult = null;
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

        public UserBasicInfoDTO GetUserBasicInfoDTO()
        {
            UserBasicInfoDTO userBasicInfoDTO = new UserBasicInfoDTO();

            userBasicInfoDTO.FirstName = m_CurrentUser.Name;
            userBasicInfoDTO.ProfilePictureURL = m_CurrentUser.PictureNormalURL;
            userBasicInfoDTO.Birthday = m_CurrentUser.Birthday;
            userBasicInfoDTO.Gender = m_CurrentUser.Gender.ToString();
            //userBasicInfoDTO.Hometown = m_LoggedInUser.Hometown.Name;
            userBasicInfoDTO.About = m_CurrentUser.About;
            userBasicInfoDTO.OnlineStatus = m_CurrentUser.OnlineStatus.ToString();
            
            return userBasicInfoDTO;    
        }

        public List<FriendDTO> GetFriendsList()
        {
            List<FriendDTO> friendDTOList = new List<FriendDTO>();

            if (m_CurrentUser.Friends.Count <= 0)
            {
                foreach (DummyUsers.SingleDummyUser dummyUser in r_DummyUsers.FBUsers)
                {
                    FriendDTO newFriendDTO = new FriendDTO();
                    newFriendDTO.Name = dummyUser.Name;
                    newFriendDTO.Name = dummyUser.Hometown;
                    newFriendDTO.Name = dummyUser.Education;
                    newFriendDTO.ProfilePictureURL = dummyUser.ProfilePictureURL;
                    friendDTOList.Add(newFriendDTO);
                }
            }

            else
            {
                foreach (User friend in m_CurrentUser.Friends)
                {
                        FriendDTO newFriendDTO = new FriendDTO();
                        newFriendDTO.Name = friend.Name;
                        newFriendDTO.ProfilePictureURL = friend.PictureSqaureURL;
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
                TextAndImageDTO albumDTO = new TextAndImageDTO(album.Name, album.PictureSmallURL);
                albumDTOList.Add(albumDTO);
            }

            return albumDTOList;
        }

        public List<PostDTO> GetPostsList()
        {
            List<PostDTO> postDTOList = new List<PostDTO>();

            foreach (Post post in m_CurrentUser.Posts) 
            {
                postDTOList.Add(new PostDTO(post.Message, post.Caption, post.CreatedTime));
            }

            return postDTOList;
        }

        public List<PostDTO> GetPostsByDate(DateTime i_DateTime)
        {
            List<PostDTO> postDTOList = new List<PostDTO>();
            int postCounter = 0;
            foreach (Post post in m_CurrentUser.Posts)
            {
                postCounter++;
                DateTime? dt = post.CreatedTime.Value;
                if (dt?.Day == i_DateTime.Day && dt?.Month == i_DateTime.Month && dt?.Year == i_DateTime.Year )
                {
                    postDTOList.Add(new PostDTO(post.Message, post.Caption, post.CreatedTime)); 
                }
            }
        
            
            return postDTOList;
        }

        public List<TextAndImageDTO> GetGroupsNamesList()
        {
            List<TextAndImageDTO> groupsDTOList = new List<TextAndImageDTO>();
            FacebookObjectCollection<Group> groups = m_CurrentUser.Groups;
            
            foreach (Group group in groups)
            {
                groupsDTOList.Add(new TextAndImageDTO(group.Name, group.PictureNormalURL));
            }

            return groupsDTOList;
        }
    }
}
