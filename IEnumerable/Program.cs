using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cohortStudentCount = new List<int>()
            {
                25, 12, 28, 22, 11, 25, 27, 24, 19
            };
            Console.WriteLine($"Largest cohort was {cohortStudentCount.Max()}");
            Console.WriteLine($"Smallest cohort was {cohortStudentCount.Min()}");
            Console.WriteLine($"Total students is {cohortStudentCount.Sum()}");


            IEnumerable<int> idealSizes = from count in cohortStudentCount
                                          where count < 27 && count > 19
                                          orderby count ascending
                                          select count;

            Console.WriteLine($"Average ideal size is {idealSizes.Average()}");

            Console.WriteLine($@"There were {idealSizes.Count()} ideally sized cohorts There have been {cohortStudentCount.Count()} total cohorts");

            // Give this C# List of numbers
            List<int> numbers = new List<int>() { 9, -59, 23, 71, -74, 13, 52, 44, 2 };

            /*
                Use the IEnumerable Where() method to build a new array of
                numbers that match two conditions. Then chain the OrderBy()
                method to order them ascending
            */
            var smallPositiveNumbers = numbers.Where(n => n < 40 && n > 0).OrderBy(n => n);

            /*
                Use All() to see if every item in the collection passes the
                provided conditions.
            */
            var allBetweenLarge = numbers.All(n => n > -100 && n < 400);  // true
            var allBetweenSmall = numbers.All(n => n > -5 && n < 39);  // false
            var allBetweenRandom = numbers.All(n => n < 5);  // false

            Console.WriteLine(allBetweenLarge);
            Console.WriteLine(allBetweenSmall);
            Console.WriteLine(allBetweenRandom);


            Console.ReadLine();
        }
        
    }
}

