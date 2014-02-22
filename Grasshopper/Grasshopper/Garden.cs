using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Garden : StaticObject
    {
        public Garden(string imageUrl, Point location)
            : base(imageUrl, location)
        {
        }
    }
}
