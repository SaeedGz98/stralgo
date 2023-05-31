namespace Graphs.RottingOranges
{
    public static class RottingOrangesProblem
    {
        public static int OrangesRotting(int[][] grid)
        {
            int rows = grid.Length, cols = grid[0].Length;
            Queue<(int r, int c)> queue = new();
            int times = 0, fresh = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r][c] == 1)
                        fresh++;

                    if (grid[r][c] == 2)
                        queue.Enqueue((r, c));
                }
            }

            (int dr, int dc)[] directions = { (1, 0), (0, 1), (-1, 0), (0, -1) };

            while (queue.Count > 0 && fresh > 0)
            {
                foreach (var i in Enumerable.Range(0, queue.Count))
                {
                    (int r, int c) = queue.Dequeue();

                    foreach ((int dr, int dc) in directions)
                    {
                        int row = r + dr;
                        int col = c + dc;

                        if (row < 0 || col < 0 || row == rows || col == cols && grid[row][col] != 1)
                            continue;

                        fresh--;
                        grid[row][col] = 2;
                        queue.Enqueue((row, col));
                    }
                }

                times++;
            }

            return fresh == 0 ? times : -1;
        }
    }
}