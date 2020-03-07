using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex004
    {
        public void Run()
        {
            const int number = 0;

            if (number > 0)
            {
                WriteLine($"{number}은 양수입니다.");
            }
            else if (number < 0)
            {
                WriteLine($"{number}은 음수입니다.");
            }
            else
            {
                WriteLine($"{number}은 zero입니다.");
            }
        }
    }
}
