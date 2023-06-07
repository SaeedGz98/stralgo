namespace Greedy.GasStation
{
    public static class GasStationProblem
    {
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (cost.Sum() > gas.Sum())
                return -1;

            int total = 0;
            int res = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                total += (gas[i] - cost[i]);
            }
        }
    }
}