using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex001
    {
        public void Run()
        {
            Car001 car = new Car001();
            car.setSize("세단");
            car.setColor("하얀");

            WriteLine($"고객님의 차, {car.getColor()} {car.getSize()}이...");

            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
    }

    class Car001
    {
        #region 형태

        private string size;
        private string color;
        // private으로 선언된 변수, 메소드는 다른 클래스에서 호출이 불가능

        public void setSize(string size)
        {
            this.size = size;
        }

        public string getSize()
        {
            return size;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        #endregion

        #region 행동

        public void Engine_on()
        {
            WriteLine("시동을 켭니다.");
        }

        public void Engine_off()
        {
            WriteLine("시동을 끕니다.");
        }

        public void Go()
        {
            WriteLine("전진합니다.");
        }

        public void Back()
        {
            WriteLine("후진합니다.");
        }

        public void Left()
        {
            WriteLine("좌회전합니다.");
        }

        public void Right()
        {
            WriteLine("우회전합니다.");
        }

        #endregion
    }
}
