using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DTOs
{
    class PostDTO
    {
        private string Message { get; }
        private string Caption { get; }

        public PostDTO(string i_Message, string i_Caption)
        {
            Message = i_Message;
            Caption = i_Message;
        }

    }
}
