namespace Intervals.Non_overlappingIntervals
{
    public static class Non_overlappingIntervalsProblem
    {
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));
            int res = 0;
            int lastEnd = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= lastEnd)
                {
                    lastEnd = intervals[i][1];
                }
                else
                {
                    res++;
                    lastEnd = Math.Min(lastEnd, intervals[i][1]);
                }
            }

            return res;
        }
    }
}