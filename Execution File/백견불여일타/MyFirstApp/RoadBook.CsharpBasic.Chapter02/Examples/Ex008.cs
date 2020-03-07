using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex008
    {
        public void Run()
        {
            int number01 = 10;
            double number02 = number01;
            int number03 = (int)number02;

            WriteLine($"number01 변수의 타입은 {number01.GetType()}");
            WriteLine($"number02 변수의 타입은 {number02.GetType()}");
            WriteLine($"number03 변수의 타입은 {number03.GetType()}");
        }
    }
}
