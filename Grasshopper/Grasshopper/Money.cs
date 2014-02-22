using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Money : StaticObject, IResource
    {

        public int Quantity
        {
            get { throw new NotImplementedException(); }
        }

        public ResourceType Type
        {
            get { return ResourceType.Payment; }
        }
    }

       
}
