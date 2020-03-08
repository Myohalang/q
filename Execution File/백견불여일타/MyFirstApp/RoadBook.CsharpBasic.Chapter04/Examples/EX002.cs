using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex002
    {
        public void Run()
        {
            const int two = 2;

            for (int index = 1 ; ;)
            {
                WriteLine($"{two} * {index} = {two * index}");

                index++;

                if (index == 9)
                {
                    break;
                }
            }
        }
    }
}
