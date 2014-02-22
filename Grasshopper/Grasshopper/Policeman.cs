using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Policeman : Character
    {
        public Policeman(string name,string imageUrl,Point location, int strength,int defense)
            :base(name,imageUrl,location,strength,defense)
        { }
    }
}
