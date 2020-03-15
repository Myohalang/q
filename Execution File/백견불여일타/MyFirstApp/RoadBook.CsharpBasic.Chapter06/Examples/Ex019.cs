using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex019
    {
        public void Run()
        {
            List<int> aList = new List<int>();

            for (int idx = 0; idx < 5; idx++)
            {
                Write($"{idx + 1}번째 숫자를 입력해주세요. : ");

                aList.Add(Convert.ToInt32(ReadLine()));
            }

            aList.Sort();

            Write($"오름차순 정렬 결과 : ");

            for (int idx = 0; idx < aList.Count; idx++)
            {
                Write($"{aList[idx]}");
                
                if ((idx + 1) < aList.Count)
                {
                    Write(", ");
                }
            }

            WriteLine();
        }
    }
}
