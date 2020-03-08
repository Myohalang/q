using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex011
    {
        public void Run()
        {
            Write("중간고사 점수를 입력하세요. : ");
            double mid_exam = Convert.ToDouble(ReadLine());
            Write("기말고사 점수를 입력하세요. : ");
            double final_exam = Convert.ToDouble(ReadLine());

            double ever = (mid_exam + final_exam) / 2.0;

            WriteLine();
            WriteLine($"평균 : {ever}");

            string credit;

            if (ever >= 90)
            {
                credit = "A학점";
            }
            else if (ever >= 80 && ever < 90)
            {
                credit = "B학점";
            }
            else if (ever >= 70 && ever < 80)
            {
                credit = "C학점";
            }
            else
            {
                credit = "F학점";
            }

            WriteLine($"최종 학력은 {credit}입니다.");
        }
    }
}
