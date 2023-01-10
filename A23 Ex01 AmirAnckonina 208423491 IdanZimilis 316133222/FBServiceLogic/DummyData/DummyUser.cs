using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyUser : DummyBasic, IDummyData
    {
        public string Hometown { get; set; }

        public string Education { get; set; }

        public eOnlineStatus OnlineStatus { get; set; }

        public static DummyUser createDummyInfoForCurrentUser()
        {
            DummyUser newDummyUser = new DummyUser
            {
                Name = "MyDummyName",
                PictureURL = "https://i.natgeofe.com/n/4f5aaece-3300-41a4-b2a8-ed2708a0a27c/domestic-dog_thumb_4x3.jpg",
                Hometown = "Givatayim",
                Education = "Jaffa College",
                OnlineStatus = eOnlineStatus.active
            };

            return newDummyUser;
        }
    }
}