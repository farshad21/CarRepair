using System;
using Controllers;

namespace Views
{
    public class CarView
    {
        private readonly MainController _mainController;

        public CarView(MainController mainController)
        {
            _mainController = mainController;
        }

        public void Render()
        {
            Console.WriteLine("=== Car Repair ===");

            int engineInput;
            while (true)
            {
                Console.Write("Enter engine status (0=Good, 1=Normal, 2=Bad): ");
                if (int.TryParse(Console.ReadLine(), out engineInput) && engineInput >= 0 && engineInput <= 2)
                    break;

                Console.WriteLine("❌ Invalid input. Please enter a number between 0 and 2.");
            }

            int spareInput;
            while (true)
            {
                Console.Write("Enter spare status (0=No, 1=Yes): ");
                if (int.TryParse(Console.ReadLine(), out spareInput) && spareInput >= 0 && spareInput <= 1)
                    break;

                Console.WriteLine("❌ Invalid input. Please enter 0 or 1.");
            }

            int workshopChoice;
            while (true)
            {
                Console.Write("Which repair shop? (1=Bad, 2=Good): ");
                if (int.TryParse(Console.ReadLine(), out workshopChoice) && (workshopChoice == 1 || workshopChoice == 2))
                    break;

                Console.WriteLine("❌ Invalid choice. Please enter 1 or 2.");
            }

            // Call MainController to get the result
            string result = _mainController.HandleCarRepair(engineInput, spareInput, workshopChoice);

            // Display result
            Console.WriteLine("\n==== Result ====");
            Console.WriteLine(result);
        }
    }
}
