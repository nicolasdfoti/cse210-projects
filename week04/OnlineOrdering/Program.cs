using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();



        // First Order
        Product product = new Product("Old Plate", "1234", 44, 1);
        Address address = new Address("1st Street", "Provo", "Utah", "USA");
        Customer customer = new Customer("John Doe", address);

        List<Product> products1 = new List<Product>() {product};
        Order order1 = new Order(products1, customer);

        Console.WriteLine("- First Order: ");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine();



        // Second Order
        Product secondProduct = new Product("Nicolás Foti", "5555", 10, 2);
        Address secondAddress = new Address("Manuel García", "Villa Adelina", "Buenos Aires", "Argentina");
        Customer secondCustomer = new Customer("Videogames", secondAddress);

        List<Product> products2 = new List<Product>() {secondProduct};
        Order order2 = new Order(products2, secondCustomer);

        Console.WriteLine("- Second Order:");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine();



        // Third Order
        Product thirdProduct = new Product("Sofía Ortega", "1357", 20, 3);
        Address thirdAddress = new Address("Vicente", "Pilar", "Buenos Aires", "Argentina");
        Customer thirdCustomer = new Customer("Bus Tickets", thirdAddress);

        List<Product> products3 = new List<Product>() {thirdProduct};
        Order order3 = new Order(products3, thirdCustomer);

        Console.WriteLine("- Third Order:");
        order3.DisplayPackingLabel();
        order3.DisplayShippingLabel();
        Console.WriteLine();



        // Fourth Order
        Product fourthProduct = new Product("Phone", "2468", 500, 1);
        Address fourthAddress = new Address("3rd Street", "New York", "New York", "USA");
        Customer fourthCustomer = new Customer("Andy Carroll", fourthAddress);

        List<Product> products4 = new List<Product>() {fourthProduct};
        Order order4 = new Order(products4, fourthCustomer);

        Console.WriteLine("- Fourth Order:");
        order4.DisplayPackingLabel();
        order4.DisplayShippingLabel();
        Console.WriteLine();
        
    }
}