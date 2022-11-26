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

        public PostDTO()
        {

        }

        /*public PostDTO(string i_Message, string i_Caption, DateTime? i_DateTime)
        {
            Message = i_Message;
            Caption = i_Message;
            CreatedTime = i_DateTime;
        }*/

        
        

    }
}
