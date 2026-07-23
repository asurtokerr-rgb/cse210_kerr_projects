using System;

class Program
{
    static void Main(string[] args)
    {
        // Order #1
        Address address1 = new Address("800 Harrison", "Topeka", "KS", "USA");
        Customer customer1 = new Customer("Steve Kerr", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Iphone 17", "GHE23", 799.99, 1));
        order1.AddProduct(new Product("Apple AirPods Pro", "IK24C", 249.99, 1));

        // order #2
        Address address2 = new Address("456 Rodriguez", "Morong", "Rizal", "Philippines");
        Customer customer2 = new Customer("Juan Dela Cruz", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Hasbro Thanos Infinity Guantlet", "L3000", 119.50, 1));
        order2.AddProduct(new Product("LED replica Infinity stone", "AEG126", 15.00, 6));

        //Order #1 Display
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Price (incl. shipping): ${order1.CalculateTotalCost():F2}");
        Console.WriteLine(new string('=', 40));
        Console.WriteLine();


        //Order #2 Display
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Price (incl. shipping): ${order2.CalculateTotalCost():F2}");
        Console.WriteLine(new string('=', 40));
    }

}