using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DTOs
{
    public class GroupDTO : TextAndImageDTO
    {
        public string Privacy { get; set; }

        public int MembersCount { get; set; }
    }
}
