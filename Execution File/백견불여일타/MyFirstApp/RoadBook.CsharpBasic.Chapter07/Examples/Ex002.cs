using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex002
    {
        public void Run()
        {
            List<string> strList = new List<string>();

            strList.Add("Hi");
            WriteLine(strList[0]);

            strList.Clear();
            WriteLine(strList[0]);
        }
    }
}
