using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex006
    {
        public void Run()
        {
            for (int index_i = 0; index_i < 2; index_i++)
            {
                for (int index_j = 0; index_j < 3; index_j++)
                {
                    for (int index_k = 0; index_k < 4; index_k++)
                    {
                        WriteLine($"i : {index_i} / j : {index_j} / k : {index_k}");
                    }
                }
            }
        }
    }
}
