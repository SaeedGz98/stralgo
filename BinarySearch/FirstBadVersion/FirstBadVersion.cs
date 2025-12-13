namespace BinarySearch.FirstBadVersion
{
    /* The isBadVersion API is defined in the parent class VersionControl.
          bool IsBadVersion(int version); */

    // Base class simulating LeetCode's VersionControl
    public class VersionControl
    {
        private int _badVersion;

        public VersionControl(int bad = 4)
        {
            _badVersion = bad;
        }

        protected bool IsBadVersion(int version)
        {
            return version >= _badVersion;
        }
    }

    public class Solution : VersionControl
    {
        public Solution(int bad = 4) : base(bad)
        {
        }

        public int FirstBadVersion(int n)
        {
            int start = 1;
            int end = n;
            int firstBad = n;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (IsBadVersion(mid))
                {
                    firstBad = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return firstBad;
        }
    }
}
