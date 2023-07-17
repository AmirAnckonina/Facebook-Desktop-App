using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.SortFriendsStrategy
{
    public class DescendingComparer : IComparer
    {
        public bool ShouldSwap(string i_Name1, string i_Name2)
        {
            bool shouldSwap;
            bool ignoreCase = true;

            if (string.Compare(i_Name2, i_Name1, ignoreCase) > 0)
            {
                shouldSwap = true;
            }
            else
            {
                shouldSwap = false;
            }

            return shouldSwap;  
        }
    }
}
