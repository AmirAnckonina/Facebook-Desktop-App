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

        public DummyUser()
        {
        }
    }
}
