using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class BGmom : MovingObject
    {
        public  string Name { get; set;}
        
        public BGmom (string name,string imageUmrl,Point location)
            :base(imageUmrl,location)
        {
            this.Name = name;
        }
    }
}
