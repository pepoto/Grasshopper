using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class BGmom : Character
    {
        public  string Name { get; set;}
        

        protected BGmom(string name, string imageUrl, Point location, int defense) : base(name, imageUrl, location, defense)
        {
        }


    }
}
