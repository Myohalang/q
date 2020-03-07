using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex009
    {
        public void Run()
        {
            string strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber);
            int parseNumber = Int32.Parse(strNumber);

            WriteLine($"{convertNumber} + {parseNumber} + {convertNumber + parseNumber}");
        }
    }
}
