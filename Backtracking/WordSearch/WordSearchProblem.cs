using System.Collections.Generic;

namespace Backtracking.WordSearch
{
    public static class WordSearchProblem
    {
        public static bool Exist(char[][] board, string word)
        {
            int ROWS = board.Length, COLUMN = board[0].Length;
            HashSet<(int r, int c)> path = new();

            bool DFS(int r, int c, int i)
            {
                if (i == word.Length)
                    return true;

                if (r < 0 || c < 0 ||
                    r >= ROWS || c >= COLUMN ||
                    word[i] != board[r][c] ||
                    path.Contains((r, c)))
                {
                    return false;
                }

                path.Add((r, c));

                bool res = (DFS(r + 1, c, i + 1) ||
                    DFS(r - 1, c, i + 1) ||
                    DFS(r, c + 1, i + 1) ||
                    DFS(r, c - 1, i + 1));

                path.Remove((r, c));

                return res;
            }

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMN; j++)
                {
                    if (DFS(i, j, 0))
                        return true;
                }
            }

            return false;
        }
    }
}