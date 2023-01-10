using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyGroup : DummyBasic
    {
        public int MembersCount { get; set; }

        public eGroupPrivacy Privacy { get; set; }
    }
}
