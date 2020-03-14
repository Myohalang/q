using System;
using System.Collections;
using static System.Console;
using RoadBook.CsharpBasic.Chapter06.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex013
    {
        public void Run()
        {
            ArrayList arrStudent = new ArrayList();

            Student student = new Student();
            student.Id = "S001";
            student.Name = "홍길동";
            student.Department = "국어국문학과";
            student.Grade = 1;
            student.Age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                WriteLine(((Student)arrStudent[idx]).Id);
                WriteLine(((Student)arrStudent[idx]).Name);
                WriteLine(((Student)arrStudent[idx]).Department);
                WriteLine(((Student)arrStudent[idx]).Grade);
                WriteLine(((Student)arrStudent[idx]).Age);
            }

        }
    }
}
