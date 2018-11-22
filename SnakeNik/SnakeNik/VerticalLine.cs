using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNik
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yLeft, int yRight, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                pList.Add(new Point(x, y, sym));
            }

        }

        public void Draw()
        {
            foreach (var item in pList)
            {
                item.Draw();
            }
        }
    }
}
