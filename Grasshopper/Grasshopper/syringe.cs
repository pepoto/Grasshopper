using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper
{
    public class Syringe : StaticObject, IResource
    {
        public const int Price = 50;

        public int Quantity
        {
            get { throw new NotImplementedException(); }
        }

        public ResourceType Type
        {
            get { return ResourceType.Weapon; }
        }
    }
}
