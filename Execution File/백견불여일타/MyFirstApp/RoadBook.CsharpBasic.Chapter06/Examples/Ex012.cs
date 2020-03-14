using System;
using System.Collections.Generic;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex012
    {
        public void Run()
        {
            List<int> aList = new List<int>();

            for (int idx = 0; idx < 15; idx++)
            {
                aList.Add(idx);
            }

            aList.Insert(5, 100);

            for (int idx = 0; idx < aList.Count; idx++)
            {
                WriteLine($"Value : {aList[idx]} / Type : {aList[idx].GetType()}");
            }

            aList.RemoveAt(5);

            WriteLine();

            for (int idx = 0; idx < aList.Count; idx++)
            {
                WriteLine($"Value : {aList[idx]} / Type : {aList[idx].GetType()}");
            }
        }
    }
}
