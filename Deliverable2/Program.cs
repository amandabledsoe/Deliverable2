using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doingBuffetThings = true;
            int numberOfGuests;
            bool approvedPartySize;
            List<Guest> guestList = new List<Guest>();

            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to the Buffet I Still Need To Name Cleverly");

            while (doingBuffetThings)
            {
                Console.WriteLine("");
                Console.WriteLine("How many people do we have the pleasure of serving today?");
                numberOfGuests = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numberOfGuests; i++)
                {
                    Guest guest = new Guest();
                    guestList.Add(guest);
                }
                approvedPartySize = GettingNumOfGuests(numberOfGuests);

                while (approvedPartySize == true)
                {
                    Console.Clear();
                    Console.WriteLine("Now that you're seated, \n let's get everyone started with something to drink!");
                    Console.WriteLine("");
                    DrinkOrders(numberOfGuests);
                    MealEnsues();
                    //SettleBill(guestList);
                    approvedPartySize = false;
                }
                doingBuffetThings = false;
            }

            Console.WriteLine("Thank you for visiting our buffet!");
            Console.WriteLine("Have a wonderful rest of your day!");
        }
        static bool GettingNumOfGuests(int numOfGuests)
        {
            if (numOfGuests >= 7)
            {
                Console.WriteLine("");
                Console.WriteLine($"I'm sorry, we cannot accommodate a party size of {numOfGuests} at this time.");
                Console.WriteLine("");
                return false;
            }
            else if (numOfGuests <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Your party size must be a minimum of 1 person to dine at our restaurant.");
                Console.WriteLine("");
                return false;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"Excellent! We'd be happy to accommodate your party of {numOfGuests}!");
                Console.WriteLine("");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Grabs Menus*");
                Console.WriteLine("");
                Thread.Sleep(1500);
                Console.ResetColor(); 
                Console.WriteLine("Follow me this way to your table.");
                Console.WriteLine("");
                Thread.Sleep(5000);
                return true;
            }
        }
        static void DrinkOrders(int numOfGuests)
        {
            bool doingDrinkOrders = true;
            List<Guest> guestList = new List<Guest>();

            while (doingDrinkOrders)
            {
                //need to find a way to put a try catch statement in here to catch words other than water or coffee
                for (int i = 1; i <= numOfGuests; i++)
                {
                    Console.WriteLine($"Guest #{i}, what would you like to drink? We have water or coffee");
                    string choice = Console.ReadLine();
                    if (choice == "water" || choice == "coffee")
                    {
                        Guest guest = new Guest();
                        guest.DrinkChoice = choice;

                        guestList.Add(guest);
                        Console.WriteLine($"Excellent! {choice} for guest #{i}");
                        Console.WriteLine();
                    }
                    else
                    {
                        doingDrinkOrders = false;
                    }
                }
                doingDrinkOrders = false;
            }
            Console.WriteLine("Alright! The drink orders I have are as follows:");
            foreach (Guest guest in guestList)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"For Guest #{guestList.IndexOf(guest)+1}, {guest.DrinkChoice}");
            }
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("I'll be right back with those drinks, folks!");
            Console.WriteLine("In the meantime, please help yourself to the buffet and enjoy your meal!");
            Thread.Sleep(5000);
            Console.Clear();
        }
        static void MealEnsues()
        {
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine(" BEGIN MEAL SEQUENCE! :)");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("*Waitress Returns with Drinks*");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("*YUM! This buffet sure looks tasty!*");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("*Meals are brought back to the table & enjoyed*");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("*Laughs are shared, fun is had*");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("*MEAL SEQUENCE COMPLETE! :)");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();
        }
        static void SettleBill(List<Guest> guestList)
        {
            List<double> totals = new List<double>();

            foreach (Guest guest in guestList)
            {
                totals.Add(guest.CaluclateMealTotal(guest));
            }
            double billTotal = totals.Sum();
            Console.WriteLine($"The total for your bill for all patrons is {billTotal}.");
            Console.WriteLine("");
        }
    }
}
