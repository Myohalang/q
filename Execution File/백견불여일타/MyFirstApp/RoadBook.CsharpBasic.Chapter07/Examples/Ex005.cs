using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex005
    {
        public void Run()
        {
            Write("숫자를 입력하세요 : ");

            try
            {
                int number = Convert.ToInt32(ReadLine());

                WriteLine($"입력된 숫자는 {number}");
            }
            catch (FormatException)
            {
                WriteLine("Format Exception : 숫자가 아닌 값을 입력했습니다.");
            }
            catch (OverflowException)
            {
                WriteLine("Overflow Exception : 숫자의 범위를 초과했습니다.");
            }
            catch (Exception e)
            {
                WriteLine("예외상황 발생, 관리자에게 문의하세요");
                WriteLine($"에러 코드 : {e.HResult}");
                WriteLine($"에러 메시지 : {e.Message}");
            }
        }
    }
}
