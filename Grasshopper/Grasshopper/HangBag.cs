using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class HangBag : Weapon,  IResource
    {
        public const int Price = 200;

         public HangBag(string imageUrl, Point location)
            : base(imageUrl, location)
        {
            base.Power = 200;
        }


    }
}
