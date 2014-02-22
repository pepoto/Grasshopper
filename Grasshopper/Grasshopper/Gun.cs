﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Gun : StaticObject, IResource
    {
        public const int Price = 200;

         public Gun(string imageUrl, Point location)
            : base(imageUrl, location)
        {
        }


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
