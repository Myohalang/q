using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex003
    {
        public void Run()
        {
            // 배열 선언과 동시에 초기화
            string[] weathers = { "sunny", "sunny", "rainy", "cloudy", "rainy", "snow", "sunny" };

            // 배열 가져오기
            int dayCount = weathers.Length;

            int sunnyCnt = 0;
            int cloudyCnt = 0;
            int rainyCnt = 0;
            int snowCnt = 0;

            for (int idx = 0; idx < dayCount; idx++)
            {
                string weather = weathers[idx];

                if (weather == "sunny") sunnyCnt++;
                if (weather == "cloudy") cloudyCnt++;
                if (weather == "rainy") rainyCnt++;
                if (weather == "snowCnt") snowCnt++;
            }

            WriteLine($"맑음 : {sunnyCnt} / 흐림 : {cloudyCnt} / 비 : {rainyCnt} / 눈 : {snowCnt}");
        }
    }
}
