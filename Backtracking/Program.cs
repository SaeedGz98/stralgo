using Backtracking.Combinations;
using Backtracking.LetterCombinationsOfAPhoneNumber;
using Backtracking.Permutations;
using Backtracking.Subsets;
using System;
using System.Collections.Generic;

IList<IList<int>> result = CombinationsProblem.Combine(4, 2);
IList<IList<int>> result2 = SubsetsProblem.Subsets([1, 2, 3]);
IList<string> result3 = LetterCombinationsOfAPhoneNumberProblem.LetterCombinations("23");
IList<IList<int>> result4 = PermutationsProblem.Permute([1, 2, 3]);
IList<IList<int>> result5 = PermutationsProblem.Permute2([1, 2, 3]);

Console.WriteLine("|| Backtracking ||");