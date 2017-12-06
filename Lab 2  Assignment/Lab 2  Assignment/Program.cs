namespace Lab_2__Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            System.Console.WriteLine("Person 1 please fill in the following:");
            System.Console.WriteLine();
            System.Console.Write("What is your First name? ");
            p1.FirstName = System.Console.ReadLine();
            System.Console.Write("What is your Last name? ");
            p1.LastName = System.Console.ReadLine();
            System.Console.Write("How old are you? ");
            p1.Age = int.Parse(System.Console.ReadLine());
            System.Console.Write("What is your spouse's name? ");
            p1.Spouse = System.Console.ReadLine();
            System.Console.Write("How old is your spouse? ");
            p1.SpouseAge = int.Parse(System.Console.ReadLine());
            
            Person p2 = new Person();
            System.Console.WriteLine();
            System.Console.WriteLine("Person 2 please fill in the following:");
            System.Console.WriteLine();

            System.Console.Write("What is your First name? ");
            p2.FirstName = System.Console.ReadLine();
            System.Console.Write("What is your Last name? ");
            p2.LastName = System.Console.ReadLine();
            System.Console.Write("How old are you? ");
            p2.Age = int.Parse(System.Console.ReadLine());
            System.Console.Write("What is your spouse's name? ");
            p2.Spouse = System.Console.ReadLine();
            System.Console.Write("How old is your spouse? ");
            p2.SpouseAge = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges = p1.Age + p1.SpouseAge + p2.Age + p2.SpouseAge;
            System.Console.WriteLine("Calculating Information....");
            System.Console.WriteLine();
            
            p1.PrintNameAndAge();
            p2.PrintNameAndAge();
            System.Console.WriteLine("Average Age = " + Person.SumOfAllAges / 4);
            
            System.Console.WriteLine("Press any key to end...");
            System.Console.ReadKey();


        }
    }
}
