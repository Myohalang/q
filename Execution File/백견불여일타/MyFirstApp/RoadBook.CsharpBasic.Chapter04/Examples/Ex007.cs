using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex007
    {
        public void Run()
        {
            for (int index_i = 2; index_i < 10; index_i++)
            {
                WriteLine($"{index_i}단 시작!");

                for (int index_j = 1; index_j <10; index_j++)
                {
                    WriteLine($"{index_i} * {index_j} = {index_i * index_j}");
                }

                WriteLine();
            }
        }
    }
}
