using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex006
    {
        public void Run()
        {
            int number01 = 10;
            int number02 = 3;

            dynamic result01 = Sum(number01, number02);
            dynamic result02 = Minus(number01, number02);
            dynamic result03 = Multiple(number01, number02);
            dynamic result04 = Divide(number01, number02);

            WriteLine($"{number01}과 {number02}의 사칙연산 결과 값 : {result01}, {result02}, {result03}, {result04}");
        }

        int Sum(int number01, int number02)
        {
            return number01 + number02;
        }

        int Minus(int number01, int number02)
        {
            return number01 - number02;
        }

        int Multiple(int number01, int number02)
        {
            return number01 * number02;
        }

        double Divide(int number01, int number02)
        {
            return (double)number01 / number02;
        }
    }
}
