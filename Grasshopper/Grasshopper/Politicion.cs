using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grasshopper
{
    public struct Politicion 
    {
        public Position position;
        public char body;
        public ConsoleColor background;
        public ConsoleColor foreground;
        public int lifes;
        public int speed;
        public Direction dir;
        public int moveCount;

        public Politicion(Position myPos, int life = 1)
        {
            this.position.col = myPos.col;
            this.position.row = myPos.row;
            this.lifes = life;
            this.body = 'P';
            this.speed = 3;
            this.dir = Direction.left;
            this.moveCount = 0;
            this.background = ConsoleColor.Magenta;
            this.foreground = ConsoleColor.Blue;
        }
    }
}
