using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex011
    {
        public void Run()
        {
            WriteLine("입력한 숫자의 팩토리얼(!)을 계산합니다.");
            Write("입력 : ");

            long number = Convert.ToInt64(ReadLine());
            long index = 1;

            for (long facNumber = number; facNumber > 0; facNumber--)
            {
                index *= facNumber;
            }

            WriteLine($"{number}! : {index}");
        }
    }
}
