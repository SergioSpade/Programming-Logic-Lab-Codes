﻿namespace Lab_3_assignement
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");
            Student Jane = new Student("Jane", "John");
            Student Joe = new Student("Joe", "John");
            Student Melissa = new Student("Melissa", "Mike");
            Student Matt = new Student("Matt", "Mike");


            John.SetStudentGrade(Jane, 95);
            Jane.Print();
            System.Console.WriteLine();
            John.SetStudentGrade(Joe, 85);
            Joe.Print();
            System.Console.WriteLine();
            Mike.SetStudentGrade(Melissa, 90);
            Melissa.Print();
            System.Console.WriteLine();
            Mike.SetStudentGrade(Matt, 92);
            Matt.Print();

            System.Console.WriteLine();

            John.Print();
            Mike.Print();

            System.Console.WriteLine();
            System.Console.WriteLine("Press any key....");
            System.Console.ReadKey();



        }
    }
}
