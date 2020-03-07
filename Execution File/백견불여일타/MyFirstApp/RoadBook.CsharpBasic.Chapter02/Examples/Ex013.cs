using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex013
    {
        public void Run()
        {
            Write("숫자를 입력해 보세요 : ");
            dynamic calNumber = Convert.ToDouble(ReadLine());
            Write("두번째 숫자를 입력해 보세요 :");
            dynamic calNumber2 = Convert.ToDouble(ReadLine());

            Sum(calNumber, calNumber2);
            Minus(calNumber, calNumber2);
            Multiple(calNumber, calNumber2);
            Divide(calNumber, calNumber2);
        }

        void Sum(dynamic calNumber, dynamic calNumber2)
        {
            WriteLine($"Sum : {calNumber + calNumber2}");
        }

        void Minus(dynamic calNumber, dynamic calNumber2)
        {
            WriteLine($"Minus : {calNumber - calNumber2}");
        }

        void Multiple(dynamic calNumber, dynamic calNumber2)
        {
            WriteLine($"Multiple : {calNumber * calNumber2}");
        }

        void Divide(dynamic calNumber, dynamic calNumber2)
        {
            WriteLine($"Divide : {calNumber / calNumber2}");
        }
        
    }
}
