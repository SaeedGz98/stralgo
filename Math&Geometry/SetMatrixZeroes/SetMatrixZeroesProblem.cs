namespace Math_Geometry.SetMatrixZeroes
{
    /// RECOMMENDED
    public class SetMatrixZeroesProblem
    {
        public static void SetZeroes(int[][] matrix)
        {
            int ROWS = matrix.Length, COLS = matrix[0].Length;
            bool rowZero = false;

            foreach (int r in Enumerable.Range(0, ROWS))
            {
                foreach (int c in Enumerable.Range(0, COLS))
                {
                    if (matrix[r][c] == 0)
                    {
                        matrix[0][c] = 0;

                        if (r > 0)
                            matrix[r][0] = 0;
                        else
                            rowZero = true;
                    }
                }
            }

            foreach (int r in Enumerable.Range(1, ROWS - 1))
            {
                foreach (int c in Enumerable.Range(1, COLS - 1))
                {
                    if (matrix[0][c] == 0 || matrix[r][0] == 0)
                    {
                        matrix[r][c] = 0;
                    }
                }
            }

            if (matrix[0][0] == 0)
            {
                foreach (int r in Enumerable.Range(0, ROWS))
                {
                    matrix[r][0] = 0;
                }
            }

            if (rowZero)
            {
                foreach (int c in Enumerable.Range(0, COLS))
                {
                    matrix[0][c] = 0;
                }
            }
        }
    }
}