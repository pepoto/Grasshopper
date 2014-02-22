using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Walker : Character
    {
        public Walker(string name, string imageUrl, Point location, int defense)
            :base(name,imageUrl,location,defense)
        { }
    }
}
