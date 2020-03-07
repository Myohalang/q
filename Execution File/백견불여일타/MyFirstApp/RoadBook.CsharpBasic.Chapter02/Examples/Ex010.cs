using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex010
    {
        int globalValue = 20;

        public void Run()
        {
            int localValue = 10;

            Sum();
            Multiple();

            WriteLine($"local : {localValue} / global : {globalValue}");
        }

        private void Sum()
        {
            globalValue = globalValue + 10;
        }

        private void Multiple()
        {
            globalValue = globalValue * 2;
        }
    }
}
