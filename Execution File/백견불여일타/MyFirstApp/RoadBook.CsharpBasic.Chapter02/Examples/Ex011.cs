using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex011
    {
        const float _PIE_VALUE = 3.14f;

        public void Run()
        {
            WriteLine($"파이는 {_PIE_VALUE}");
        }
        // 상수는 변하지 않는 수이기 때문에 여러 함수에 공유를 해서 사용함
        // 따라서 지역변수보다는 전역변수로 많이 사용됨
    }
}
