using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex001
    {
        public void Run()
        {
            Write("숫자를 입력하세요 : ");

            int number = Convert.ToInt32(ReadLine());

            WriteLine($"입력된 숫자는 {number}");
        }
    }
}
