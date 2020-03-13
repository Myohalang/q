using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex010
    {
        public void Run()
        {
            WriteLine("첫번째 숫자를 입력하세요");
            dynamic number01 = Convert.ToDouble(ReadLine());

            WriteLine("두번째 숫자를 입력하세요");
            dynamic number02 = Convert.ToDouble(ReadLine());

            WriteLine(cal(number01, number02, '+'));
            WriteLine(cal(number01, number02, '-'));
            WriteLine(cal(number01, number02, '*'));
            WriteLine(cal(number01, number02, '/'));
        }

        string cal(dynamic number01, dynamic number02, char type)
        {
            switch (type)
            {
                case '+':
                    {
                        return string.Format($"{number01} + {number02} = {number01 + number02}");
                    }
                case '-':
                    {
                        return string.Format($"{number01} - {number02} = {number01 - number02}");
                    }
                case '*':
                    {
                        return string.Format($"{number01} * {number02} = {number01 * number02}");
                    }
                case '/':
                    {
                        return string.Format($"{number01} / {number02} = {number01 / number02}");
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
}