using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DTOs
{
    public class LikedPageDTO : TextAndImageDTO
    {
        public long? LikesCount { get; set; }
    }
}
