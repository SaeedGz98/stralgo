namespace Intervals.InsertInterval
{
    public static class InsertIntervalProblem
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> res = new();

            foreach (int i in Enumerable.Range(0, intervals.Length))
            {
                if (newInterval[1] < intervals[i][0])
                {
                    res.Add(newInterval);
                    res.AddRange(intervals[i..].ToList());

                    return res.ToArray();
                }
                else if (newInterval[0] > intervals[i][1])
                {
                    res.Add(intervals[i]);
                }
                else
                {
                    newInterval = new int[] { Math.Min(newInterval[0], intervals[i][0]), Math.Max(newInterval[1], intervals[i][1]) };
                }
            }

            res.Add(newInterval);

            return res.ToArray();
        }
    }
}