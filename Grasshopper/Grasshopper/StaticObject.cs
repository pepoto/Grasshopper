﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public abstract class StaticObject : GameObject
    {
        protected StaticObject(string imageUrl, Point location)
            : base(imageUrl, location)
        {
        }


    }
}
