using FBServiceLogic.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic
{
    public class AlbumCollection : IEnumerable<TextAndImageDTO>
    {
        private readonly List<TextAndImageDTO> m_AlbumsDTO;

        public AlbumCollection(List<TextAndImageDTO> i_AlbumsDTO)
        {
            m_AlbumsDTO = i_AlbumsDTO;
        }
        public IEnumerator<TextAndImageDTO> GetEnumerator()
        {
            for (int i = 0; i < m_AlbumsDTO.Count; i++)
            {
                yield return m_AlbumsDTO[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
