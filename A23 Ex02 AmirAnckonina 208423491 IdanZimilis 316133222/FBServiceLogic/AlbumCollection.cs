using FBServiceLogic.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FBServiceLogic
{
    public class AlbumCollection : IEnumerable<Album>
    {
        private readonly FacebookObjectCollection<Album> m_Albums;

        //public AlbumCollection(List<TextAndImageDTO> i_AlbumsDTO)
        public AlbumCollection(FacebookObjectCollection<Album> i_Albums)
        {
            m_Albums = i_Albums;
        }

        public IEnumerator<Album> GetEnumerator()
        {
            for (int i = 0; i < m_Albums.Count; i++)
            {
                if (m_Albums[i].Count > 7)
                {
                    yield return m_Albums[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
