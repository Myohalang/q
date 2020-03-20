using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex010
    {
        public void Run()
        {
            Random rand = new Random();
            int number = rand.Next(0, 256);
            byte input = 0;

            while (true)
            {
                Write("제가 생각하는 숫자를 맞춰보세요. : ");


                try
                {
                    input = Convert.ToByte(ReadLine());
                }
                catch (FormatException e)
                {
                    WriteLine($"Format Exception : {e.Message}");

                    continue;
                }
                catch (OverflowException e)
                {
                    WriteLine($"Overflow Exception : {e.Message}");

                    continue;
                }
                
                if (!(number == input))
                {
                    WriteLine("틀렸습니다.");

                    continue;
                }
                else if (number == input)
                {
                    WriteLine("정답입니다.");

                    break;
                }
            }
        }
    }
}
