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
        List<string> food = new List<string>();
        public void FoodLibrary(int theNumber)
        {
            switch (theNumber)
            {
                case 1:
                    string newFood;
                    Console.WriteLine("What food are you giving?");
                    newFood = Console.ReadLine();
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
                    
                    int daIndex = 0;

                    
                    Console.WriteLine("Delete which item? First line printed = 1. If blank, enter 0");
                    foreach (string food in food) 
                    {
                        Console.WriteLine(food); 
                    }
                bruh:
                    if (int.TryParse(Console.ReadLine(), out daIndex))
                    {
                        daIndex = daIndex - 1;
                        if (daIndex == -1 )
                        {
                            break;
                        }
                        if (daIndex > food.Count || daIndex < -1)
                        {
                            Console.WriteLine("Please enter only a number corresponding to the number of printed lines.");
                            goto bruh;
                        }
                        else
                        {
                            food.RemoveAt(daIndex);
                            Console.WriteLine("Item Removed");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid integer.");
                        goto bruh;
                    }
                    
                case 3:
                    foreach (string food in food) 
                    {Console.WriteLine(food); }
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;



            };

        }
    }
}
