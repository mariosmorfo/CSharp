namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];

            /*
             * Query Syntax
             */

            IEnumerable<int> allNumbers = from num in numbers select num;
            foreach ( var num in numbers )
            {
                Console.WriteLine( num );
            }

            var oddNums = from num in numbers where num % 2 !=0 select num;
            foreach( var num in oddNums )
            {
                Console.WriteLine( num );
            }

            var evenNums = from num in numbers where num % 2 == 0 select num;
            foreach(var num in evenNums)
            {
                Console.WriteLine( num );
            }
            evenNums.ToList().ForEach(x => Console.WriteLine( x ));

            List<int> evensOrderedDesc = (from num in numbers 
                                          where num % 2 == 0
                                          orderby num descending
                                          select num).ToList();

            evensOrderedDesc.ForEach(x => Console.WriteLine( x ));
        

        /*
         * Fluent API
         */

            //Filtering
            var evenNumsFluent = numbers.Where(n=> n % 2 == 0);
            Console.WriteLine(string.Join(", ", evenNumsFluent));

            //Mapping
            var squares = numbers.Select(n => n * n).ToList();
            squares.ForEach(Console.WriteLine);

            //Reduce
            var sum = numbers.Sum();
            Console.WriteLine(sum);

            //Min, Max, Average
            var min = numbers.Min();
            var max = numbers.Max();
            var avg = numbers.Average();
            Console.WriteLine(min + ", " + max + " ," + avg);

            var anyGE10 = numbers.Any(n => n >= 10);
            Console.WriteLine("Any GE 10: " + anyGE10);

            var allGT0 = numbers.All(n => n> 0);
            Console.WriteLine("All GE 10: "+ allGT0);

            var odds = numbers.Where(n => n % 2 != 0).Select(n => n * 2).ToList();

        }
    }
}
