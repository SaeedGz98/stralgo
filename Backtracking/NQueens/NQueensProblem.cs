using System.Collections.Generic;
using System.Linq;

namespace Backtracking.NQueens
{
    public static class NQueensProblem
    {
        public static IList<IList<string>> SolveNQueens(int n)
        {
            List<List<string>> res = new();
            HashSet<int> col = new();
            HashSet<int> posDiag = new(); //(r + c)
            HashSet<int> negDiag = new(); //(r - c)

            char[][] board = new char[n][];

            for (int i = 0; i < n; i++)
            {
                board[i] = new char[n];
                for (int j = 0; j < n; j++)
                {
                    board[i][j] = '.';
                }
            }

            void BackTrack(int r)
            {
                if (r >= n)
                {
                    res.Add(board.Select(x => string.Join("", x)).ToList());
                    return;
                }

                foreach (var c in Enumerable.Range(0, n))
                {
                    if (col.Contains(c) || posDiag.Contains(r + c) || negDiag.Contains(r - c))
                        continue;

                    board[r][c] = 'Q';
                    col.Add(c);
                    posDiag.Add(r + c);
                    negDiag.Add(r - c);

                    BackTrack(r + 1);

                    board[r][c] = '.';
                    col.Remove(c);
                    posDiag.Remove(r + c);
                    negDiag.Remove(r - c);
                }
            }

            BackTrack(0);

            return res.ToArray();
        }
    }
}