using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SodaMachine.cs
{
    static class UserInterface
    {
        public double moneyInserted;


        //public static string GetUserData(string output)
        //{
        //Console.WriteLine(output);
        //return Console.ReadLine();
        //}

        //public static int GetAge()
        //{
        //Console.WriteLine("Please enter your age");
        //return int.Parse(Console.ReadLine());
        //} 

        public static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("ICE COLD SODA");
            }
           


        }

        public static string HowMuchDoughYouSportingDog()
        {
            Console.WriteLine("*Press any key to continue");
            Console.ReadLine();

            Console.WriteLine("Please select the amount to insert:" + "\n" + "\n");
            Console.WriteLine("          (1)  .25" + "\n");
            Console.WriteLine("          (2)  .75" + "\n");
            Console.WriteLine("          (3) 1.00" + "\n");
            string moneyInserted = Console.ReadLine();

            if (moneyInserted == "1")
            {
                moneyInserted += ".25";
                SelectProduct();
                return moneyInserted;

            }
            else if (moneyInserted == "2")
            {
                moneyInserted += ".75";
                SelectProduct();
                return moneyInserted;


            }
            else if (moneyInserted == "3")
            {
                moneyInserted += "1.00";
                SelectProduct();
                return moneyInserted;

            }
            else
            {
                Console.WriteLine("* Silly User... Try Again *");
                SelectProduct();
                return null;
            }
        }


        public static string SelectProduct()
        {

            Console.WriteLine("   (1) Refreshing Coca Cola");
            Console.WriteLine("   (2) Charles Famous Orange Soda");
            Console.WriteLine("   (3) Root Beer...");
            string sodaUserWants = Console.ReadLine();

            switch (sodaUserWants)
            {
                case "1":
                    return "Cola";
                case "2":
                    return "Orange Soda";
                case "3":
                    return "Root Beer";

                default:
                    Console.WriteLine("Nice Try Silly User! Please Try Again");
                    Console.Clear();
                    return SelectProduct();

            }

        }

        
    }
}

