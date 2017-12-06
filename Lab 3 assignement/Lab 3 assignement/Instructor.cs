using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_assignement
{
    class Instructor
    {
        private string Name;
        private string CourseName;


        public Instructor(string name, string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }
        
        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);

        }

        public void Print()
        {

            System.Console.WriteLine("Instructor: " + this.Name + " " + "Course: " + this.CourseName);

        }

    }
}
