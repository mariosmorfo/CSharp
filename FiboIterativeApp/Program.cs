namespace FiboIterativeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Fibo(int n)
        {
            int a = 0;
            int b = 1;
            int c = 2;

            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return (n != 0) ? c : 0;
        }
    }
}
