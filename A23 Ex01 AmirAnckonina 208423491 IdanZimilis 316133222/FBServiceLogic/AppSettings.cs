using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FBServiceLogic
{
    public class AppSettings
    {
        /// <summary>
        /// Idan/Amir app id : 3456972604533289 
        /// </summary>
        /// 
        private List<string> m_Permissions;
        private string m_AppID;
        private bool m_RememberUserActivated;
        private string m_LastAccessToken;
        private static readonly string sr_AppSettingsFilePath = 
            Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                @"FBServiceLogic\Properties\AppSettings.xml");


        public string AppID { get => m_AppID; set => m_AppID = value; } 
        public bool RememberUserActivated { get => m_RememberUserActivated; set => m_RememberUserActivated = value; }
        public string LastAccessToken { get; set; }
        public List<string> Permissions { get => m_Permissions; set => m_Permissions = value; } 

        private AppSettings()
        {
            m_RememberUserActivated = false;
            m_Permissions = new List<string>();
            SetDefaultPermissions();
            SetAppSettingFilePath();
        }

        private void SetDefaultPermissions()
        {
            /// Init App with default ID, Permissions ... etc.
            /// 
        }

        private void SetAppSettingFilePath()
        {
           /* string workingDirPath;
            string basePath;

            workingDirPath = Directory.GetCurrentDirectory();
            basePath = Directory.GetParent(workingDirPath.ToString()).Parent.Parent.FullName;
            sr_AppSettingsFilePath = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                @"FBServiceLogic\Properties\AppSettings.xml");*/
        }
        public static AppSettings LoadSettings() /// Consider change design of the func.
        {
            AppSettings appSettings = null;

            appSettings = LoadFromFile();

            if (appSettings == null)
            {
                appSettings = new AppSettings();
            }

            return appSettings;

        }

        public void AddPermissions(string i_Permission)
        {
            m_Permissions.Add(i_Permission);
        }

        public void SaveToFile()
        {
            string workingDirectory = Directory.GetCurrentDirectory();
            string BasePath = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string appSettingsFilePath = Path.Combine(BasePath, @"\FBServiceLogic\Properties");

            using (Stream stream = new FileStream(appSettingsFilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;

            using (Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                appSettings = serializer.Deserialize(stream) as AppSettings;
            }

            return appSettings;
        }

        /*{
                "email",
        "public_profile",
        "user_age_range",
        "user_birthday",
        "user_events",
        "user_friends",
        "user_gender",
        "user_hometown",
        "user_likes",
        "user_link",
        "user_location",
        "user_photos",
        "user_posts",
        "user_videos"
            };*/
    }

}
    

