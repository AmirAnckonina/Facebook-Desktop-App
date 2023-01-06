using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyGroup : DummyBasic
    {
        public DummyGroup()
        { }

        //public string Name { get; set; }
        //public string PictureURL { get; set; }
        public int MembersCount { get; set; }
        public eGroupPrivacy Privacy { get; set; }
    }
}
