namespace _2D_DynamicProgramming.LongestIncreasingPathinaMatrix
{
    public class LongestIncreasingPathinaMatrixProblem
    {
        public static int LongestIncreasingPath(int[][] matrix)
        {
            int rows = matrix.Length, cols = matrix[0].Length;
            Dictionary<(int r, int c), int> dp = new();

            int dfs(int r, int c, int preValue)
            {
                if (r < 0 || r == rows || c < 0 || c == cols || matrix[r][c] <= preValue)
                    return 0;

                if (dp.ContainsKey((r, c)))
                    return dp[(r, c)];

                int res = 1;
                res = Math.Max(res, 1 + dfs(r + 1, c, matrix[r][c]));
                res = Math.Max(res, 1 + dfs(r - 1, c, matrix[r][c]));
                res = Math.Max(res, 1 + dfs(r, c + 1, matrix[r][c]));
                res = Math.Max(res, 1 + dfs(r, c - 1, matrix[r][c]));

                dp[(r, c)] = res;

                return res;
            }

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    dfs(i, j, -1);

            return dp.Values.Max();
        }
    }
}