using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyCurrentUser : DummyUser
    {
        public List<DummyUser> Friends { get; set; }
    }
}
