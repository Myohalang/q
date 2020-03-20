using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex003
    {
        public void Run()
        {
            Write("숫자를 입력하세요 : ");

            try
            {
                int number = Convert.ToInt32(ReadLine());

                WriteLine($"입력된 숫자는 {number}");
            }
            catch (Exception)
            {
                WriteLine("예외상황 발생");
            }
            

        }
    }
}
