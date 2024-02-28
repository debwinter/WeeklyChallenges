using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            bool iFoundIt = false;
            foreach (var w in words)
            {
                if (w == word) iFoundIt = true;
                else if (ignoreCase && w != null && w.ToLower() == word.ToLower()) iFoundIt = true;
            }
            return iFoundIt;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == null || num <= 1) return false;
            bool isPrime = true;
            for (int i = num - 1; i > 1; i--) if (num % i == 0) isPrime = false;
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1) return 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                bool foundMatch = false;
                for (int x = 0; x < str.Length; x++)
                {
                    if (x == i) continue;
                    else if (str[i] == str[x])
                    {
                        foundMatch = true;
                        break;
                    }
                }
                if (!foundMatch) return i;
            }
            return -1;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0) return new double[] { };
            var everyNth = new double[elements.Count / n];
            for (int i = 0; i < elements.Count; i++)
            {
                if (i % n == n - 1)
                {
                    everyNth[i / n] = elements[i];
                }
            }
            return everyNth;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int counter1 = 1;
            int counter2 = 1;
            int maxcounter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1]) counter1++;
                else
                {
                    for (int x = i+1; x < numbers.Length - 1; x++)
                    {
                        if (numbers[x] == numbers[x + 1]) counter2++;
                        else
                        {
                            i = x;
                            break;
                        }
                    }
                    if (Math.Max(counter1, counter2) > maxcounter) maxcounter = Math.Max(counter1, counter2);
                    counter1 = 1;
                    counter2 = 1;
                }
            }
            if (Math.Max(counter1, counter2) > maxcounter) maxcounter = Math.Max(counter1, counter2);
            if (maxcounter == 1) return 0;
            else return maxcounter;
        }
    }
}
