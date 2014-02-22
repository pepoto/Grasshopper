using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public abstract class Character : GameObject
    {
        public bool IsAlive { get; protected set; }

        public int Size { get; set; }

        
    }
}
