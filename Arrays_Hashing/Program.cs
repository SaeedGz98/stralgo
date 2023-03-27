using Arrays_Hashing.GroupAnagrams;

var name = "daseed";
name = string.Concat(name.OrderBy(x => x));

//var indexes = TwoSumProblem.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
var groupAnagrams = GroupAnagramsProblem.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });


Console.ReadLine();