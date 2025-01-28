using System.Runtime.InteropServices.Marshalling;
using mission3;

internal class Program
{
    private static void Main(string[] args)
    {
        // call the foodItem class
        FoodItem fi = new FoodItem();

        bool loopCheck = true;
        int optCheck = 0;
        
        // while loop because it works
        while (loopCheck == true)
        {
            Console.WriteLine("Press 1 to add a food item.");
            Console.WriteLine("Press 2 to delete a food item.");
            Console.WriteLine("Press 3 to print all food items.");
            Console.WriteLine("Press 4 to exit the program.");

            // tryparse if to catch bad data 
            if (int.TryParse(Console.ReadLine(), out optCheck))
            {
                if (optCheck > 4 || optCheck < 1)
                {
                    Console.WriteLine("Please only click 1, 2, 3, or 4");
                }
                else
                {
                    fi.FoodLibrary(optCheck);
                }
            }
            else 
            {
                Console.WriteLine("Invalid input. Please enter an intenger"); 
            }
        }
    }
}