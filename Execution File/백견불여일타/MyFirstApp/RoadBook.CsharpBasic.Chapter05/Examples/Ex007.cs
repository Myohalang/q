using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex007
    {
        public void Run()
        {
            dynamic result = Sum(1, 2, 3, 4, 5);
            WriteLine($"1 ~ 5까지의 합은 {result}");
        }

        int Sum(params int [] number)
        {
            int result = 0;

            for (int idx = 0; idx < number.Length; idx++)
            {
                result += number[idx];
            }

            return result;
        }
    }
}
