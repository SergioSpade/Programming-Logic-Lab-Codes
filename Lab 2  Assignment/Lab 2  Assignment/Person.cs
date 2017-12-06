using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__Assignment
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Spouse;
        public int SpouseAge;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
          
        

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + " " + "(" + Age + ")");
            System.Console.WriteLine(Spouse + " " + LastName + " " + "(" + SpouseAge + ")");
            
        }

    }
}
