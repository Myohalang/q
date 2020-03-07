using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex001
    {
        public void Run()
        {
            // 정수
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 10000;
            long longNumber = 50000;

            // 실수
            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;

            WriteLine($"정수 : {shortByteNumber}, {byteNumber}, {shortNumber}, {intNumber}, {longNumber}");

            WriteLine($"실수 : {floatNumber}, {doubleNumber}, {decimalNumber}");
        }
    }
}
