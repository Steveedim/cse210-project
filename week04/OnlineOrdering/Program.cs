using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Pen", "P001", 1.50, 10));
        order1.AddProduct(new Product("Notebook", "N002", 3.00, 5));

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Marker", "M003", 2.00, 4));
        order2.AddProduct(new Product("Sketchbook", "S004", 6.50, 2));

        PrintOrderSummary(order1);
        Console.WriteLine("\n----------------------\n");
        PrintOrderSummary(order2);
    }

    static void PrintOrderSummary(Order order)
    {
        Console.WriteLine("Packing Label:\n" + order.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
    }
}
