using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex001
    {
        public void Run()
        {
            string weather = "sunny,sunny,rainy,cloudy,rainy,snow,sunny";

            var weathers = weather.Split(',');

            WriteLine(weather.GetType());
            WriteLine(weathers.GetType());
        }
    }
}
