using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two products
            Product product1 = new Product("Product 1", "P1", 10, 2);
            Product product2 = new Product("Product 2", "P2", 20, 1);

            // Create a list of products
            List<Product> products = new List<Product> { product1, product2 };

            // Create an address
            Address address = new Address("123 Main St", "San Francisco", "CA", "USA");

            // Create a customer
            Customer customer = new Customer("John Doe", address);

            // Create an order
            Order order = new Order(customer, products);

            // Display the results of the methods
            Console.WriteLine("Packing Label: ");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("\nShipping Label: ");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine("\nTotal Price: $" + order.GetTotalPrice());
        }
    }

    class Product
    {
        private string name;
        private string productId;
        private double price;
        private int quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public string GetProductId()
        {
            return productId;
        }

        public double GetPrice()
        {
            return price * quantity;
        }
    }

    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public Address GetAddress()
        {
            return address;
        }

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }
    }

    class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public string GetAddressString()
        {
            return streetAddress + "\n" + city + ", " + stateProvince + "\n" + country;
        }

        public bool IsInUSA()
        {
            return country == "USA";
        }
    }

    class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }
    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetPrice();
        }
        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += product.GetName() + " (Product ID: " + product.GetId() + ")\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += customer.GetName() + "\n" + customer.GetAddress().ToString();
        return shippingLabel;
    }
}
}



