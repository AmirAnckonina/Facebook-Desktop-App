using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DTOs
{
    public class PostDTO
    {
        public string Message { get; set; }

        public string Caption { get; set; }

        public DateTime? CreatedTime { get; set; }
    }
}
