using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex021
    {
        public void Run()
        {
            Dictionary<string, List<string>> group = new Dictionary<string, List<string>>();

            List<string> acountry = new List<string>
            {
                "대한민국",
                "프랑스",
                "미국",
                "이집트"
            };

            List<string> hcountry = new List<string>
            {
                "일본",
                "브라질",
                "독일",
                "스페인"
            };

            group.Add("A", acountry);
            group.Add("H", hcountry);

            while (true)
            {
                WriteLine("조 추첨 결과 어느 조를 조회할까요? (q : 종료) : ");
                string inquiry = ReadLine().ToUpper();

                if ("q" == inquiry.ToLower())
                {
                    WriteLine("종료되었습니다.");
                    break;
                }

                List<string> nation = group[inquiry];
                WriteLine($"{inquiry}조에 속한 나라는");

                for (int idx = 0; idx < nation.Count; idx++)
                {
                    WriteLine(nation[idx]);
                }

                WriteLine("입니다.");
            }
        }
    }
}
