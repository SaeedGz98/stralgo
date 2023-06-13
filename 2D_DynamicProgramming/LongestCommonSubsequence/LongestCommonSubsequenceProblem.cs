namespace _2D_DynamicProgramming.LongestCommonSubsequence
{
    public static class LongestCommonSubsequenceProblem
    {
        public static int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] matrix = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 0; i < text1.Length + 1; i++)
            {
                for (int j = 0; j < text2.Length + 1; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            for (int i = text1.Length - 1; i >= 0; i--)
            {
                for (int j = text2.Length - 1; j >= 0; j--)
                {
                    if (text1[i] == text2[j])
                        matrix[i, j] = 1 + matrix[i + 1, j + 1];
                    else
                        matrix[i, j] = Math.Max(matrix[i, j + 1], matrix[i + 1, j]);
                }
            }

            return matrix[0, 0];
        }
    }
}