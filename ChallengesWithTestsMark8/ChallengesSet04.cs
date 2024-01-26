using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null) return 0;
            int sum = 0;
            foreach (int n in numbers)
            {
                if (n%2==0) { sum += n; }
                else { sum -= n; }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] charCount = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            Array.Sort(charCount);
            return charCount[0];
        }

        public int GetSmallestNumber(int n1, int n2, int n3, int n4)
        {
            int[] numbers = new int[] { n1, n2, n3, n4 };
            Array.Sort(numbers);
            return numbers[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] sides = new int[] { sideLength1, sideLength2, sideLength3 };
            Array.Sort(sides);
            return sides[0] + sides[1] > sides[2];
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double d);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<object> list = new List<object>();
            foreach (object o in objs)
            {
                if (o == null) { list.Add(o); }
            }
            return list.Count * 2 > objs.Length;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            List<int> list = new List<int>();
            foreach (int n in numbers)
            {
                if (n%2==0)
                {
                    list.Add(n);
                }
            }
            if (list.Count == 0) return 0;
            return list.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            //if (number == 0) return 0;
            int f = 1;
            for (int x = 1; x <= number; x++)
            {
                f *= x;
            }
            return f;
        }
    }
}
