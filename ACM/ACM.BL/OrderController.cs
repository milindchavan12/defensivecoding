using System;
using ACM.Common;

namespace ACM.BL
{
    public class OrderController
    {
        private CustomerRepository customerRepository;
        private OrderRepository orderRepository;
        private InventoryRepository inventoryRepository;


        public OrderController(CustomerRepository _customerRepository,
                               OrderRepository _orderRepository,
                               InventoryRepository _inventoryRepository)
        {
            customerRepository = _customerRepository;
            orderRepository = _orderRepository;
            inventoryRepository = _inventoryRepository;
        }

        public void PlaceOrder(Customer customer, Order order, Payment payment, bool emailReceipt)
        {
            //1. Add New Customer
            customerRepository.Add(customer);

            //2. Add Order
            orderRepository.Add(order);

            //3. Substract from Inventory
            inventoryRepository.OrderItems(order);

            //4. Process Payment
            payment.ProcessPayment(payment);

            //5. Email Notifications
            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();

                Email.Send(customer.EmailAddress, "Order Sent");
            }
        }
    }
}
