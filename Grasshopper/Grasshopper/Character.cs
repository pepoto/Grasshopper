using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Grasshopper
{
    public enum Direction { up,down,left,rigth}
    public abstract class Character : GameObject
    {
        public string Name { get; private set; }

        public int Strength { get; private set; }

        public int Defense { get; private set; }

        protected Character() { }

        public int Row
        {
            get;
            set;
        }
        public int Col
        {
            get;
            set;
        }
        public Character(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
        protected  Character(string name, string imageUrl, Point location, int defense)
            : base(imageUrl, location)
        {
            this.Name = name;
            
            this.Defense = defense;
        }
        protected Character(string name, string imageUrl, Point location, int strength, int defense)
            : base(imageUrl, location)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
        }
    }
}