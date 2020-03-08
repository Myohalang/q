using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex005
    {
        public void Run()
        {
            int index = 1;

            for (int number = 5; number > 0; number--)
            {
                index *= number;
            }

            WriteLine($"5! = {index}");
        }
    }
}
