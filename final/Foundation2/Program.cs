using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Maple St", "Boise", "ID", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Coffee Mug", "P100", 8.50, 2));
        order1.AddProduct(new Product("Notebook", "P101", 3.25, 4));
        order1.AddProduct(new Product("Desk Lamp", "P102", 22.00, 1));

        Address address2 = new Address("55 Birch Lane", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Marcus Lee", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "P200", 45.00, 1));
        order2.AddProduct(new Product("Water Bottle", "P201", 12.00, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("PACKING LABEL");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("SHIPPING LABEL");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Price: {order.GetTotalCost():C}");
            Console.WriteLine();
        }
    }
}