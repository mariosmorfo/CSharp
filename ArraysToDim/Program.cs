namespace ArraysToDim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int MAX = 6;
            const int MIN = 1;

            int[,] grid = new int[3, 4];
            int[,] grid2 = { 
                { 1, 2, 3}, 
                { 4, 5, 6 }
            };

            for(int i = 0; i < grid2.GetLength(0); i++)
            {
                for(int j = 0; j < grid2.GetLength(1); j++)
                {
                    Console.WriteLine($"{grid2[i, j]}");
                }    
            }

            for (int i = 0; i < grid2.GetLength(0); i++)
            {
                for (int j = 0; j < grid2.GetLength(1); j++)
                {
                    grid[i, j] = random.Next(grid2[i, j]);
                }
            }

            /*
             * Jagged Arrays
             * 
             */

            int[][] jagged = new int[3][];
            jagged[0] = new int[3];
            jagged[1] = new int[4];
            jagged[2] = new int[5];

            for (int i = 0;i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged.GetLength(1); j++)
                {
                    Console.WriteLine($"{jagged[i][j]}");
                }
                Console.WriteLine();
            }
            foreach (int[] row in jagged)
            {
                foreach (int el in row)
                {
                    Console.WriteLine(el);
                }
            }

        }
    }
}
