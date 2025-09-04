using ProductsComparerApp.Model;

namespace ProductsComparerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products =
                [
                    new Product() {Description = "Milk", Price = 12.5, Quantity = 10 },
                    new Product() {Description = "Eggs", Price = 2.5, Quantity = 4 },
                     new Product() {Description = "Potatos", Price = 7, Quantity = 8 },
                     new Product() {Description = "Oranges", Price = 7, Quantity = 3 }

                ];

            products.Sort();
            products.ForEach(Console.WriteLine);

            Console.WriteLine();

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            products.ForEach(Console.WriteLine);

            Console.WriteLine();


            products.Sort((p1, p2) => p1.Quantity.CompareTo(p2.Quantity));
            products.ForEach(Console.WriteLine);

        }
    }

}