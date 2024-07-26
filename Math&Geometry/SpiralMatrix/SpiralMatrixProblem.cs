namespace Math_Geometry.SpiralMatrix
{
    /// <summary>
    /// RECOMMENDED
    /// </summary>
    public class SpiralMatrixProblem
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = [];
            int left = 0, right = matrix[0].Length;
            int top = 0, bottom = matrix.Length;

            while (left < right && top < bottom)
            {
                for (int i = left; i < right; i++)
                    res.Add(matrix[top][i]);

                top++;

                for (int i = top; i < bottom; i++)
                    res.Add(matrix[i][right - 1]);

                right--;

                if (!(left < right && top < bottom))
                    break;

                for (int i = right - 1; i >= left; i--)
                    res.Add(matrix[bottom - 1][i]);

                bottom--;

                for (int i = bottom - 1; i >= top; i--)
                    res.Add(matrix[i][left]);

                left++;
            }

            return res;
        }
    }
}