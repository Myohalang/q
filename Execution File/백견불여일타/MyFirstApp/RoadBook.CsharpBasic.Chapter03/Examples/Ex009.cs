using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex009
    {
        public void Run()
        {
            Write("영화제목을 입력하세요 : ");
            string movieTitle = ReadLine();

            Write($"{movieTitle}에 대한 평점을 입력하세요. (1 ~ 5점) : ");
            int rating = Convert.ToInt32(ReadLine());

            switch (rating)
            {
                case 1:
                    {
                        WriteLine($"{movieTitle} 영화는 환불을 받고 싶을 정도로 최악의 영화군요.");
                        break;
                    }
                case 2:
                    {
                        WriteLine($"{movieTitle} 영화는 지루한 영화군요.");
                        break;
                    }
                case 3:
                    {
                        WriteLine($"{movieTitle} 영화는 시간 때우기 좋은 그 이상 그 이하도 아닌 영화군요.");
                        break;
                    }
                case 4:
                    {
                        WriteLine($"{movieTitle} 영화는 당신의 흥미를 유발할 만한 완성도 높은 영화군요.");
                        break;
                    }
                case 5:
                    {
                        WriteLine($"{movieTitle} 영화는 당신의 최고의 영화 하나로 기억되겠군요.");
                        break;
                    }
                default:
                    {
                        WriteLine("평정 계산에 실패하였습니다.");
                        break;
                    }
            }
        }
    }
}
