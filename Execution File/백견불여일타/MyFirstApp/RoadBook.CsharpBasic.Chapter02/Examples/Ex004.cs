using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex004
    {
        public void Run()
        {
            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;

            WriteLine($"object 변수 값은 {objValue}");
            WriteLine($"var 변수 값은 {vValue}");
            WriteLine($"dynamic 변수 값은 {dValue}");
        }
    }
}
