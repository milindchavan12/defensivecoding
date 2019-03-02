using System;
using ACM.BL;
using ACM.Common;

namespace ACM.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaceOrder();
        }

        private static void PlaceOrder()
        {
            System.Console.WriteLine("Processing Customer Order");

            var customer = new Customer();
            var order = new Order();
            var payment = new Payment();

            var customerRepository = new CustomerRepository();
            var orderRepository = new OrderRepository();
            var inventoryRepository = new InventoryRepository();

            var orderController = new OrderController(customerRepository, orderRepository, inventoryRepository);
            orderController.PlaceOrder(customer, order, payment, emailReceipt:true);
        }
    }
}
