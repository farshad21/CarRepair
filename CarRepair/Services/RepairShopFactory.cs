using System;
using Models;
using Services;

// Factory Pattern
public static class RepairShopFactory
{
    public static IRepairShop Create(int choice)
    {
        switch (choice)
        {
            case 1: return new BadRepairShop();
            case 2: return new GoodRepairShop();
            default: throw new ArgumentException("Invalid");
        }
    }
}