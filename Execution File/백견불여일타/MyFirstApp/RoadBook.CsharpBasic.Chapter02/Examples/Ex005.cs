using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex005
    {
        public void Run()
        {
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

            bool isContainsWord01 = objHello.ToString().Contains("Hello");
            bool isContainsWord02 = vHello.Contains("Hello");
            bool isContainsWord03 = dHello.Contains("Hello");

            WriteLine($"object 변수에 Hello가 포함되어 있다 ? {isContainsWord02}");
            WriteLine($"var 변수에 Hello가 포함되어 있다. ? {isContainsWord02}");
            WriteLine($"dynamic 변수에 Hello가 포함되어 있다 ? {isContainsWord03}");
        }
    }
}
