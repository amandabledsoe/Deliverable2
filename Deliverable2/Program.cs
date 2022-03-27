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
            List<Guest> masterGuestList = new List<Guest>();

            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to Those Guy's Buffet & Stuff - Home of the Big Ol' Buffet & Stuff!");

            while (doingBuffetThings)
            {
                Thread.Sleep(2000);
                Console.WriteLine("");
                Console.WriteLine("How many people do we have the pleasure of serving today?");
                Console.Write("Enter Number of Guests: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                numberOfGuests = int.Parse(Console.ReadLine());
                Console.ResetColor();

                approvedPartySize = GettingNumOfGuests(numberOfGuests);

                while (approvedPartySize == true)
                {
                    Console.Clear();
                    Console.WriteLine("Now that you're seated,\nlet's get everyone started with something to drink!");
                    Console.WriteLine("");

                    masterGuestList = DrinkOrders(numberOfGuests, masterGuestList);

                    Thread.Sleep(1000);
                    Console.WriteLine("Alright, thank you! The drink orders I have are as follows:");
                    foreach (Guest guest in masterGuestList)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"For Guest #{masterGuestList.IndexOf(guest) + 1}, {guest.DrinkChoice}.");
                    }
                    Console.ResetColor();
                    Thread.Sleep(3000);

                    Console.WriteLine("");
                    Console.WriteLine("I'll be right back with those drinks, folks!");
                    Console.WriteLine("In the meantime, please help yourself to the buffet and enjoy your meal!");
                    Thread.Sleep(5000);
                    Console.Clear();

                    MealEnsues();

                    Console.WriteLine("How was your meal folks? Hope it was wonderful!");
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    Console.WriteLine("Here is your check for today's meals:");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine(string.Format("{0,0}{1,8}{2,12}{3,22}", "|", " Guest Number", "Item", "Price   |"));
                    Console.WriteLine("------------------------------------------------");
                    foreach (Guest guest in masterGuestList)
                    {
                        double thisDouble = guest.CalculateDrinkTotal(guest);
                        Console.WriteLine(string.Format("{0,0}{1,7}{2,19}{3,21}", "|", $"{masterGuestList.IndexOf(guest)+1}", $"{guest.DrinkChoice}", $"${thisDouble}.00   |"));
                        Console.WriteLine(string.Format("{0,0}{1,7}{2,19}{3,21}", "|", $"{masterGuestList.IndexOf(guest)+1}", "buffet", $"${guest.BuffetTotal}   |"));
                    }
                    Console.WriteLine("------------------------------------------------");
                    SettleBill(masterGuestList);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("");
                    Thread.Sleep(5000);
                    Console.WriteLine("Whenever you're ready, meet us with your check at the register!\nTake your time.");
                    Thread.Sleep(2000);
                    approvedPartySize = false;
                }
                doingBuffetThings = false;
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for visiting Those Guy's Buffet & Stuff!");
            Console.WriteLine("Have a wonderful rest of your day - Come back and see us soon!");
            Thread.Sleep(3000);
        }
        static bool GettingNumOfGuests(int numOfGuests)
        {
            if (numOfGuests >= 7)
            {
                Console.WriteLine("");
                Console.WriteLine($"I'm sorry, we cannot accommodate a party size of {numOfGuests} at this time.");
                return false;
            }
            else if (numOfGuests <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Your party size must be a minimum of 1 person to dine at our restaurant.");
                return false;
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine($"Excellent!\nWe'd be happy to accommodate your party of {numOfGuests}!");
                Console.WriteLine("");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Grabs Menus*");
                Console.WriteLine("");
                Thread.Sleep(1500);
                Console.ResetColor(); 
                Console.WriteLine("Follow me this way to your table.");
                Console.WriteLine("");
                Thread.Sleep(3000);
                return true;
            }
        }
        static List<Guest> DrinkOrders(int numOfGuests, List<Guest> guestList)
        {
            bool doingDrinkOrders = true;

            while (doingDrinkOrders)
            {
                for (int i = 1; i <= numOfGuests; i++)
                {
                    Thread.Sleep(1500);
                    Console.WriteLine($"Guest #{i}, what would you like to drink?\nWe have water or coffee.");
                    Console.Write("Drink choice: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string choice = Console.ReadLine();
                    Console.ResetColor();
                    try
                    {
                        if (choice.ToLower() == "water" || choice.ToLower() == "coffee")
                        {
                            Guest guest = new Guest();
                            guest.DrinkChoice = choice;
                            guestList.Add(guest);
                            Console.WriteLine("");
                        }
                        else if (choice.ToLower() != "coffee" && choice.ToLower() != "water")
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"I'm sorry, we don't offer the beverage {choice}.");
                            Console.WriteLine("Since it's free, I'll just bring you a water instead!");
                            Console.WriteLine("");

                            Guest guest = new Guest();
                            guest.DrinkChoice = "water";
                            guestList.Add(guest);
                        }
                    }
                    catch
                    {
                        if (choice.ToLower() != "coffee" && choice.ToLower() != "water")
                        {
                            Console.WriteLine("Sorry, that choice isn't an option.");
                        }
                    }
                }
                doingDrinkOrders = false;
            }
            return guestList;
        }
        static void MealEnsues()
        {
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*BEGIN MEAL SEQUENCE!* :)");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("*Waitress Returns with Drinks*");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("*YUM! This Buffet Sure Looks TASTY!*");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("*Meals are Brought Back to the Table & Enjoyed*");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("*Laughs are Shared, Fun is Had*");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("*MEAL SEQUENCE COMPLETE! :)");
            Thread.Sleep(4000);
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
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"|      The total of your bill is ${billTotal}.       |");
            Console.ResetColor();
        }
    }
}
