using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Ex013
    {

        public void Run()
        {
            int check_balance = 1;
            int deposit = 2;
            int withdrawal = 3;
            int close = 0;

            int balance = 0;

            WriteLine("********** 안녕하세요 Road Bank입니다 **********");
            WriteLine("1 : 잔액 조회");
            WriteLine("2 : 입금");
            WriteLine("3 : 출금");
            WriteLine("0 : 종료");
            WriteLine("************************************************");

            while (true)
            {

                int input = Convert.ToInt32(ReadLine());

                if (input == 0)
                {
                    break;
                }

                switch (input)
                {
                    case 1:
                        {
                            WriteLine($"잔액은 {balance}입니다.");
                            break;
                        }
                    case 2:
                        {
                            WriteLine("입금할 금액을 입력하세요.");
                            Write("입력 : ");

                            balance += Convert.ToInt32(ReadLine());

                            WriteLine("입금되었습니다.");

                            break;
                        }
                    case 3:
                        {
                            WriteLine("출금할 금액을 입력하세요.");
                            Write("입력 : ");

                            int i = Convert.ToInt32(ReadLine());

                            if (balance > i)
                            {
                                balance -= i;

                                WriteLine("출금되었습니다.");

                                break;
                            }
                            else
                            {
                                WriteLine("금액이 부족합니다.");

                                break;
                            }
                        }
                    default:
                        {
                            WriteLine("잘못된 입력입니다.");
                            break;
                        }
                }
            }

            WriteLine("감사합니다.");
        }
    }
}
