using System;
using static System.Console;
using RoadBook.CsharpBasic.Chapter07.Examples.UserException;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex008
    {
        public void Run()
        {
            Write("두 개의 숫자를 입력하세요 : ");

            try
            {
                int number01 = Convert.ToInt32(ReadLine());
                int number02 = Convert.ToInt32(ReadLine());

                WriteLine(Divide(number01, number02));
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        private int Divide(int number01, int number02)
        {
            if (number02 == 0)
            {
                throw new MyStyleException("0으로 나눌 수 없습니다.");
            }

            return number01 / number02;
        }
    }
}
