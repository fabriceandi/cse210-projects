using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Product product1 = new Product("Notebook",125,2.99,20);
        Product product2 = new Product("Backpack",220,29,5);
        Product product3 = new Product("Pencil",315,1.5,15);
        Product product4 = new Product("Laptop",50,1200,1);
        Product product5 = new Product("Bluetooth Portable Speaker",102,90,2);
        Address address1 = new Address("1600 Pennsylvania Avenue NW","Washington","DC","USA");
        Address address2 = new Address("123 Queen Street West","Toronto","Ontario","Canada");
        Customer customer1 = new Customer("Franck Gilbert", address1);
        Customer customer2 = new Customer("Emily Clark", address2);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        foreach(Order o in orders)
        {
            Console.WriteLine(o.ShippingLabel());
            Console.WriteLine(o.PackingLabel());
            Console.WriteLine($"Total : ${o.CalculateTotal()}");
            Console.WriteLine("");
        }
    }
}