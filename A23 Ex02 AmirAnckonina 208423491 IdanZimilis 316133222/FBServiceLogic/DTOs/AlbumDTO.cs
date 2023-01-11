using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DTOs
{
    public class AlbumDTO
    {
        public AlbumDTO(string i_Name, string i_PictureURL)
        {
            Name = i_Name;
            PictureURL = i_PictureURL;
        }
        public  string Name { get; }
        public string PictureURL { get; }
        

    }
}
