using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex018
    {
        public void Run()
        {
            int[] ages = new int[10];

            for (int idx = 1; idx < 11; idx++)
            {
                WriteLine($"{idx}번째 사람의 나이를 입력하세요. : ");

                ages[idx] = Convert.ToInt32(ReadLine());
            }

            WriteLine("나이 입력이 완료되었습니다.");

            int twentiesLess = 0;
            int twenties = 0;
            int thirties = 0;
            int forties = 0;
            int fifties = 0;
            int sixtiesMore = 0;

            for (int idx = 0; idx < ages.Length; idx++)
            {
                if (ages[idx] < 20)
                {
                    twentiesLess++;
                }
                else if (ages[idx] >= 20 && ages[idx] < 30)
                {
                    twenties++;
                }
                else if (ages[idx] >= 30 && ages[idx] < 40)
                {
                    thirties++;
                }
                else if (ages[idx] >= 40 && ages[idx] < 50)
                {
                    forties++;
                }
                else if (ages[idx] >= 50 && ages[idx] < 60)
                {
                    fifties++;
                }
                else if (ages[idx] >= 60)
                {
                    sixtiesMore++;
                }
            }

            WriteLine($"20대 미만 : {twentiesLess}명");
            WriteLine($"20대 : {twenties}명");
            WriteLine($"30대 : {thirties}명");
            WriteLine($"40대 : {forties}명");
            WriteLine($"50대 : {fifties}명");
            WriteLine($"60대 이상 : {sixtiesMore}명");
        }
    }
}
