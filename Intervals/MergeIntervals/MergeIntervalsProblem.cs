namespace Intervals.MergeIntervals
{
    public static class MergeIntervalsProblem
    {
        public static int[][] Merge(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            List<int[]> res = new();

            for (int i = 0; i < intervals.Length; i++)
            {
                if (i + 1 < intervals.Length && HasOverlap(intervals[i], intervals[i + 1]))
                {
                    intervals[i + 1] = Merge(intervals[i], intervals[i + 1]);
                }
                else
                {
                    res.Add(intervals[i]);
                }
            }

            return res.ToArray();
        }

        private static bool HasOverlap(int[] interval1, int[] interval2)
        {
            return interval2[0] <= interval1[1] && interval2[1] >= interval1[0];
        }

        private static int[] Merge(int[] interval1, int[] interval2)
        {
            return new int[] { Math.Min(interval1[0], interval2[0]), Math.Max(interval1[1], interval2[1]) };
        }
    }
}