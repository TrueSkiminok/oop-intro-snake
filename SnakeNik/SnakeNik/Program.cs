﻿using System;
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
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line1 = new HorizontalLine(0, 40, 0,  '+');
            line1.Draw();

            HorizontalLine line2 = new HorizontalLine(0, 40, 20,  '+');
            line2.Draw();

            VerticalLine line3 = new VerticalLine(0, 0, 20,  '+');
            line3.Draw();

            VerticalLine line4 = new VerticalLine(40, 0, 20,  '+');
            line4.Draw();



            Console.ReadLine();
        }



    }
}
