using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyUser
    {
        public string Name { get; set; }
        public string Hometown { get; set; }
        public string Education { get; set; }
        public string PictureURL { get; set; }
        public eOnlineStatus OnlineStatus { get; set; }
        public List<DummyGroup> Groups { get; set; } = new List<DummyGroup>();

        public DummyUser() 
        { }

        public DummyUser(
            string i_Name,
            string i_Hometown,
            string i_Education,
            string i_PictureURL,
            eOnlineStatus i_OnlineStatus = eOnlineStatus.unknown,
            List<DummyGroup> i_DummyGroups = null
            )
        {
            Name = i_Name;
            Hometown = i_Hometown;
            Education = i_Education;
            PictureURL = i_PictureURL;
            OnlineStatus = i_OnlineStatus;
            Groups = i_DummyGroups;
        }
    }
}
