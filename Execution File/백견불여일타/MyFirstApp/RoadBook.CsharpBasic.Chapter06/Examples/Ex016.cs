using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex016
    {
        public void Run()
        {
            Stack<string> stk = new Stack<string>();

            WriteLine("시작점");

            for (int idx = 1; idx < 11; idx++)
            {
                WriteLine($"{idx}번 선수 도착");
                stk.Push(String.Format($"{idx}번 선수"));
            }

            WriteLine("5 ~ 10번 선수는 탈락합니다.");

            for (int idx = 0; idx < 6; idx++)
            {
                stk.Pop();
            }

            WriteLine("올림픽 대표선수 명단");

            foreach (dynamic dyn in stk)
            {
                WriteLine(dyn);
            }
        }
    }
}
