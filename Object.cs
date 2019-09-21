using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeAI
{
    public class Object
    {
        private int x;
        private int y;

        private int height;
        private int width;

        private int minSpeed;
        private int maxSpeed;

        private String color;

        public Object(int x, int y, int height, int width, int minSpeed, int maxSpeed, String color)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.minSpeed = minSpeed;
            this.maxSpeed = maxSpeed;
            this.color = color;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int MinSpeed
        {
            get { return minSpeed; }
            set { minSpeed = value; }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
