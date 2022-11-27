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
    public class UserBasicInfoDTO // : TextAndImageDTO
    {
        public string FirstName { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }
        public string About { get; set; }
        public string OnlineStatus { get; set; }
    }
}
