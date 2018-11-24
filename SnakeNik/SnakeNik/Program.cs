using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeNik
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 80;
            const int height = 25;

            Console.SetBufferSize(width, height);
            Console.SetWindowSize(width, height);

            Walls walls = new Walls(width, height);
            walls.Draw();

            // Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //отрисовка еды
            FoodCreator foodCreator = new FoodCreator(width, height, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            bool @continue = true;
            while (@continue)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    @continue = false;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    if (key.Key == ConsoleKey.Escape)
                    {
                        @continue = false;
                    }
                }
                Thread.Sleep(100);
                snake.Move();
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();

                }
            }

            Console.ReadLine();
        }
    }
}
