using System;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex004
    {
        public void Run()
        {
            int[][] gradeOfStudents =
            {
                new int [] {100, 98, 95 },
                new int [] {90, 100, 100 },
                new int [] {88, 92, 98 }
            };

            for (int idx_i = 0; idx_i < gradeOfStudents.Length; idx_i++)
            {
                int studentCnt = gradeOfStudents[idx_i].Length;

                for (int idx_j = 0; idx_j < studentCnt; idx_j++)
                {
                    WriteLine($"{idx_i}번째 학생의 {idx_j}번째 과목 성적 : {gradeOfStudents[idx_i][idx_j]}");
                }
            }
        }
    }
}
