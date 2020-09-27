﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SodaMachine.cs
{
    static class UserInterface
    {
        
        public static void StayAtTopOfScreen()
        {
            Console.WriteLine("                                   *   ENJOY A REFRESHING ICE COLD SODA   *");
        }

        public static void MainMenu()
        {
            Console.Clear();
            StayAtTopOfScreen();
            Console.WriteLine("          Select a choice");
                
        }

        public static void WhatDoeTheUserWantToDo()
        {
            Console.WriteLine("     (1)  Browse Inventory");
            Console.WriteLine("     (2)  Purchase Soda");
            Console.WriteLine("     (3)  Open Backpack");

        }

        public static char CaptureChoices()
        {
            char choice = char.Parse(Console.ReadLine());

            switch (choice)
            {
                case '1' :
                    return choice;
                case '2' :
                    return choice;
                case '3' :
                    return choice;
                default:
                    Console.Clear();
                    Console.WriteLine("Not going to get me Mr. fancy pants instructor");
                    return CaptureChoices();

            }
        }

       public static void ShowInventoryToUser(List<Can> inventory)
        {
            Console.WriteLine("Here are the ice cold sodas we have in stock:" + "\n");
            int counter = 1;
            foreach (Can item in inventory)
            {
                counter++;
                Console.WriteLine(counter + " " + item.name + " " + "$ " + item.Cost + "\n");
                Console.WriteLine(" * Press any key when you are finished browsing");
                Console.ReadLine();

            }
           
        }

        public static double HowMuchDoughYouSportingDog()
        {
            Console.WriteLine("*Press any key to continue");
            Console.ReadLine();

            Console.WriteLine("Please select the amount to insert:" + "\n" + "\n");
            Console.WriteLine("          (1)  .25" + "\n");
            Console.WriteLine("          (2)  .75" + "\n");
            Console.WriteLine("          (3) 1.00" + "\n");
            double moneyInserted = double.Parse(Console.ReadLine());

            if (moneyInserted == 1)
            {
                moneyInserted += Quarter;
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
                return HowMuchDoughYouSportingDog();
            }
        }



        public static string SelectProduct()
        {

            Console.WriteLine("   (1) Refreshing Coca Cola");
            Console.WriteLine("   (2) Charles Famous Orange Soda");
            Console.WriteLine("   (3) Root Beer...");
            string sodaUserWants = Console.ReadLine();
            Console.Clear();

            switch (sodaUserWants)
            {
                case "1":
                    Console.WriteLine("Did you know:" + "\n" + "\n");
                    Console.WriteLine("Did you hear the one about cocaine being found in the recipe for Coca-Cola? Well, it’s true.Coca - Cola was invented in 1885 by John Pemberton, a pharmacist from Atlanta, Georgia, who concocted the original formula in his backyard." + "\n" + "Pemberton’s recipe contained cocaine—in the form of an extract of the coca leaf, which inspired the “Coca” part of the beverage’s name.The “Cola” in the name comes from the kola nut, which contains caffeine, another stimulant." + "\n" + "At the time of Coca - Cola’s invention, cocaine was legal and a common ingredient in medicines.It was thought not to be harmful in small doses.");
                    Console.Clear();
                    return "Cola";
                case "2":
                    Console.WriteLine("Nice Choice Champ!" + "\n" + "Fanta was created because of Nazis... I bet you feel real good about your choice" + "\n" + "During WWII, bottling Coca-Cola in Germany became difficult due to lack of supplies. " + "\n" + "The head of operations at the German division of the company, Max Keith, decided to create a new soda that could be made with more obtainable ingredients. Thus, Fanta was born.");
                    Console.Clear();
                    return "Orange Soda";
                case "3":
                    Console.WriteLine("In 1895 the Women’s Christian Temperance Union called for a nationwide bar of Hires Root Beer on suspicion that the soda contained alcohol. Their ban lasted for three years." );
                    Console.Clear();
                    return "Root Beer";
                default:
                    Console.WriteLine("Nice Try Silly User! Please Try Again");
                    Console.Clear();
                    return SelectProduct();

            }

        }

        
    }
}

