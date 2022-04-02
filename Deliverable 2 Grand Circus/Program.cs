using System;

namespace Deliverable_2_Grand_Circus
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. \nHow many people are in your group? Please, parties of 6 or lower.");
            int partySize = int.Parse(Console.ReadLine());

            if (partySize <= 6)
            {
                Console.WriteLine("\nA table for " + partySize + "! Please follow me and take a seat. \nLet's get everyone started with some drinks. We've got water or coffee.");
            }
            else
            {
                Console.WriteLine("Oh sorry, we can only seat parties up to 6. Have a nice day.");
                Environment.Exit(0);
            }

            //coffee = 2.00
            //water = 0.00

            double coffeeTotal = 0.00;
            int coffeeCount = 0;
            int waterCount = 0;
            double buffetTotal = (partySize * 9.99);

            int[] party;
            party = new int[6] { 1, 2, 3, 4, 5, 6 };


            //person 1
            do
            {
                Console.WriteLine("\nAlright, person number " + party[0] + ", water or coffee?");
                string input1 = Console.ReadLine().ToLower();
                if (input1 == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    coffeeCount++;
                    coffeeTotal = coffeeCount * 2.00;

                }
                else if (input1 == "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount++;
                }
                else
                {
                    Console.WriteLine("We don't have that, no drink for you!");
                }
                break;

            }
            while (partySize >= 1);


            if (partySize == 1)
            {
                double total1 = (coffeeTotal + buffetTotal);

                Console.WriteLine("\nOkay so that's " + coffeeCount + " coffees and " + waterCount + " waters. \nI'll be right back. Feel free to grab some grub!");
                Console.WriteLine("\nYour grand total is $" + total1);
                Environment.Exit(0);
            }
            

            //person 2
            do
            {
                Console.WriteLine("\nAlright, person number " + party[1] + ", water or coffee?");
                string input2 = Console.ReadLine().ToLower();
                if (input2 == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    coffeeCount++;
                    coffeeTotal = coffeeCount * 2.00;
                }
                else if (input2 == "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount++;
                }
                else
                {
                    Console.WriteLine("We don't have that, no drink for you!");
                }
                break;
            }
            while (partySize >= 2);


            if (partySize == 2)
            {
                double total2 = (coffeeTotal + buffetTotal);

                Console.WriteLine("\nOkay so that's " + coffeeCount + " coffees and " + waterCount + " waters. \nI'll be right back. Feel free to grab some grub!");
                Console.WriteLine("\nYour grand total is $" + total2);
                Environment.Exit(0);
            }


            //person 3
            do
            {
                Console.WriteLine("\nAlright, person number " + party[2] + ", water or coffee?");
                string input3 = Console.ReadLine().ToLower();
                if (input3 == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    coffeeCount++;
                    coffeeTotal = coffeeCount * 2.00;
                }
                else if (input3 == "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount++;
                }
                else
                {
                    Console.WriteLine("We don't have that, no drink for you!");
                }
                break;
            }
            while (partySize >= 3);


            if (partySize == 3)
            {
                double total3 = (coffeeTotal + buffetTotal);

                Console.WriteLine("\nOkay so that's " + coffeeCount + " coffees and " + waterCount + " waters. \nI'll be right back. Feel free to grab some grub!");
                Console.WriteLine("\nYour grand total is $" + total3);
                Environment.Exit(0);
            }


            //person 4
            do
            {
                Console.WriteLine("\nAlright, person number " + party[3] + ", water or coffee?");
                string input4 = Console.ReadLine().ToLower();
                if (input4 == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    coffeeCount++;
                    coffeeTotal = coffeeCount * 2.00;
                }
                else if (input4 == "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount++;
                }
                else
                {
                    Console.WriteLine("We don't have that, no drink for you!");
                }
                break;
            }
            while (partySize >= 4);


            if (partySize == 4)
            {
                double total4 = (coffeeTotal + buffetTotal);

                Console.WriteLine("\nOkay so that's " + coffeeCount + " coffees and " + waterCount + " waters. \nI'll be right back. Feel free to grab some grub!");
                Console.WriteLine("\nYour grand total is $" + total4);
                Environment.Exit(0);
            }


            //person 5
            do
            {
                Console.WriteLine("\nAlright, person number " + party[4] + ", water or coffee?");
                string input5 = Console.ReadLine().ToLower();
                if (input5 == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    coffeeCount++;
                    coffeeTotal = coffeeCount * 2.00;
                }
                else if (input5 == "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount++;
                }
                else
                {
                    Console.WriteLine("We don't have that, no drink for you!");
                }
                break;
            }
            while (partySize >= 5);

            if (partySize == 5)
            {
                double total5 = (coffeeTotal + buffetTotal);

                Console.WriteLine("\nOkay so that's " + coffeeCount + " coffees and " + waterCount + " waters. \nI'll be right back. Feel free to grab some grub!");
                Console.WriteLine("\nYour grand total is $" + total5);
                Environment.Exit(0);
            }


            //person 6
            do
            {
                Console.WriteLine("\nAlright, person number " + party[5] + ", water or coffee?");
                string input6 = Console.ReadLine().ToLower();
                if (input6 == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    coffeeCount++;
                    coffeeTotal = coffeeCount * 2.00;
                }
                else if (input6 == "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount++;
                }
                else
                {
                    Console.WriteLine("We don't have that, no drink for you!");
                }
                break;
            }
            while (partySize >= 6);



            double total = (coffeeTotal + buffetTotal);

            Console.WriteLine("Okay so that's " + coffeeCount + " coffees and " + waterCount + " waters. \nI'll be right back. Feel free to grab some grub!");
            Console.WriteLine("\nYour grand total is $" + total);


            //total = (party * 9.99) + (coffee * 2.00)
            
            /* Buffet only sits <= 6 people
             coffee costs $2.00
             water is $0.00 */

        }
    }
}
