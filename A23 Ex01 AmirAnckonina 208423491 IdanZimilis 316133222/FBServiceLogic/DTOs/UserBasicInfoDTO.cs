using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FBServiceLogic.DTOs
{
    public class UserBasicInfoDTO
    {
/*        private string m_Name;
        private string m_ProfilePictureURL;
        private string m_Birthday;
        private string m_Email;
        private string m_Gender;
        private string m_Hometown;
        private string m_About;
        private string m_OnlineStatus;*/

        public string FirstName { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }
        public string About { get; set; }
        public string OnlineStatus { get; set; }
    }
}
