using System.Runtime.InteropServices.Marshalling;
using mission3;

internal class Program
{
   

    private static void Main(string[] args)
    {
        FoodItem fi = new FoodItem();

        bool loopCheck = true;
        int optCheck = 0;

        while (loopCheck == true)
        {
            Console.WriteLine("Press 1 to add a food item.");
            Console.WriteLine("Press 2 to delete a food item.");
            Console.WriteLine("Press 3 to print all food items.");
            Console.WriteLine("Press 4 to exit the program.");
            optCheck = int.Parse(Console.ReadLine());

            if (optCheck != 1 || optCheck != 2 || optCheck != 3 || optCheck != 4)
            {
                Console.WriteLine("Please only click 1, 2, 3, or 4");
            }
            else 
            {fi.FoodLibrary(optCheck); }
        }
    }
}