﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Grasshopper
{
    public abstract class MovingObject : GameObject, IDrawable
    {
        public int Energy { get; private set; }

        protected MovingObject(string imageUrl, Point location)
            : base(imageUrl, location)
        {
            this.Energy = 100;
        }

        public void GoTo(Point destination)
        {
            int distance = Point.GetManhattanDistance(this.Location, destination);

            if (this.Energy - distance <= 0)
            {
                throw new Exception("Sorry, I don't have enough energy."); // we might need to try/catch this one and we may even make it our own exception
            }

            this.Energy -= distance;

            this.Location = destination;

            this.Rest(DateTime.Now);
        }

        private void Rest(DateTime restingTime)
        {
            // while (being still AND this.Energy < 100) { this.Energy += 1 } for each second
        }
    }
}