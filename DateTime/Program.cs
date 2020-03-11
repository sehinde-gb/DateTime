using System;

namespace DateTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Invoke Constructor
            // Parameters mean: (year, month, day, hour, minute, second)
            var date01 = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine(date01);
        }
    }
}
