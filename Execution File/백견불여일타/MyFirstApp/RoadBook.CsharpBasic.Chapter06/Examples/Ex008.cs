using System.Collections;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex008
    {
        public void Run()
        {
            Queue que = new Queue();

            for (int idx = 1; idx < 11; idx++)
            {
                que.Enqueue(idx);
            }

            WriteLine("정류장 승객 현황");

            foreach (object obj in que)
            {
                WriteLine(obj.ToString());
            }

            WriteLine("===================");
            WriteLine("버스가 도착했습니다. (6명 승차 가능)");

            for (int i = 0; i < 6; i++)
            {
                que.Dequeue();
            }

            WriteLine("버스가 출발했습니다.");
            WriteLine("===================");

            WriteLine("새로운 승객이 줄을 섭니다.");
            que.Enqueue("새로운 승객");

            WriteLine("정류장 승객 현황");

            foreach (object obj in que)
            {
                WriteLine(obj.ToString());
            }

            WriteLine("===================");
        }
    }
}
