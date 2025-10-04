using Models;
using Services;

public abstract class RepairShopBase : IRepairShop
{
    public string Repair(Car car)
    {
        return HandleRepair(car); // دیگه شرط NoSpare اینجا حذف شد
    }

    protected abstract string HandleRepair(Car car);
}
