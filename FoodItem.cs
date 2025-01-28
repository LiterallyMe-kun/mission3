using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mission3;

namespace mission3
{
     public class FoodItem
    {
        // I don't even remember why I used this construct, but it works
        List<string> food = new List<string>();
        public void FoodLibrary(int theNumber)
        {
            switch (theNumber)
            {
                case 1:
                    // concat one big string of data to append to food list because simple
                    string newFood;
                    Console.WriteLine("What food are you giving?");
                    newFood = "" + Console.ReadLine();

                    Console.WriteLine("What category? eg. dairy, grain");
                    newFood = newFood + ", " + Console.ReadLine();

                    Console.WriteLine("How much?");
                    newFood = newFood + ", " + Console.ReadLine();

                    Console.WriteLine("Expiration date?");
                    newFood += ", EXP DATE: " + Console.ReadLine();

                    food.Add(newFood);
                    Console.WriteLine("Food Added");
                    break;
                case 2:

                    // variable for user input
                    int daIndex = 0;

                    Console.WriteLine("Delete which item? First line printed = 1. If blank, enter 0");
                    foreach (string food in food) 
                    {
                        Console.WriteLine(food); 
                    }
                // goto label for user ease
                bruh:
                    // tryparse if to catch bad data
                    if (int.TryParse(Console.ReadLine(), out daIndex))
                    {
                        daIndex = daIndex - 1;
                        // empty list failsafe
                        if (daIndex == -1 )
                        {
                            break;
                        }
                        // invalid index failsafe
                        if (daIndex > food.Count || daIndex < -1)
                        {
                            Console.WriteLine("Please enter only a number corresponding to the number of printed lines.");
                            //goto for user convenience 
                            goto bruh;
                        }
                        // successful deletion
                        else
                        {
                            food.RemoveAt(daIndex);
                            Console.WriteLine("Item Removed");
                            break;
                        }
                    }
                    // string data failsafe
                    else
                    {
                        Console.WriteLine("Enter a valid integer.");
                        // I use goto because I'm a G and don't give a hoot about good practice
                        goto bruh;
                    }
                    
                case 3:
                    //simple foreach print
                    foreach (string food in food) 
                    {
                        Console.WriteLine(food);
                    }
                    break;
                case 4:
                    // don't even change loopCheck, lol, just exit the program.
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;



            };

        }
    }
}
