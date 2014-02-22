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