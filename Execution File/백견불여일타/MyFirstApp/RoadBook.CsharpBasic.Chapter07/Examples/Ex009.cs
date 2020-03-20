using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex009
    {
        public int Run()
        {
            int number = 0;
            bool isError = false;

            Write("숫자를 입력하세요 : ");

            try
            {
                number = Convert.ToInt32(ReadLine());
            }
            catch (FormatException e)
            {
                WriteLine(e.Message);

                isError = true;
            }
            catch (OverflowException e)
            {
                WriteLine(e.Message);

                isError = true;
            }
            finally
            {
                number = isError ? -1 : number;
            }

            return number;
        }
    }
}
