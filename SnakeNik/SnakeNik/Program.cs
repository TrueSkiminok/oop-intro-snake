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

            Console.SetBufferSize(80, 25);

            // Отрисовка рамок
            HorizontalLine line1 = new HorizontalLine(0, 78, 0, '+');
            line1.Draw();

            HorizontalLine line2 = new HorizontalLine(0, 78, 24, '+');
            line2.Draw();

            VerticalLine line3 = new VerticalLine(0, 24, 0, '+');
            line3.Draw();

            VerticalLine line4 = new VerticalLine(0, 24, 78, '+');
            line4.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
