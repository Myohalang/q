using System.Collections;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex007
    {
        public void Run()
        {
            ArrayList aList = new ArrayList();

            for (int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx);
            }

            for (int idx = 10; idx < 15; idx++)
            {
                aList.Add(idx.ToString());
            }

            aList.Insert(5, "100");

            for (int idx = 0; idx < aList.Count; idx++)
            {
                WriteLine($"Value : {aList[idx]} / Type : {aList[idx].GetType()}");
            }

            aList.RemoveAt(5);

            for (int idx = 0; idx < aList.Count; idx++)
            {
                WriteLine($"{aList[idx]} / Type : {aList[idx].GetType()}");
            }
        }
    }
}
