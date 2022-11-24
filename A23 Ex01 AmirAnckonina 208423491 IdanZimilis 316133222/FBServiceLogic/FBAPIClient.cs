﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBServiceLogic.DTOs;


namespace FBServiceLogic
{
    public class FBAPIClient
    {
        /// <summary>
        /// /TEST!!!!!
        /// </summary>
        private User m_CurrentUser;
        private LoginResult m_LoginResult;
        private readonly AppSettings r_AppSettings;

        public FBAPIClient()
        {
          r_AppSettings = AppSettings.LoadSettings();
        }

        public User CurrentUser { get; set; }
        public LoginResult LoginResult { get; }
        public AppSettings AppSettings { get => r_AppSettings; }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(r_AppSettings.AppID, r_AppSettings.Permissions.ToArray());
   
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
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
            m_CurrentUser = null;
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

            foreach (User friend in m_CurrentUser.Friends)
            {
                FriendDTO newFriendDTO = new FriendDTO();
                newFriendDTO.Name = friend.Name;
                newFriendDTO.ProfilePictureURL = friend.PictureSqaureURL;
                friendDTOList.Add(newFriendDTO);
            }

            return friendDTOList;
        }

        public List<AlbumDTO> GetAlbumsList()
        {
            List<AlbumDTO> albumDTOList = new List<AlbumDTO>();

            foreach (Album album in m_CurrentUser.Albums)
            {
                AlbumDTO albumDTO = new AlbumDTO(album.Name, album.PictureSmallURL);
                albumDTOList.Add(albumDTO);
            }

            return albumDTOList;
        }

      
    }
}
