using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex006
    {
        public void Run()
        {
            WriteLine("숫자를 입력하세요");
            int number = Convert.ToInt32(ReadLine());

            if (number > 0)
            {
                WriteLine($"{number}은 양수입니다.");

                if (number % 2 == 0)
                {
                    WriteLine($"{number}은 짝수입니다.");
                }
                else
                {
                    WriteLine($"{number}은 홀수입니다.");
                }
            }
            else if (number < 0)
            {
                WriteLine($"{number}은 음수입니다.");

                if (number % 2 == 0)
                {
                    WriteLine($"{number}은 짝수입니다.");
                }
                else
                {
                    WriteLine($"{number}은 홀수입니다.");
                }
            }
            else
            {
                WriteLine($"{number}은 zere입니다.");
            }
        }
    }
}
