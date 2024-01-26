using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool v in vals)
            {
                if (v == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            int sum = 0;
            foreach (int x in numbers)
            {
                sum += x;
            }
            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string uppercaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseAlphabet = uppercaseAlphabet.ToLower();
            string numbers = "1234567890";

            bool containsLower = false;
            bool containsUpper = false;
            bool containsNumber = false;
            char[] characters = password.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (uppercaseAlphabet.Contains(characters[i]))
                {
                    containsUpper = true;
                }
                else if (lowercaseAlphabet.Contains(characters[i]))
                {
                    containsLower = true;
                }
                else if (numbers.Contains(characters[i]))
                {
                    containsNumber = true;
                }
            }

            return containsLower && containsUpper && containsNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddsBelow100 = new int[50];
            int odd = 1;
            for (int i = 0; i < 50; i++)
            {
                oddsBelow100[i] = odd;
                odd+=2;
            }
            return oddsBelow100;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
