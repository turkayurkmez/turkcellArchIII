using DDDElements.Entites;
using DDDElements.ValueObject;

namespace DDDElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer customer = new Customer();
            Product product = new Product();
            Address address = new Address();
            customer.CreateOrder(product, address);
        }
    }
}