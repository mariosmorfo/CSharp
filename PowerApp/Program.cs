using System.Numerics;

namespace PowerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int myBase = 2;
           int power = 10;
           BigInteger result = 1;

            for (int i = 1; i >= power; i++)
            {
                result *= myBase;
            }
            Console.WriteLine($"{myBase} ^ {power} = {result}");
        }
    }
}
