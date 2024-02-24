using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int divisible = 0;
            for (int i = startNumber + 1; i > startNumber; i++)
            {
                if (i % n == 0)
                {
                    divisible = i;
                    break;
                }
            }
            return divisible;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business b in businesses)
            {
                if (b.TotalRevenue == 0) b.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            int[] sortedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sortedNumbers[i] = numbers[i];
            }
            Array.Sort(sortedNumbers);

            bool isSame = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (sortedNumbers[i] != numbers[i]) isSame = false;
            }
            return isSame;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";

            var wordList = new List<string>();
            foreach (var w in words) wordList.Add(w);

            string validWordChar = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            for (int i = wordList.Count - 1; i >= 0; i--)
            {
                bool validWord = false;
                bool erroneousSpaces = false;
                foreach (char c in wordList[i])
                {
                    if (validWordChar.Contains(c)) validWord = true;
                    if (c == ' ') erroneousSpaces = true;
                }
                if (!validWord) wordList.Remove(wordList[i]);
                else if (erroneousSpaces)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int x = 0; x < wordList[i].Length; x++)
                    {
                        char c = wordList[i][x];
                        if (validWordChar.Contains(c)) sb.Append(c);
                    }
                    wordList[i] = sb.ToString();
                }
            }
            if (wordList.Count == 0) return "";
            string sentence = $"{string.Join(" ", wordList)}.";
            Console.WriteLine(sentence);
            return sentence;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0) sum += numbers[i + 1];
            }
            return sum;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) return new double[] { };
            var everyFourth = new double[elements.Count / 4];
            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 4 == 3)
                {
                    everyFourth[i / 4] = elements[i];
                }
            }
            return everyFourth;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool onTarget = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 0; x < nums.Length; x++)
                {
                    if (x == i) break;
                    if (nums[i] + nums[x] == targetNumber) onTarget = true;
                }
            }
            return onTarget;
        }
    }
}
