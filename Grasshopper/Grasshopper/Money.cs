using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class Money : StaticObject, IResource
    {
        private int amount; 

        public Money(string imageUrl, Point location, int amount)
            : base(imageUrl, location)
        {
            this.amount = amount;
        }

        public int Quantity
        {
            get { return this.amount; }
        }

        public ResourceType Type
        {
            get { return ResourceType.Payment; }
        }
    }

       
}
