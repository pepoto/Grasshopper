using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper
{
    public abstract class Weapon : StaticObject, IResource
    {
        protected Weapon(string imageUrl, Point location)
            : base(imageUrl, location)
        {
        }
        public int Quantity
        {
            get { return this.Power; }
        }

        public ResourceType Type
        {
            get { return ResourceType.Weapon; }
        }


        public int Power { get; set; }
        public bool IsEmpty
        {
            get
            {
                return this.Power <= 0;
            }
        }


    }
}
