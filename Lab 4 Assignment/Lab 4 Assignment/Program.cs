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
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            int childTicket;
            int adultTicket;
            int seniorTicket;
            double totalTicketCost = 0;
            double totalConcessionCost = 0;
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            double smallSodaCost = 3.50;
            double largeSodaCost = 5.99;
            double hotDogCost = 3.99;
            double popcornCost = 4.50;
            double candyCost = 1.99;
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            int smallSoda = 0;
            int largeSoda = 0;
            int hotDog = 0;
            int popcorn = 0;
            int candy = 0;
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            double firstDiscount = 0;
            double secondDiscount = 0;
            double thirdDiscount = 0;
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            System.Console.WriteLine("Welcome to the Program Cinema!");
           
            System.Console.Write("How many Children tickets today?");
            childTicket = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Adult tickets today?");
            adultTicket = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Senior tickets today?");
            seniorTicket = int.Parse(System.Console.ReadLine());

            System.Console.Write("If you are buying Matinee Tickets Press 1, For Evening Tickets Press 2? ");
            string movieTimes = System.Console.ReadLine();

            if (movieTimes == "1")
            {
                double childCost = 3.99;
                double adultCost = 5.99;
                double seniorCost = 4.50;

                totalTicketCost += childTicket + childCost;
                totalTicketCost += adultTicket + adultCost;
                totalTicketCost += seniorTicket + seniorCost;               
            }
            else if (movieTimes == "2")
            {             
                double childCost = 6.99;
                double adultCost = 10.99;
                double seniorCost = 8.50;

                totalTicketCost += childTicket + childCost;
                totalTicketCost += adultTicket + adultCost;
                totalTicketCost += seniorTicket + seniorCost;            
                
            }
            else
            {
                System.Console.WriteLine("I'm sorry I didn't understand you please close the window and start again. ");
            }

            int totalTicketCount = childTicket + adultTicket + seniorTicket;

            System.Console.WriteLine("Alright lets move onto the Concession stand!");
                   
            System.Console.Write("How many Small Sodas? ");
            smallSoda = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many Large Sodas? ");
            largeSoda = int.Parse(System.Console.ReadLine());                

            System.Console.Write("How many Hot Dogs? ");
            hotDog = int.Parse(System.Console.ReadLine());                

            System.Console.Write("How many Popcorns? ");
            popcorn = int.Parse(System.Console.ReadLine());
                
            System.Console.Write("How many Candies ?");
            candy = int.Parse(System.Console.ReadLine());

            totalConcessionCost += smallSodaCost + smallSoda;
            totalConcessionCost += largeSodaCost + largeSoda;
            totalConcessionCost += hotDogCost + hotDog;
            totalConcessionCost += candyCost + candy;
            totalConcessionCost += popcornCost + popcorn;

           
            if (popcorn >= 1 && largeSoda >= 1 && totalTicketCount >= 1)

            {

                if (popcorn <= largeSoda && popcorn <= totalTicketCount)
                {
                    firstDiscount = 2 * popcorn;
                }

                else if (largeSoda <= popcorn && largeSoda <= totalTicketCount)
                {
                    firstDiscount = 2 * largeSoda;
                }
                else
                {
                    firstDiscount = 2 * totalTicketCount;
                }

            }
            if (totalTicketCount >= 3)
            {
                if (movieTimes == "2")
                {
                    if (popcorn >= 1)
                    {
                        secondDiscount = 4.50;
                    }
                }
            }
            if (candy >= 4)
            {
                thirdDiscount = (candy / 4) * 1.99;
            }
            double discountAmount = firstDiscount + secondDiscount + thirdDiscount;
            double totalCost = (totalTicketCost + totalConcessionCost) - discountAmount;

            System.Console.WriteLine("Your total cost is: $" + totalCost);
            System.Console.WriteLine("Enjoy your movie!");
            System.Console.WriteLine("Press any key to end...");

            System.Console.ReadKey();
        }
    }
}
