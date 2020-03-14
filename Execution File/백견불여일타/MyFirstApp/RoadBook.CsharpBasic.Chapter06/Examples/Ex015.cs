using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex015
    {
        public void Run()
        {
            Queue<string> que = new Queue<string>();

            for (int idx = 1; idx < 11; idx++)
            {
                que.Enqueue(string.Format($"{idx}번 승객"));
            }

            WriteLine("정류장 승객 현황");

            foreach (dynamic dyn in que)
            {
                WriteLine(dyn);
            }

            WriteLine("버스가 도착했습니다. (6명 승차 가능)");

            for (int idx = 0; idx < 6; idx++)
            {
                que.Dequeue();
            }

            WriteLine("버스가 출발했습니다.");
            WriteLine("새로운 승객이 줄을 섭니다.");

            que.Enqueue("새로운 승객");

            WriteLine("정류장 승객 현황");

            foreach (dynamic dyn in que)
            {
                WriteLine(dyn);
            }


        }
    }
}
