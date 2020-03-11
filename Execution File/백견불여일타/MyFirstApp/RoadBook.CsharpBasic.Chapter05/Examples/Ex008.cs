using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex008
    {
        public void Run()
        {
            GasolineCar008 gasolineCar = new GasolineCar008();
            gasolineCar.Color = "검정";
            gasolineCar.Size = "SUV";

            ElectronicCar008 electronicCar = new ElectronicCar008();
            electronicCar.Color = "초록";
            electronicCar.Size = "경차";

            WriteLine($"{gasolineCar.Color}색 {gasolineCar.Size}가");
            gasolineCar.InputGas();

            WriteLine($"{electronicCar.Color}색 {electronicCar.Size}가");
            electronicCar.InputGas();

        }
    }

    class Car008
    {
        public string Color { get; set; }
        public string Size { get; set; }

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

        public virtual void InputGas()
        {
            WriteLine("기름을 넣습니다.");
        }
    }

    class GasolineCar008 : Car008
    {
        public override void InputGas()
        {
            WriteLine("휘발유를 넣습니다.");
        }
    }

    class ElectronicCar008 : Car008
    {
        public override void InputGas()
        {
            WriteLine("전기를 넣습니다.");
        }
    }
}
