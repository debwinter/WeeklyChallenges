using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, world!");

            var c6 = new ChallengesSet06();
            //Console.WriteLine("Array: { 1, 2, 2, 3, 4, 5 }");
            //Console.WriteLine("Expected: 2");
            //Console.WriteLine($"Actual: {c6.MaxConsecutiveCount(new int[] { 1, 2, 2, 3, 4, 5 })}");
            //Console.WriteLine();

            //Console.WriteLine("Array: { 10, 3, 1, 1, 1, 5, 1 }");
            //Console.WriteLine("Expected: 3");
            //Console.WriteLine($"Actual: {c6.MaxConsecutiveCount(new int[] { 10, 3, 1, 1, 1, 5, 1 })}");
            //Console.WriteLine();

            //Console.WriteLine("Array: { 1, 2, 2, 3, 3, 3, 3, 2, 5 }");
            //Console.WriteLine("Expected: 4");
            //Console.WriteLine($"Actual: {c6.MaxConsecutiveCount(new int[] { 1, 2, 2, 3, 3, 3, 3, 2, 5 })}");
            //Console.WriteLine();

            Console.WriteLine("Array: { 1, 2, 2, 3, 3, 3, 3 }");
            Console.WriteLine("Expected: 4");
            Console.WriteLine($"Actual: {c6.MaxConsecutiveCount(new int[] { 1, 2, 2, 3, 3, 3, 3 })}");
            Console.WriteLine();

            //Console.WriteLine("Array: { 1, 2, 2, 3, 2 }");
            //Console.WriteLine("Expected: 2");
            //Console.WriteLine($"Actual: {c6.MaxConsecutiveCount(new int[] { 1, 2, 2, 3, 2 })}");
            //Console.WriteLine();

            //Console.WriteLine("Array: { 3, 3, 3, 2, 2 }");
            //Console.WriteLine("Expected: 3");
            //Console.WriteLine($"Actual: {c6.MaxConsecutiveCount(new int[] { 3, 3, 3, 2, 2 })}");
            //Console.WriteLine();

            //Console.WriteLine("Array: { 1, 3, 2, 3, 3, 3, 3 }");
            //Console.WriteLine($"Actual: {c6.MaxConsecutiveCount(new int[] { 1, 3, 2, 3, 3, 3, 3 })}");
            //Console.WriteLine("Expected: 4");
        }
    }
}
