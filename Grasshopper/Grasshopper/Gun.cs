using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Gun : Weapon, IResource
    {
        public const int Price = 200;
       
         public Gun(string imageUrl, Point location)
            : base(imageUrl, location)
        {
            base.Power = 100;
        }


       
    }
}
