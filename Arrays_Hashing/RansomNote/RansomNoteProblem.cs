namespace Arrays_Hashing.RansomNote
{
    /// RECOMMENDED
    public static class RansomNoteProblem
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineResource = [];

            for (int i = 0; i < magazine.Length; i++)
                magazineResource[magazine[i]] = magazineResource.GetValueOrDefault(magazine[i], 0) + 1;

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (magazineResource.TryGetValue(ransomNote[i], out int count) && count > 0)
                    magazineResource[ransomNote[i]] = --count;
                else
                    return false;
            }

            return true;
        }
    }
}