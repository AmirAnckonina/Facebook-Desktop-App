using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBServiceLogic.DTOs;
using System.IO;
using System.Xml.Serialization;

namespace FBServiceLogic
{
    public class DummyUsers
    {
        /// <summary>
        ///  The purpose is to give this List<User> to the current user and set it as his Friends list.
        /// </summary>
        /// 
        private static readonly string sr_DummyUsersFilePath = Path.Combine(
                 Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                 @"FBServiceLogic\Properties\FBDummyUsers.xml");

         ///public List<SingleDummyUser> FBUsers { get; set; }
           public List<Dictionary<string, string>> FBUsers { get; set; }
        /// public List<List<string>> FBUsers { get; set; }
        

        public class SingleDummyUser
        {
            public string Name { get; set; }
            public string Hometown { get; set; }
            public string Education { get; set; }
            public string ProfilePictureURL { get; set; }
        }

        public DummyUsers()
        {
            ///FBUsers = new List<SingleDummyUser>();
           /// Dictionary<string, string> userDataKV = new Dictionary<string, string>();
            FBUsers = new List<Dictionary<string,string>>();
            /// FBUsers = new List<List<string>>();
            ImportDummyUsersFromXMLFile();
        }

        private void ImportDummyUsersFromXMLFile()
        {
            /// FBUsers = null;
            DummyUsers dummyUsers = null;

            try
            {
                using (Stream stream = new FileStream(sr_DummyUsersFilePath, FileMode.Open))
                { 
                    XmlSerializer serializer = new XmlSerializer(typeof(DummyUsers));
                    dummyUsers = serializer.Deserialize(stream) as DummyUsers;
                }
            }
            catch
            {
                throw new IOException("Failed to import Dummy Users...");
            }
        }




    }
}
