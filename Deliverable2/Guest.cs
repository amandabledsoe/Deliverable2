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
        public double DrinkTotal;
        public double BuffetTotal = 9.99;
        public double MealTotal;

        public Guest()
        {

        }
        public Guest(string drinkChoice)
        {
            drinkChoice = DrinkChoice;
        }
        public double CaluclateMealTotal(Guest guest)
        {
            double guestMealTotal;
            if (guest.DrinkChoice.ToLower() == "coffee")
            {
                guest.DrinkTotal = 2.00;
            }
            else
            {
                guest.DrinkTotal = 0.00;
            }
            guestMealTotal = guest.DrinkTotal + guest.BuffetTotal;
            guest.MealTotal = guestMealTotal;
            return guestMealTotal;
        }

    }
}
