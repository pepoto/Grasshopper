using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper
{
    public class Syringe : Weapon, IResource
    {
        public const int Price = 50;

        public Syringe(string imageUrl, Point location)
            : base(imageUrl, location)
        {
            base.Power = 200;

        }

       
    }
}
