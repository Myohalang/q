using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex011
    {
        public void Run()
        {
            while (true)
            {
                WriteLine("1. 게시글 생성");
                WriteLine("2. 게시글 수정");
                WriteLine("3. 게시글 삭제");
                WriteLine("0. 종료");
                WriteLine("번호를 입력하세요");

                int number = Convert.ToInt32(ReadLine());

                switch (number)
                {
                    case 1:
                        {
                            WriteLine();
                            creat_post();
                            break;
                        }
                    case 2:
                        {
                            WriteLine();
                            update();
                            break;
                        }
                    case 3:
                        {
                            WriteLine();
                            delete();
                            break;
                        }
                    case 0:
                        {
                            WriteLine();
                            WriteLine("종료합니다.");
                            return;
                        }
                    default:
                        {
                            WriteLine();
                            WriteLine("잘못된 입력입니다.");
                            break;
                        }
                }

                WriteLine();
            }
        }

        private void creat_post()
        {
            int number = 1;

            WriteLine("게시글 제목을 입력하세요.");
            string title = ReadLine();

            WriteLine("게시글 내용을 입력하세요.");
            string contents = ReadLine();

            WriteLine("작성자를 입력하세요");
            string writer = ReadLine();

            Service.BoardService boardService = new Service.BoardService();
            boardService.Save(number, title, contents, writer);
            boardService.Read();
        }
        
        private void update()
        {
            WriteLine("게시글 제목을 입력하세요.");
            string title = ReadLine();

            WriteLine("게시글 내용을 입력하세요.");
            string contents = ReadLine();

            WriteLine("작성자를 입력하세요");
            string writer = ReadLine();

            Service.BoardService boardService = new Service.BoardService();
            boardService.Update(title, contents, writer);
            boardService.Read();
        }

        private void delete()
        {
            Service.BoardService boardService = new Service.BoardService();
            boardService.Delete();
        }
    }
}
