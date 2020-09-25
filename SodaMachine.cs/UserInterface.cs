using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SodaMachine.cs
{
    static class UserInterface
    {
       


     




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

       
        public static string MainMenu()  
        {
            Console.WriteLine("Thirsty? Try one of our thirst quenching beverages today!" + "\n" + "\n" + "\n");
            Console.WriteLine("Hit any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please select from the following options: " + "\n" + "  1]  Insert Money" + "\n" + "   2]  Select Product" + "\n" + "   3]  Checkout");
            string userChoiceMainMenu = Console.ReadLine();

            return userChoiceMainMenu; //simulation 

            
           
        }

        public static string SelectProduct()
        {
            Console.WriteLine("Here are your choices" + "\n");
            Console.WriteLine("   1]  Cola" + "\n" + "   2]  Orange Soda" + "\n" + "   3]  Root Beer");
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
                    Console.WriteLine("Error! Please Try Again");
                    Console.Clear();
                    return SelectProduct();
                   
            }

        }


        //sandbox
        public void Run()
        {
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {

            }
            else if (choice == 2)
            {
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                int choice2 = int.Parse(Console.ReadLine());


            }
}
