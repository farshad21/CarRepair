using Models;

public class GoodRepairShop : RepairShopBase
{
    protected override string HandleRepair(Car car)
    {
        if (car.Spare == SpareStatus.No)
        {
            // Dynamic message for No Spare
            return $"{Messages.NoSpare} The engine was delivered healthy.";
        }

        if (car.Engine == EngineStatus.Good)
            return Messages.EngineHealthy;

        return Messages.EngineFixed;
    }
}
