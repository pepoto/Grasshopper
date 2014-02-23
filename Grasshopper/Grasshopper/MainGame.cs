using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grasshopper
{

    class MainGame
    {
        const int MAX_WIDTH = 75;
        const int MAX_HEIGHT = 23;
        static char[,] playerField = new char[MAX_HEIGHT, MAX_WIDTH];
         //static Policeman playerFieldPosition = new Policeman(12, 0);
       
        //static void PrintGad(Policeman gad)
        //{
        //    playerField[gad.position.row, gad.position.col] = gad.body;
        //    Console.SetCursorPosition(gad.position.col + playerFieldPosition.col, gad.position.row + playerFieldPosition.row);
        //    Console.BackgroundColor = gad.background;
        //    Console.ForegroundColor = gad.foreground;
        //    Console.Write(gad.body);
        //}
        static void Main ()
        {
            
                GameObject.PlayerField(playerField);
                GameObject.DrawPlayerField(playerField);
            
            
            //Policeman gad = new Policeman(new Policeman(7, 7), 1);
            //gad.dir = Direction.up;
            //gadsList.Add(gad);
            
        }



    }
}
