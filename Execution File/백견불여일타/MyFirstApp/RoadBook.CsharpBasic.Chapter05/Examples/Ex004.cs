using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    // 객체에서 '형태'를 나타내는 것을 프로퍼티(property, 속성)라고 하고, '행동'을 나타내는 것을 메소드(method)라고 합니다.

    class Ex004
    {
        public void Run()
        {
            Bread custard_cream_bread = new Bread();
            custard_cream_bread.Shape = "별모양";
            custard_cream_bread.Source = "슈크림";

            WriteLine($"{custard_cream_bread.Shape} {custard_cream_bread.Source}빵");

            Bread pizza_bread = new Bread();
            pizza_bread.Shape = "네모난";
            pizza_bread.Source = "피자";

            WriteLine($"{pizza_bread.Shape} {pizza_bread.Source}빵");
        }
    }

    class Bread
    {
        public string Shape { get; set; }
        public string Source { get; set; }
    }
}
