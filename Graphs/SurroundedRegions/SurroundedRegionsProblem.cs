namespace Graphs.SurroundedRegions
{
    public static class SurroundedRegionsProblem
    {
        public static void Solve(char[][] board)
        {
            int rows = board.Length, columns = board[0].Length;

            void Capture(int r, int c)
            {
                if (r < 0 || c < 0 || r == rows || c == columns || board[r][c] != 'O')
                    return;

                board[r][c] = 'T';
                Capture(r + 1, c);
                Capture(r, c + 1);
                Capture(r - 1, c);
                Capture(r, c - 1);
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (board[r][c] == 'O' && (r == 0 || r == rows - 1 || c == 0 || c == columns - 1))
                        Capture(r, c);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (board[r][c] == 'O')
                        board[r][c] = 'X';
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (board[r][c] == 'T')
                    {
                        board[r][c] = 'O';
                    }
                }
            }
        }
    }
}