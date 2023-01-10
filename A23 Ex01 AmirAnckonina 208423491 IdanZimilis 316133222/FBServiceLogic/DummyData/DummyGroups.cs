using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyGroups : IDummyData
    {
        public DummyGroups()
        {
            this.Groups = createDummyGroups();
        }

        public List<DummyGroup> Groups { get; set; }

        private List<DummyGroup> createDummyGroups()
        {
            List<DummyGroup> dummyGroups = new List<DummyGroup>();
            DummyGroup group;

            group = new DummyGroup
            {
                Name = "DP.COURSE.MTA.A23",
                PictureURL = "https://www.pngitem.com/pimgs/m/105-1052269_facebook-groups-facebook-groups-logo-png-transparent-png.png",
                MembersCount = 23,
                Privacy = eGroupPrivacy.Closed
            };
            dummyGroups.Add(group);

            group = new DummyGroup
            {
                Name = "Maccabi Haifa Fans",
                PictureURL = "https://upload.wikimedia.org/wikipedia/en/d/db/Maccabi_Haifa_FC_Logo_2020.png",
                MembersCount = 6000,
                Privacy = eGroupPrivacy.Open
            };
            dummyGroups.Add(group);

            group = new DummyGroup
            {
                Name = "Pregnant Women Tel Aviv",
                MembersCount = 6000,
                Privacy = eGroupPrivacy.Secret,
                PictureURL = "https://wwwen.uni.lu/var/storage/images/media/images/lcl_images/no_picture/1416637-1-fre-FR/no_picture.png"
            };
            dummyGroups.Add(group);

            return dummyGroups;
        }
    }
}
