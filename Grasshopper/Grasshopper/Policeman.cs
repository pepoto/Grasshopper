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
        //public Policeman(int row,int col)
        //    :base(row,col)
        //{ }

        //public MovingObject position;
        //public char body;
        //public ConsoleColor background;
        //public ConsoleColor foreground;
        //public int lifes;
        //public int speed;
        //public Direction dir;
        //public int moveCount;

        //public Policeman(GameObject myPos, int life = 1)
            
        //{
        //    //this.position.col = myPos.col;
        //    //this.position.row = myPos.row;
        //    //this.lifes = life;
        //    //this.body = 'P';
        //    //this.speed = 3;
        //    //this.dir = Direction.up;
        //    //this.moveCount = 0;
        //    //this.background = ConsoleColor.Magenta;
        //    //this.foreground = ConsoleColor.White;
        //}
    }
}
