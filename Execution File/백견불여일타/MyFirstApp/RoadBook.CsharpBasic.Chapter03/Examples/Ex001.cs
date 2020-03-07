using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex001
    {
        const int zero = 0;

        public void Run()
        {
            if (zero == 0)
                WriteLine("첫번째 if문입니다.");

            if (zero == 0)
            {
                WriteLine("두번째 if문입니다.");
                WriteLine("zero는 0이기 때문에 출력을 합니다.");
            }

            if (zero == 1)
            {
                WriteLine("세번째 if문입니다.");
                WriteLine("zero는 1이 아니기 때문에 출력에서 제외됩니다.");
            }
        }
    }
}
