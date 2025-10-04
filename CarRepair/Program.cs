using System;
using Controllers;

namespace CarRepairApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Car Repair Application!\n");

            try
            {
                // Just call MainController
                var mainController = new MainController();

                // MainController will call CarView internally
                mainController.HandleCarView();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }

            Console.WriteLine("\nApplication finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
