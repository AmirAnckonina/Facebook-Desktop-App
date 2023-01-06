using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public abstract class DummyBasic
    {
        public string Name { get; set; }
        public string PictureURL { get; set; }

        public DummyBasic()
        { }
    }
}
