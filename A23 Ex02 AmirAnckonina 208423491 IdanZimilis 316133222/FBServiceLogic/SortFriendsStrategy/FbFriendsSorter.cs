using FBServiceLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic
{
    public class FbFriendsSorter
    {
        public IComparer Comparer { get; set; }

        public FbFriendsSorter()
        {
        }

        public void SortFriends(List<FriendDTO> io_FriendsList)
        {
            for (int g = io_FriendsList.Count / 2; g > 0; g /= 2)
            {
                for (int i = g; i < io_FriendsList.Count; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (Comparer.ShouldSwap(io_FriendsList[j].Name, io_FriendsList[j + g].Name))
                        {
                            //doSwap(i_FriendsList[j], i_FriendsList[j + g]);
                            doSwap(io_FriendsList, j, j + g); //.doSwap<FriendDTO>()
                        }
                    }
                }
            }
        }

        private void doSwap<T>(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
