namespace Arrays_Hashing.ContainsDuplicate
{
    public static class ContainsDuplicateProblem
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seenNumbers = new(nums.Length);

            foreach (int num in nums)
            {
                if (!seenNumbers.Add(num))
                    return true;
            }

            return false;
        }
    }
}