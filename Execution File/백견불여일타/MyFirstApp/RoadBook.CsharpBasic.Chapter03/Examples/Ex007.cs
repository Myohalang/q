using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex007
    {
        public void Run()
        {
            Write("숫자를 입력하세요 : ");
            int number = Convert.ToInt32(ReadLine());

            bool isEvenNumber = ((number % 2 == 0) ? true : false);

            if (number > 0 && isEvenNumber)
            {
                WriteLine($"{number}은 양의 짝수입니다.");
            }
            else if (number > 0 && !isEvenNumber)
            {
                WriteLine($"{number}은 양의 홀수입니다.");
            }
            else if (number < 0 && isEvenNumber)
            {
                WriteLine($"{number}은 음의 짝수입니다.");
            }
            else if (number < 0 && !isEvenNumber)
            {
                WriteLine($"{number}은 음의 홀수입니다.");
            }
            else
            {
                WriteLine($"{number}은 zere입니다.");
            }
        }
    }
}
