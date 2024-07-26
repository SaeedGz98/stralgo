using Arrays_Hashing.ContainsDuplicate;
using Arrays_Hashing.GroupAnagrams;
using Arrays_Hashing.ProductExceptSelf;
using Arrays_Hashing.RansomNote;
using Arrays_Hashing.TwoSum;
using Arrays_Hashing.ValidAnagram;
using Arrays_Hashing.ValidSudoku;

int[] result = TwoSumProblem.TwoSum([2, 7, 11, 15], 9);
int[] result2 = ProductExceptSelfProblem.ProductExceptSelf([1, 2, 3, 4]);
bool result3 = ContainsDuplicateProblem.ContainsDuplicate([1, 2, 3, 1]);
bool result4 = ValidAnagramProblem.IsAnagram("anagram", "nagaram");
bool result5 = ValidAnagramProblem.IsAnagram2("rat", "car");
bool result6 = RansomNoteProblem.CanConstruct("aa", "aba");
IList<IList<string>> result7 = GroupAnagramsProblem.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
var result8 = ValidSudokuProblem.IsValidSudoku([['5','3','.','.','7','.','.','.','.']
,['6','.','.','1','9','5','.','.','.']
,['.','9','8','.','.','.','.','6','.']
,['8','.','.','.','6','.','.','.','3']
,['4','.','.','8','.','3','.','.','1']
,['7','.','.','.','2','.','.','.','6']
,['.','6','.','.','.','.','2','8','.']
,['.','.','.','4','1','9','.','.','5']
,['.','.','.','.','8','.','.','7','9']]);

Console.ReadLine();