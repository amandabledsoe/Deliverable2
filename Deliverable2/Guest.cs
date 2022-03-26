using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Guest
    {
        public string DrinkChoice;
        public double DrinkTotal = 2.00;
        public double BuffetTotal = 9.99;
        public double MealTotal;

        public Guest()
        {

        }
        public Guest(string drinkChoice)
        {
            if (drinkChoice.ToLower() == "water")
            {
                DrinkTotal = 0.00;
            }

        }
        public double CalculateDrinkTotal(Guest guest)
        {
            if (guest.DrinkChoice.ToLower() == "water")
            {
                guest.DrinkTotal = 0.00;
            }
            return guest.DrinkTotal;
        }
        public double CaluclateMealTotal(Guest guest)
        {
            double guestMealTotal;
            if (guest.DrinkChoice.ToLower() == "water")
            {
                guest.DrinkTotal = 0.00;
            }
            guestMealTotal = guest.DrinkTotal + guest.BuffetTotal;
            guest.MealTotal = guestMealTotal;
            return guestMealTotal;
        }
    }
}
