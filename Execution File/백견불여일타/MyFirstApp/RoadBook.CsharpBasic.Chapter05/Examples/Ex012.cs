using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex012
    {

        public void Run()
        {
            WriteLine("********** 안녕하세요 Road Bank입니다 **********");
            WriteLine("1 : 계좌 만들기");
            WriteLine("2 : 잔액 조회");
            WriteLine("3 : 입금");
            WriteLine("4 : 출금");
            WriteLine("0 : 종료");
            WriteLine("************************************************");

            Model.BankAccount bank = new Model.BankAccount();

            Model.BankAccount bankAccount = new Model.BankAccount()
            {
                bankBook = "",
                username = "",
                money = 0
            };

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
                            WriteLine("통장 고유 이름을 입력하세요.");
                            bank.bankBook = ReadLine();

                            WriteLine("통장 개설자의 이름을 입력하세요.");
                            bank.username = ReadLine();

                            WriteLine($"'{bank.bankBook}'님의 '{bank.username}'통장이 개설되었습니다.");
                            break;
                        }

                    case 2:
                        {
                            WriteLine($"잔액은 {bank.money}입니다.");
                            break;
                        }
                    case 3:
                        {
                            WriteLine("입금할 금액을 입력하세요.");
                            Write("입력 : ");

                            bank.money += Convert.ToInt32(ReadLine());

                            WriteLine("입금되었습니다.");

                            break;
                        }
                    case 4:
                        {
                            WriteLine("출금할 금액을 입력하세요.");
                            Write("입력 : ");

                            int i = Convert.ToInt32(ReadLine());

                            if (bank.money > i)
                            {
                                bank.money -= i;

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
