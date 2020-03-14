using System;
using System.Collections.Generic;
using static System.Console;
using RoadBook.CsharpBasic.Chapter06.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex014
    {
        public void Run()
        {
            List<Student> arrStudent = new List<Student>();

            Student student = new Student();
            student.Id = "S001";
            student.Name = "홍길동";
            student.Department = "국어국문학과";
            student.Grade = 1;
            student.Age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                WriteLine((arrStudent[idx]).Id);
                WriteLine((arrStudent[idx]).Name);
                WriteLine((arrStudent[idx]).Department);
                WriteLine((arrStudent[idx]).Grade);
                WriteLine((arrStudent[idx]).Age);
            }
        }
    }
}
