using Models;

public class BadRepairShop : RepairShopBase
{
    protected override string HandleRepair(Car car)
    {
        if (car.Spare == SpareStatus.No)
        {
            // Dynamic message for No Spare
            return $"{Messages.NoSpare} The engine was broken.";
        }

        // If spare exists
        return "The spare tire was stolen and the engine was broken.";
    }
}
