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
        private string m_AppID;
        // private bool m_RememberUserActivated;
        //private string m_LastAccessToken;
        private List<string> m_Permissions;
        private static readonly string sr_AppSettingsFilePath = Path.Combine(
                 Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                 @"FBServiceLogic\Properties\AppSettings.xml");

        public string AppID { get => m_AppID; set => m_AppID = value; } 
        /// public bool RememberUserActivated { get => m_RememberUserActivated; set => m_RememberUserActivated = value; }
        public bool RememberUserActivated { get; set; }
        public string LastAccessToken { get; set; }
        public List<string> Permissions { get => m_Permissions; set => m_Permissions = value; } 

        private AppSettings()
        {
            m_AppID = "3456972604533289";
            /// m_RememberUserActivated = false;
            RememberUserActivated = false;
            ///m_LastAccessToken = "";
            LastAccessToken = null;
            SetDefaultPermissions();
        }

        private void SetDefaultPermissions()
        {
            /// Init App Permissions 
            m_Permissions = new List<string>(new string[] { "email",
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
            });
        }

        public static AppSettings LoadSettings() /// Consider change design of the func.
        {
            AppSettings appSettings = null;
           
            appSettings = LoadFromFile();

            if (appSettings == null || appSettings.RememberUserActivated == false)
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

            FileMode fileMode;

            if (File.Exists(sr_AppSettingsFilePath))
            {
                fileMode = FileMode.Truncate;
            }

            else
            {
                fileMode = FileMode.CreateNew;
            }

            using (Stream stream = new FileStream(sr_AppSettingsFilePath, fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }       
        }

        private static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;

            try 
            {
                using (Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            catch(Exception ex)
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }       

        public void ResetAppSettings()
        {
            RememberUserActivated = false;
            LastAccessToken = null;
            if (File.Exists(sr_AppSettingsFilePath))
            {
                File.Delete(sr_AppSettingsFilePath);
            }
        }
    }

}
    

