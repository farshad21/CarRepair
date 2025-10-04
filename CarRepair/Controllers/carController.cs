using Services;
using Models;

namespace Controllers
{
    public class CarController
    {
        public string RepairCar(int engineInput, int spareInput, int workshopChoice)
        {
            // Build model
            var car = new Car
            {
                Engine = (EngineStatus)engineInput,
                Spare = (SpareStatus)spareInput
            };

            // Choose repair shop via Factory
            IRepairShop shop = RepairShopFactory.Create(workshopChoice);

            // Repair and return result
            return shop.Repair(car);
        }
    }
}
