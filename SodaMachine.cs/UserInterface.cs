using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SodaMachine.cs
{
    static class UserInterface
    {
        //


        //test




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

        public static void TopOfMenu()
        {
            while (true)
            {
                Console.WriteLine("Thirsty? Try one of our thirst quenching beverages today!" + "\n" + "\n" + "\n");

            }
            

        }
        public static string MainMenu()  //how do i fix this *******  //i need to figure out how to capture these in simulation and where to go from there 
        {
            Console.WriteLine("Hit any key to continue");
            Console.ReadLine();
            Console.WriteLine("Please select from the following options: " + "\n" + "  1]  Insert Money" + "\n" + "   2]  Select Product" + "\n" + "   3]  Checkout");
            string userChoiceMainMenu = Console.ReadLine();
            Console.Clear();

            if(userChoiceMainMenu == "1")
            {
                Console.WriteLine("Please select from the following options: " + "\n" + "\n" + "  1] $ 1.00" + "\n" + "   2]  $ 2.00" + "\n" + "   3]  $ 3.00");
                string moneyToAdd = Console.ReadLine(); 

                return moneyToAdd;
            }
            else if(userChoiceMainMenu == "2" || userChoiceMainMenu == "3")
            {
                return userChoiceMainMenu;  //GetUserInfoFromMainMenu(); 

            }
            else
            {
                Console.WriteLine(" * Error! Please Try Again * ");
                MainMenu();
            }

            

            
           
        }
       





    }
}
