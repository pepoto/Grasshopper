using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Grasshopper
{
    public abstract class GameObject : IDrawable
    {
        private string imageUrl;
        public int row;
        public int col;
        static ConsoleColor fieldGroundColor = ConsoleColor.Gray;
        static ConsoleColor fieldLinesColor = ConsoleColor.Black;
        public static void PlayerField(char[,] matrix)
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
        public static void DrawPlayerField(char[,] matrix)
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
        public string ImageURL
        {
            get { return this.imageUrl; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("URL cannot be null.");
                }

                this.imageUrl = value;
            }
        }

        
        public GameObject() { }
        public bool IsAvailable { get; protected set; }

        public Point Location { get; protected set; }

        protected GameObject(string imageUrl, Point location)
        {
            this.ImageURL = imageUrl;
            this.Location = location;
            this.IsAvailable = true;
        }

        
    }
}