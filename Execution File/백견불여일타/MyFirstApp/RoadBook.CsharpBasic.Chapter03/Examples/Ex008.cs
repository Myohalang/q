using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex008
    {
        public void Run()
        {
            Write("영화제목을 입력하세요 : ");
            string movie = ReadLine();

            Write($"{movie}에 대한 평점을 입력하세요. (1 ~ 5점) : ");
            int grade = Convert.ToInt32(ReadLine());

            if (grade == 1)
            {
                WriteLine($"{movie} 영화는 환불을 받고 싶을 정도로 최악의 영화군요.");
            }
            else if (grade == 2)
            {
                WriteLine($"{movie} 영화는 지루한 영화군요.");
            }
            else if (grade == 3)
            {
                WriteLine($"{movie} 영화는 시간 때우기 좋은 그 이상 그 이하도 아닌 영화군요.");
            }
            else if (grade == 4)
            {
                WriteLine($"{movie} 영화는 당신의 흥미를 유발할 만한 완성도 높은 영화군요.");
            }
            else if (grade == 5)
            {
                WriteLine($"{movie} 영화는 당신의 최고의 영화 하나로 기억되겠군요.");
            }
            else
            {
                WriteLine("평점 계산에 실패하였습니다.");
            }
        }
    }
}
