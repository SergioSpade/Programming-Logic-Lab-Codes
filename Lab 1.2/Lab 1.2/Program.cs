using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle Initial: ");
            char middleInitial = char.Parse(Console.ReadLine());
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            string fullName = (firstName + " " + middleInitial + ". " + lastName);

            int heightInFeet;
            double heightInInches = 1.25; 
            double totalHeightInches = ( heightInFeet * 12) + heightInInches;
            double heightInCM = totalHeightInches * 2.54;

            System.Console.Write("How tall are you in Feet?");
            heightInFeet = int.Parse(System.Console.ReadLine());

            bool isCitizen;
            int age;
            bool canVote = (isCitizen) && (age >= 18);

            System.Console.Write("true or false: Are you a US Citizen?");
            isCitizen = bool.Parse(Console.ReadLine());

            System.Console.Write("How old are you?");
            age = int.Parse(System.Console.ReadLine());


            Console.WriteLine(fullName);
            System.Threading.Thread.Sleep(3000);


        }
    }
}
