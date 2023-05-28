namespace Graphs.NumberOfIslands
{
    public static class NumberOfIslandsProblem
    {
        public static int NumIslands(char[][] grid)
        {
            int rows = grid.Length, columns = grid[0].Length;
            HashSet<(int r, int c)> visited = new();
            int island = default;

            void DFS(int r, int c)
            {
                Queue<(int r, int c)> queue = new();
                visited.Add((r, c));
                queue.Enqueue((r, c));

                while (queue.Count > 0)
                {
                    (int row, int col) = queue.Dequeue();
                    (int dr, int dc)[] directions = { (1, 0), (-1, 0), (0, 1), (0, -1) };

                    foreach (var (dr, dc) in directions)
                    {
                        int neighr = row + dr;
                        int neighc = col + dc;

                        if (Enumerable.Range(0, rows).Contains(neighr) &&
                            Enumerable.Range(0, columns).Contains(neighc) &&
                            grid[neighr][neighc] == '1' &&
                            !visited.Contains((neighr, neighc)))
                        {
                            queue.Enqueue((neighr, neighc));
                            visited.Add((neighr, neighc));
                        }
                    }
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (grid[r][c] == '1' && !visited.Contains((r, c)))
                    {
                        DFS(r, c);
                        island++;
                    }
                }
            }

            return island;
        }
    }
}