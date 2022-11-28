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
        private static readonly string sr_AppSettingsFilePath = Path.Combine(
                 AppDomain.CurrentDomain.BaseDirectory,
                 @"AppSettings.xml");

        public bool RememberUserActivated { get; set; }

        public string LastAccessToken { get; set; }

        public string AppID { get; set; } 

        public List<string> Permissions { get; set; } 

        private AppSettings()
        {
            SetDefaultAppSettings();
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

        public static AppSettings LoadSettings() 
        {
            AppSettings appSettings = null;
           
            appSettings = LoadFromFile();

            if (appSettings == null || appSettings.RememberUserActivated == false)
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public void SetDefaultAppSettings()
        {
            RememberUserActivated = false;
            LastAccessToken = null;
            AppID = "3456972604533289";
            SetDefaultPermissions();
        }

        private void SetDefaultPermissions()
        {
            /// Init App Permissions 
            Permissions = new List<string>(new string[] 
            {
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
            });
        }

        public void AddPermission(string i_Permission)
        {
            Permissions.Add(i_Permission);
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

        public void ResetAppSettings()
        {
            AppID = null;
            Permissions.Clear();
            RememberUserActivated = false;
            LastAccessToken = null;
            if (File.Exists(sr_AppSettingsFilePath))
            {
                File.Delete(sr_AppSettingsFilePath);
            }
        }
    }
}