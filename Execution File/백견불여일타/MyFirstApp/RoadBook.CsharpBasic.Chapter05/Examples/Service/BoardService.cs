using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter05.Examples.Service
{
    class BoardService
    {
        Model.Board board;

        public BoardService()
        {
            this.board = new Model.Board();
        }

        public BoardService(Model.Board board)
        {
            this.board = board;
        }

        public void Save(int number, string title, string content, string writer)
        {
            board.Number = number;
            board.Title = title;
            board.Contents = content;
            board.Writer = writer;
            board.CreateDate = DateTime.Now;
            board.UpdateDate = DateTime.Now;

            WriteLine("게시물이 저장되었습니다.");
        }

        public void Update(string title, string content, string writer)
        {
            board.Title = title;
            board.Contents = content;
            board.Writer = writer;
            board.UpdateDate = DateTime.Now;

            WriteLine("게시물이 수정되었습니다.");
        }

        public void Delete()
        {
            board = null;

            WriteLine("게시물이 삭제되었습니다.");
        }

        public void Read()
        {
            if (board != null)
            {
                WriteLine($"{board.Number}번 게시물");
                WriteLine($"제목 : {board.Title}");
                WriteLine($"작성일 : {board.CreateDate}");
                WriteLine($"수정일 : {board.UpdateDate}");
                WriteLine($"글쓴이 : {board.Writer}");
                WriteLine($"내용 : {board.Contents}");
            }
            else
            {
                WriteLine("게시물이 없습니다.");
            }
        }
    }
}
