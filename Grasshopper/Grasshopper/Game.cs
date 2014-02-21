using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grasshopper
{
    
    class Game
    {
        const int MAX_WIDTH = 60;
        const int MAX_HEIGHT = 23;
        static char[,] playerField = new char[MAX_HEIGHT, MAX_WIDTH];
        
        static ConsoleColor fieldGroundColor = ConsoleColor.Gray;
        static ConsoleColor fieldLinesColor = ConsoleColor.Black;

        static void DrawPlayerField(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void PlayerField(char[,] matrix)
        {
            char brick = '#';
            // CONSOLE SETTINGS

            Console.BackgroundColor = fieldGroundColor;
            Console.ForegroundColor = fieldLinesColor;

            // FILLING UP matrix[,] ARRAY
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = brick;
                matrix[i, matrix.GetLength(1) - 1] = brick;
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[0, i] = brick;
                matrix[matrix.GetLength(0) - 1, i] = brick;
            }

        }

        static void Main ()
        {
            PlayerField(playerField);
            DrawPlayerField(playerField);
            
        }



    }
}
