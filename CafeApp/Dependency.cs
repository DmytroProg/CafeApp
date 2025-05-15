using CafeApp.Core.Interfaces;
using CafeApp.Services;
using CafeApp.Storage;
using CafeApp.Storage.Repositories;

namespace CafeApp;

internal static class Dependency
{
    private static CafeAppContext GetCafeAppContext()
    {
        return new CafeAppContext();
    }

    private static IOrderRepository GetOrderRepository()
    {
        return new OrderRepository(GetCafeAppContext());
    }

    public static IOrderService GetOrderService()
    {
        return new OrderService(GetOrderRepository());
    }
}
