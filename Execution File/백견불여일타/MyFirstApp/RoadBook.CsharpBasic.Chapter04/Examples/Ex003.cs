using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex003
    {
        const int number = 2;

        public void Run()
        {
            for (int index = 1; index < 10; index++)
            {
                WriteLine($"{number} * {index} = {number * index}");
            }
        }
    }
}
