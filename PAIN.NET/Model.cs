using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAIN.NET
{
    public class Model
    {
        public static Model GetInstance()
        {
            if (pInstance == null) pInstance = new Model();
            return pInstance;
        }

        private static Model pInstance;
        public List<Point> points = new List<Point>();
        private Model()
        {
            Point p = new Point("wynik1", 1, 1, colors.RED);
            points.Add(p);
            p = new Point("wynik2", 2, 2, colors.GREEN);
            points.Add(p);
            p = new Point("wynik3", 3, 3, colors.BLUE);
            points.Add(p);
        }
        public void Add(Point p)
        {
            points.Add(p);
        }
    }
}
