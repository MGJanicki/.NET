using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum colors {RED, GREEN, BLUE}

namespace PAIN.NET
{
    public class Point
    {
        private string name;
        private int x, y;
        private colors color;

        public Point()
        {
            name = "";
            x = 0;
            y = 0;
            color = colors.RED;
        }

        public Point(string name, int x, int y, colors color)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public string GetName()
        {
            return name;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public colors GetColor()
        {
            return color;
        }
    }
}
