using Views;

namespace Controllers
{
    public class MainController
    {
        private readonly CarController _carController;

        public MainController()
        {
            _carController = new CarController();
        }

        // Gateway to CarView
        public void HandleCarView()
        {
            // CarView خودش ورودی می‌گیرد و خروجی را نمایش می‌دهد
            var carView = new CarView(this);
            carView.Render();
        }

        // Called by CarView to process car repair
        public string HandleCarRepair(int engineStatus, int spareStatus, int workshopChoice)
        {
            return _carController.RepairCar(engineStatus, spareStatus, workshopChoice);
        }
    }
}
