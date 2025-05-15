using CafeApp;
using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.Models;
using CafeApp.Storage;


while (true)
{
    ShowMenu();
    //var context = new CafeAppContext();

    //var names = context.Set<User>().Select(x => x.FirstName);

    Console.Write("Enter number: ");
    var index = int.Parse(Console.ReadLine());

    switch (index)
    {
        case 1:
            try
            {

                var orderService = Dependency.GetOrderService();

                Console.Write("Enter address: ");
                string address = Console.ReadLine();

                var dto = new AddOrderDto()
                {
                    Address = address,
                    CustomerId = 1,
                    ProductsIds = [1]
                };
                var order = await orderService.PlaceOrderAsync(dto, default);
               
                Console.WriteLine($"Order #{order.Id} was placed. Delivery to {order.Address}");
            }
            catch (Exception ex)
            {
                // errors
            }
                break;
    }
}


void ShowMenu()
{
    Console.WriteLine("1. Place order");
}