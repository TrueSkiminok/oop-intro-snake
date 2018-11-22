using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNik
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(7, 0, '^');
            Point p4 = new Point(6, 6, '&');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (var item in pList)
            {
                item.Draw();
            }

            Console.ReadLine();
        }



    }
}
