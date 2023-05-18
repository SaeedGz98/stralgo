using System.Collections.Generic;

namespace Backtracking.LetterCombinationsOfAPhoneNumber
{
    public static class LetterCombinationsOfAPhoneNumberProblem
    {
        public static IList<string> LetterCombinations(string digits)
        {
            List<string> res = new();
            Dictionary<char, string> digitsToChar = new()
            {
                { '2',  "abc" },
                { '3',  "def" },
                { '4',  "ghi" },
                { '5',  "jkl" },
                { '6',  "mno" },
                { '7',  "pqrs" },
                { '8',  "tuv" },
                { '9',  "wxyz" }
            };

            void BackTrack(int i, string curStr)
            {
                if (digits.Length == curStr.Length)
                {
                    res.Add(curStr);
                    return;
                }

                foreach (var character in digitsToChar[digits[i]])
                {
                    BackTrack(i + 1, curStr + character);
                }
            }

            if (!string.IsNullOrWhiteSpace(digits))
                BackTrack(0, "");

            return res;
        }
    }
}