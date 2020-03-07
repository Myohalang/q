using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex006
    {
        public void Run()
        {
            // #region #endregion은 #region을 누르고 Ctrl + M (2번)

            #region >> 정수형 변수
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 10000;
            long longNumber = 50000;
            #endregion

            #region >> 실수형 변수
            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;
            #endregion

            WriteLine($"정수 : {shortByteNumber}, {byteNumber}, {shortNumber}, {intNumber}, {longNumber}");
            WriteLine($"실수 : {floatNumber}, {doubleNumber}, {decimalNumber}");

            #region >> 문자열 변수
            char ch = 'A';
            string strMessage = "hello Csharp";
            #endregion

            WriteLine(ch);
            WriteLine($"{strMessage[0]}{strMessage[1]}{strMessage[2]}{strMessage[3]}{strMessage[4]}");
            WriteLine(strMessage);

            #region >> 참/거짓 변수
            bool bCalculate01 = (1 + 2 == 3);
            bool bCalculate02 = ((12 > 8) && (8 < 20));
            bool isContainsWord = "Hello Csharp".Contains("Hello");
            #endregion

            WriteLine($"1 + 2 = 3 ? ({bCalculate01})");
            WriteLine($"12는 8보다 크고 8은 20보다 작다 ? ({bCalculate02})");
            WriteLine($"Hello Csharp 문장에 Hello가 포함되어 있다 ? ({isContainsWord})");

            #region >> 만능 변수
            object objHello = "Hello World";
            // object는 데이터에 관계없이 저장은 할 수 있지만, 이 데이터가 정확히 무슨 타입인지 모름(순수한 문자열 함수의 기능을 사용할 수 없음)
            var vHello = "Hello World";
            // var는 한번 데이터가 할당되면 다른 타입으로 변경 불가
            // 프로그램이 컴파일될 때 변수 타입을 인식
            // 기계어로 번역되는 동안 해당 변수의 타입이 무엇인지 판단
            dynamic dHello = "Hello World";
            // dynamic은 데이터를 다른 타입으로 변경 가능
            // 프로그램이 런타임될 때 변수 타입을 인식
            // 프로그램이 실행하면서 자신의 동작 차례가 되었을 때 해당 변수의 타입이 무엇인지 판단
            #endregion

            bool isContainsWord01 = objHello.ToString().Contains("Hello");
            bool isContainsWord02 = vHello.Contains("Hello");
            bool isContainsWord03 = dHello.Contains("Hello");

            WriteLine($"object 변수에 Hello가 포함되어 있다 ? {isContainsWord02}");
            WriteLine($"var 변수에 Hello가 포함되어 있다. ? {isContainsWord02}");
            WriteLine($"dynamic 변수에 Hello가 포함되어 있다 ? {isContainsWord03}");
        }
    }
}
