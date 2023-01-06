using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyDataTypeException : Exception
    {
        public DummyDataTypeException(string i_ErrMessage) : base(i_ErrMessage)
        { }
    }
}
