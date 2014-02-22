using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public class BGmom : MovingObject
    {
        private string name;
        private int price;
        public Weapons weapon;
        
        public int Price
        {
            get { return this.price;}
            set {this.Price= price;}
        }
        public string Name
        {
            get{return this.name;}
            set{this.Name = name;}
        }
        public BGmom (string name,string imageUmrl,Point location,Weapons weapon,int price)
            :base(imageUmrl,location)
        {
            this.Name = name;
            this.Price = price;
            this.weapon = weapon;
        }
    }
}
