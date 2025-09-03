namespace OptionalParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = GetDateTime();
            Console.WriteLine($"{dateTime:F}");
        }

        public static DateTime GetDateTime(int year = 2025, int month = 9, int day = 3, int min = 0, int sec = 0, int milli = 0)
        { 
            return new DateTime(year, month, day, min, sec, milli, DateTimeKind.Utc); 
        }
    }
}
