using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime purchaseDate = DateTime.Now;

            string lastName = "Smith";

            var firstName = "Bill";

            Console.WriteLine($"{firstName} {lastName} visited on {purchaseDate}");
            Console.ReadLine();
            string[] products = new string[] { "Motorcycle", "Sofa", "Sandals", "Omega Watch", "iPhone" };
            foreach (var product in products)

            {
                Console.WriteLine(product);
            }

            foreach (string product in products)
            {
                if (product.Length > 5)
                {
                    Console.WriteLine(product);
                }
            }




        }
    }
}
