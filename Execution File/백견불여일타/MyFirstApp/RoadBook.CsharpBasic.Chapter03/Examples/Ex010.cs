using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex010
    {
        public void Run()
        {
            Random rand = new Random();
            int randNumber1 = rand.Next(1, 101);
            int randNumber2 = rand.Next(1, 101);
            int answer = randNumber1 + randNumber2;

            Write($"정답을 맞춰보세요. {randNumber1} + {randNumber2} = ");
            int writeAnswer = Convert.ToInt32(ReadLine());

            if (writeAnswer == answer)
            {
                WriteLine("정답입니다.");
            }
            else
            {
                WriteLine("틀렸습니다.");
            }
        }
    }
}
