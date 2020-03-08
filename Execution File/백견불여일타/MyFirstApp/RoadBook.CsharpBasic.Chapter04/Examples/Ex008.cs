using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex008
    {
        public void Run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 11);

            WriteLine("제가 생각하고 있는 1 ~ 10 사이의 수를 맞춰보세요.");
            Write("입력 : ");

            int count = 0;

            while (Convert.ToInt32(ReadLine()) != target_number)
            {
                WriteLine("틀렸어요.");
                count++;
                Write("입력 : ");
            }

            WriteLine($"정답입니다. 맞추기까지 {count}번 소요되었습니다.");
        }
    }
}
