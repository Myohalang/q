using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void Run()
        {
            int korean = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            int totalscore = korean + english + math + sports;

            WriteLine($"합계 : {totalscore}");
            WriteLine($"평균 : {(double)totalscore / 4}");
        }
    }
}
