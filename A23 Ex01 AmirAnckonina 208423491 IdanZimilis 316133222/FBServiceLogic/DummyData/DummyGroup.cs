using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyGroup
    {
        public string Name { get; set; }
        public string PictureURL { get; set; }
        public int MembersCount { get; set; }
        public eGroupPrivacy Privacy { get; set; }

        public DummyGroup()
        { }

        public DummyGroup(string i_Name, string i_PictureURL, int i_MemebersCount, eGroupPrivacy i_Privacy = eGroupPrivacy.Open)
        {
            Name = i_Name;
            PictureURL = i_PictureURL;
            MembersCount = i_MemebersCount;
            Privacy = i_Privacy;
        }
    }
}
