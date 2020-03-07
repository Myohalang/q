using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex012
    {
        public void Run()
        {
            Write("숫자를 입력해 보세요 : ");
            string str = ReadLine();
            double compareNumber1 = Convert.ToDouble(str);
            Write("두번째 숫자를 입력해 보세요 :");
            string str2 = ReadLine();
            double compareNumber2 = Convert.ToDouble(str2);

            if (compareNumber1 > compareNumber2)
            {
                WriteLine("True");
            }
            else
            {
                WriteLine("False");
            }
        }
    }
}
