using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Are you buying Matinee or an Evening tickets? ");
            string movieTimes = System.Console.ReadLine();
            double totalPeople;
            double smallsoda;
            double largesoda;
            double hotdogs;
            double popcorns;
            double candies;
            double concessionStand;
            double totalCost;

            if (movieTimes == "Matinee")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Ok. you are buying Matinee tickets!");

                System.Console.Write("How many Children tickets will you be buying today?");
                double child = double.Parse(System.Console.ReadLine());
                double totalChildcost = child * 3.99;

                System.Console.Write("How many Adult tickets will you be buying today?");
                double adult = double.Parse(System.Console.ReadLine());
                double totalAdultcost = adult * 5.99;

                System.Console.Write("How many Senior tickets will you be buying today?");
                double senior = double.Parse(System.Console.ReadLine());
                double totalSeniorcost = senior * 4.50;

                totalCost = totalAdultcost + totalChildcost + totalSeniorcost;

                totalPeople = child + adult + senior;
                System.Console.WriteLine("You're total amount of tickets are: " + totalPeople);
                System.Console.WriteLine("You're total cost in tickets: " + totalCost);
                
            }
            else if (movieTimes == "Evening")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Ok. You're buying Evening tickets!");

                System.Console.Write("How many Children tickets will you be buying today?");
                double child = double.Parse(System.Console.ReadLine());
                double totalChildcost = child * 6.99;

                System.Console.Write("How many Adult tickets will you be buying today?");
                double adult = double.Parse(System.Console.ReadLine());
                double totalAdultcost = adult * 10.99;

                System.Console.Write("How many Senior tickets will you be buying today?");
                double senior = double.Parse(System.Console.ReadLine());
                double totalSeniorcost = senior * 8.50;

                totalCost = totalAdultcost + totalChildcost + totalSeniorcost ;

                totalPeople = child + adult + senior;
                System.Console.WriteLine("You're total amount of tickets are: " + totalPeople);
                System.Console.WriteLine("You're total cost in tickets: " + totalAdultcost + totalChildcost + totalSeniorcost);

                if (totalPeople >= 3)
                {
                    System.Console.WriteLine("Because you have purchased " + totalPeople + " tickets you get 1 free bag of popcorn!!!");                       
                }
            }
            else
            {
                System.Console.WriteLine("I'm sorry I didn't understand you please close the window and start again. ");
            }

            System.Console.WriteLine("Would you like to buy anything from the Concession stand? Yes or No: ");
            string snacks = System.Console.ReadLine();

            if (snacks == "Yes")
            {

                System.Console.Write("How many Small Sodas? ");
                smallsoda = double.Parse(System.Console.ReadLine());
                smallsoda = (smallsoda * 3.50);

                System.Console.Write("How many Large Sodas? ");
                largesoda = double.Parse(System.Console.ReadLine());
                largesoda = (largesoda * 5.99);

                System.Console.Write("How many Hot Dogs? ");
                hotdogs = double.Parse(System.Console.ReadLine());
                hotdogs = (hotdogs * 3.99);

                System.Console.Write("How many Popcorns? ");
                popcorns = double.Parse(System.Console.ReadLine());
                popcorns = (popcorns * 4.50);

                System.Console.Write("How many Candies ?");
                candies = double.Parse(System.Console.ReadLine());
                candies = (candies * 1.99);

                concessionStand = smallsoda + largesoda + hotdogs + popcorns + candies;

                if ((popcorns > 0) && (largesoda > 0))
                {                    
                    System.Console.WriteLine("Because you've bought a large popcorn and a large soda you recieve a $2 discount.");
                    System.Console.WriteLine("Your total is now: " + (concessionStand - 2));
                }
                if (candies >= 5.97)
                {
                    System.Console.WriteLine("You have bought 3 candies and now you get one free!");
                }
                
            }
            else
            {
                System.Console.WriteLine("Ok. Enjoy your movie with no snacks.");
            }


            System.Console.WriteLine("Enjoy your movie!");
            System.Console.WriteLine("Press any key to end...");

            System.Console.ReadKey();
        }
    }
}
