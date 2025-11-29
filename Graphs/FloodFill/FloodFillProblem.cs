namespace Graphs.FloodFill;

public class FloodFillProblem
{
    // DFS Approach (Recursive)
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int originalColor = image[sr][sc];

        if (originalColor == color)
            return image;

        FillWithDfs(image, sr, sc, originalColor, color);

        return image;
    }

    private void FillWithDfs(int[][] image, int row, int col, int originalColor, int newColor)
    {
        int rows = image.Length;
        int cols = image[0].Length;

        if (row < 0 || row >= rows || col < 0 || col >= cols || image[row][col] != originalColor)
        {
            return;
        }

        image[row][col] = newColor;

        FillWithDfs(image, row - 1, col, originalColor, newColor); // Up
        FillWithDfs(image, row + 1, col, originalColor, newColor); // Down
        FillWithDfs(image, row, col - 1, originalColor, newColor); // Left
        FillWithDfs(image, row, col + 1, originalColor, newColor); // Right
    }

    // BFS Approach (Iterative)
    public int[][] FloodFillBfs(int[][] image, int sr, int sc, int color)
    {
        int rows = image.Length;
        int cols = image[0].Length;

        int originalColor = image[sr][sc];

        if (originalColor == color)
            return image;

        Queue<(int row, int col)> queue = new();
        queue.Enqueue((sr, sc));

        while (queue.Count > 0)
        {
            (int row, int col) = queue.Dequeue();

            if (row < 0 || row >= rows || col < 0 || col >= cols || image[row][col] != originalColor)
            {
                continue;
            }

            image[row][col] = color;

            queue.Enqueue((row - 1, col)); // Up
            queue.Enqueue((row + 1, col)); // Down
            queue.Enqueue((row, col - 1)); // Left
            queue.Enqueue((row, col + 1)); // Right
        }

        return image;
    }
}