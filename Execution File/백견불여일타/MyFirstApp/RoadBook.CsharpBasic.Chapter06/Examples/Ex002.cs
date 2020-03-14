using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex002
    {
        public void Run()
        {
            // 배열 선언
            string[] weathers = new string[7];

            // 배열 초기 값 입력
            weathers[0] = "sunny";
            weathers[1] = "sunny";
            weathers[2] = "rainy";
            weathers[3] = "cloudy";
            weathers[4] = "rainy";
            weathers[5] = "snow";
            weathers[6] = "sunny";

            // 배열 가져오기
            int dayCount = weathers.Length;

            int sunnyCnt = 0;
            int cloudyCnt = 0;
            int rainyCnt = 0;
            int snowCnt = 0;

            for (int idx = 0; idx < dayCount; idx++)
            {
                string weather = weathers[idx];

                if (weather == "sunny")
                {
                    sunnyCnt++;
                }
                else if (weather == "cloudy")
                {
                    cloudyCnt++;
                }
                else if (weather == "rainy")
                {
                    rainyCnt++;
                }
                else if (weather == "snowCnt")
                {
                    snowCnt++;
                }
            }

            WriteLine($"맑음 : {sunnyCnt} / 흐림 : {cloudyCnt} / 비 : {rainyCnt} / 눈 : {snowCnt}");
        }
    }
}
