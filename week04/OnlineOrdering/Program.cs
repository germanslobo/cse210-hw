namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("     ONLINE ORDERING SYSTEM OUTPUT      ");
        Console.WriteLine("========================================\n");

        // --------------------------------------------------
        // ORDER 1: Domestic Customer (USA)
        // --------------------------------------------------
        Address address1 = new Address("123 Main Street", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.50m, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.00m, 1));
        order1.AddProduct(new Product("USB-C Cable", "P103", 8.99m, 3));

        DisplayOrderDetails(order1, "1");

        // --------------------------------------------------
        // ORDER 2: International Customer (Non-USA)
        // --------------------------------------------------
        Address address2 = new Address("456 Queen St W", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("27-inch Monitor", "P201", 220.00m, 1));
        order2.AddProduct(new Product("HDMI Cable 6ft", "P202", 12.50m, 2));

        DisplayOrderDetails(order2, "2");
    }

    static void DisplayOrderDetails(Order order, string orderNumber)
    {
        Console.WriteLine($"================ ORDER #{orderNumber} ================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.GetTotalCost():F2}\n");
    }
}