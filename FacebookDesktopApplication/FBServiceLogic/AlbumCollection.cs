using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBServiceLogic.DTOs;

namespace FBServiceLogic
{
    public class AlbumCollection : IEnumerable<Album>
    {
        private readonly FacebookObjectCollection<Album> r_Albums;

        public AlbumCollection(FacebookObjectCollection<Album> i_Albums)
        {
            r_Albums = i_Albums;
        }

        public IEnumerator<Album> GetEnumerator()
        {
            for (int i = 0; i < r_Albums.Count; i++)
            {
                if (r_Albums[i].Count > 7)
                {
                    yield return r_Albums[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
