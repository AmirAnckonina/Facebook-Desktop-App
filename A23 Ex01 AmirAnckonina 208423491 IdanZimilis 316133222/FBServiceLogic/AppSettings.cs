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
        private bool m_RememberUser;

        public string AppID { get => m_AppID; set => m_AppID = value; } 
        public bool RememberUser { get => m_RememberUser; set => m_RememberUser = value; }
        public string LastAccessToken { get; set; }
        public List<string> Permissions { get => m_Permissions; set => m_Permissions = value; } 
        /*private string m_AppID; // = "3456972604533289";
        private List<string> m_Permissions;
        private bool m_RememberUserActivated;
        private string m_LastAccessToken;*/

        private AppSettings()
        {
            m_RememberUser = false;
            m_Permissions = new List<string>(); 
        }

        public static AppSettings LoadSettings() /// Consider change design of the func.
        {
            AppSettings appSettings = null;

            //appSettings = LoadFromFile();

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
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            /// string path = AppDomain.CurrentDomain.BaseDirectory();

            using (Stream stream = new FileStream(path, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;
            string workingDirectory = Directory.GetCurrentDirectory();
            string path = Directory.GetParent(workingDirectory).Parent.ToString();
            /// string path = Directory.GetCurrentDirectory();
            /// string path = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            /// string path = AppDomain.CurrentDomain.BaseDirectory();

            using (Stream stream = new FileStream(path, FileMode.Open))
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
    

