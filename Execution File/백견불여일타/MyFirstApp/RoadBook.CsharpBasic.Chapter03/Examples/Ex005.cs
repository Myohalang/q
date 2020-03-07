using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex005
    {
        public void Run()
        {
            Write("숫자를 입력하세요 : ");
            double number = Convert.ToDouble(ReadLine());

            if (number > 0)
            {
                WriteLine($"{number}은 양수입니다.");
                even_odd_number_discrimination(number);
            }
            else if (number < 0)
            {
                WriteLine($"{number}은 음수입니다.");
                even_odd_number_discrimination(number);
            }
            else
            {
                WriteLine($"{number}은 0입니다.");
            }
        }

        private void even_odd_number_discrimination(double number)
        {
            double even_odd = number % 2;
            if (even_odd > 0)
            {
                WriteLine($"{number}은 홀수입니다.");
            }
            else
            {
                WriteLine($"{number}은 짝수입니다.");
            }
        }
    }
}
