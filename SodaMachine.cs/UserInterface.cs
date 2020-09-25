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
       





    }
}
