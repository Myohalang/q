using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex007
    {
        public void Run()
        {
            Write("숫자를 입력하세요 : ");

            int number = -1;
            bool isException = false;

            try
            {
                number = Convert.ToInt32(ReadLine());
            }
            catch (FormatException)
            {
                WriteLine("Format Exception : 숫자가 아닌 값을 입력했습니다.");

                isException = true;
            }
            catch (OverflowException)
            {
                WriteLine("Overflow Exception : 숫자의 범위를 초과했습니다.");

                isException = true;
            }
            catch (Exception e)
            {
                WriteLine("예외상황 발생, 관리자에게 문의하세요");
                WriteLine($"에러 코드 : {e.HResult}");
                WriteLine($"에러 메시지 : {e.Message}");

                isException = true;
            }
            finally
            {
                if (isException)
                {
                    number = 0;
                }
            }

            WriteLine($"입력된 숫자는 {number}");
        }
    }
}
