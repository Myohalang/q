using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex005
    {
        public void Run()
        {
            Sum(1, 1);
            Sum(2, 2);
            Sum(3, 3);
        }

        private void Sum(int number01, int number02)
        {
            WriteLine($"{number01} + {number02} = {number01 + number02}");
        }
    }
}
