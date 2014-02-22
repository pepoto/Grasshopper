using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Umbrella : Weapon,  IResource
    {
        public const int Price = 50;

        public Umbrella(string imageUrl, Point location)
            : base(imageUrl, location)
        {
            base.Power = 200;
        }

        
    }
}
