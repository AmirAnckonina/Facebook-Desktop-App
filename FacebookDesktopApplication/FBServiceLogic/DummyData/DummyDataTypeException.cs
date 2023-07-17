using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyDataTypeException : Exception
    {
        private const string k_defaultDataTypeExMessage = "The requested data type isn't supported";

        public DummyDataTypeException() 
            : base(k_defaultDataTypeExMessage)
        { 
        }

        public DummyDataTypeException(string i_ErrMessage) 
            : base(i_ErrMessage)
        { 
        }
    }
}
