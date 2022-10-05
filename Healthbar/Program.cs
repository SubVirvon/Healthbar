using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthbar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fillingPrcent;
            int positionX;
            int positionY;

            Console.Write("Введите процент заполненности хилбара: ");
            fillingPrcent = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите величину верхнего отступа: ");
            positionY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите величину левого отступа: ");
            positionX = Convert.ToInt32(Console.ReadLine());

            DrawBar(fillingPrcent, positionY, positionX);
            Console.ReadKey();
        }

        static void DrawBar(int fillingPrcent, int positionY, int positionX)
        {
            int barLenth = 10;
            char filledElement = '#';
            char emptyElement = '_';

            fillingPrcent /= barLenth;
            Console.Clear();
            Console.SetCursorPosition(positionX, positionY);
            Console.Write("[");

            for(int i = 0; i < barLenth; i++)
            {
                if(i < fillingPrcent)
                {
                    Console.Write(filledElement);
                }
                else
                {
                    Console.Write(emptyElement);
                }
            }

            Console.Write(']');
        }
    }
}
