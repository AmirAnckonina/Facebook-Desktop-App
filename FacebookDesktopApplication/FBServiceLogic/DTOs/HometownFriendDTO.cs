using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBServiceLogic.DummyData;

namespace FBServiceLogic.DTOs
{
    public class HometownFriendDTO : TextAndImageDTO
    {
        public string Hometown { get; set; }

        public eOnlineStatus Status { get; set; }
    }
}