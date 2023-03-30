namespace Arrays_Hashing.ValidSudoku
{
    public static class ValidSudokuProblem
    {
        public static bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<int>> cols = new();
            Dictionary<int, HashSet<int>> rows = new();
            Dictionary<(int i, int j), HashSet<int>> squares = new();

            for (int i = 0; i < 9; i++)
            {
                if (!cols.ContainsKey(i))
                    cols[i] = new HashSet<int>();

                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                        continue;

                    if (!rows.ContainsKey(j))
                        rows[j] = new HashSet<int>();

                    if (!squares.ContainsKey((i / 3, j / 3)))
                        squares[(i / 3, j / 3)] = new HashSet<int>();

                    if (!cols[i].Add(board[i][j]))
                        return false;

                    if (!rows[j].Add(board[i][j]))
                        return false;

                    if (!squares[(i / 3, j / 3)].Add(board[i][j]))
                        return false;
                }
            }

            return true;
        }
    }
}