using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Program1
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Welcome to the product management program!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Add(products);
                    break;
                case 2:
                    Display(products);
                    break;
                case 3:
                    Delete(products);
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the program");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }
        }

        static void Add(List<Product> products)
        {
            Console.WriteLine("Enter product ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            decimal price = decimal.Parse(Console.ReadLine());

            Product product = new Product(id, name, price);
            products.Add(product);

            Console.WriteLine("Product added successfully!");
        }
        static void Display(List<Product> products)
        {
            if (products.Count == 0)
            {
                Console.WriteLine("There are no products to display.");
                return;
            }
            Console.WriteLine("{0,-10}{1,-20}{2,-10}", "ID", "Name", "Price");
            foreach (Product product in products)
            {
                Console.WriteLine("{0,-10}{1,-20}{2,-10}", product.Id, product.Name, product.Price);
            }
        }

        static void Delete(List<Product> products)
        {
            Console.WriteLine("Enter the product ID to delete:");
            string id = Console.ReadLine();

            Product productToDelete = null;
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    productToDelete = product;
                    break;
                }
            }
            if (productToDelete == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            products.Remove(productToDelete);
            Console.WriteLine("Product deleted successfully");
        }
    }
}
