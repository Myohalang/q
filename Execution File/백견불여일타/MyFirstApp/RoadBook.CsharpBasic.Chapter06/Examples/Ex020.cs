using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex020
    {
        public void Run()
        {
            Queue<string> benefit = new Queue<string>();

            WriteLine("몇 명의 인원에게 무료 혜택을 제공할까요?");
            Write("입력 : ");

            int limit = Convert.ToInt32(ReadLine());

            WriteLine("무료 영화 선착순 예매 시스템입니다.");

            while (true)
            {
                WriteLine("이름을 입력해주세요. (q : 종료) : ");

                string name = ReadLine();

                if("q" == name.ToLower())
                {
                    break;
                }

                benefit.Enqueue(name);
            }

            WriteLine("무료 영화 관람권 당첨자는");

            for (int idx = 0; idx < limit; idx++)
            {
                WriteLine(benefit.Dequeue());
            }

            WriteLine("입니다.");
        }
    }
}
