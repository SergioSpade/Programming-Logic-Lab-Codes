namespace Lab_3_assignement
{
    class Student
    {
        private string Name;
        private int Grade;
        private string Teacher;
        
        public Student(string name, string teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;

            
        }
        
        public void SetGrade(int z)
        {
            this.Grade = z;
        }


        public void Print()
        {
            System.Console.WriteLine("Student: " + this.Name);
            System.Console.WriteLine("Grade: " + this.Grade);
            System.Console.WriteLine("Teacher: " + this.Teacher);
        }
    }
}
