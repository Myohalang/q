using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex012
    {
        public void Run()
        {
            Random rand = new Random();
            int random = rand.Next(1, 51);
            int input;

            WriteLine("제가 생각하고 있는 1 ~ 50 사이의 숫자를 맞춰보세요.");

            while (random != (input = Convert.ToInt32(ReadLine())))
            {
                if (input > random)
                {
                    WriteLine("틀렸습니다. Down!");
                }
                else
                {
                    WriteLine("틀렸습니다. UP!");
                }
            }

            WriteLine("정답입니다!");
        }
    }
}
