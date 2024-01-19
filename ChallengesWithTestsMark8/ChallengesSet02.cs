using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            return letters.Contains(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers?.Min() + numbers?.Max() ?? 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            return (length1 > length2) ? length2 : length1;
        }

        public int Sum(int[] numbers)
        {
            return numbers?.Sum() ?? 0;
        }

        
        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return sum;
            }
            else
            {
                foreach (int n in numbers)
                {
                    if (n % 2 == 0)
                    {
                        sum += n;
                    }
                }
            }
            
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers?.Sum() % 2 ?? 0) != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            number = (number % 2 != 0) ? number - 2 : number - 1;
            int count = 0;
            for (long n = number; n > 0; n-=2)
            {
                ++count;
            }
            return count;
        }
    }
}
