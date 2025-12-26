namespace Arrays_Hashing.MajorityElement;

public class MajorityElementProblem
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> frequencyMap = new();
        int majorityElement = 0;
        int highestFrequency = 0;

        foreach (int number in nums)
        {
            int currentFrequency = frequencyMap.GetValueOrDefault(number) + 1;
            frequencyMap[number] = currentFrequency;

            if (currentFrequency > highestFrequency)
            {
                highestFrequency = currentFrequency;
                majorityElement = number;
            }
        }

        return majorityElement;
    }

    public int MajorityElement_BoyerMoore(int[] nums)
    {
        int candidate = 0;
        int voteCount = 0;

        foreach (int number in nums)
        {
            if (voteCount == 0)
                candidate = number;

            voteCount += (number == candidate) ? 1 : -1;
        }

        return candidate;
    }
}