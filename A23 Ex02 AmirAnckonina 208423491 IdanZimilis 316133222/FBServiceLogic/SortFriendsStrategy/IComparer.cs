using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic
{
    public interface IComparer
    {
        bool ShouldSwap(string i_Name1, string i_Name2);
    }
}
