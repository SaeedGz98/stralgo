# 🔹 Flood Fill — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/flood-fill/

---

## 👉 Problem Summary

You are given a 2D image represented as a grid of integers and a starting pixel position `(sr, sc)`. Perform a flood fill starting from that pixel: change its color to a new color, then recursively change all adjacent pixels (up, down, left, right) that share the same original color. Return the modified image after the flood fill is complete.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Fill all connected pixels with the same color"**
**"Spread through adjacent cells in a grid"**

Immediately trigger this thought:

🔔 **Graph Traversal using DFS (Depth-First Search) or BFS (Breadth-First Search)**

**Why?** Each pixel is a node, and 4-directional adjacency creates edges between nodes with the same color. This is a classic connected components problem on a 2D grid.

- **Original color** = nodes we can visit
- **New color** = mark as visited
- **4 directions** = edges to neighboring nodes

---

## 🧠 Idea → Why DFS or BFS?

The flood fill operation is fundamentally about exploring all reachable pixels from a starting point, which maps perfectly to graph traversal algorithms.

**DFS Approach (Recursive):** Start at the source pixel, change its color, then recursively explore all four adjacent neighbors. The recursion naturally handles the "spread" behavior. Base case: stop when you hit grid boundaries or encounter a pixel that doesn't match the original color.

**BFS Approach (Iterative):** Use a queue to process pixels level-by-level. Enqueue the starting pixel, then repeatedly dequeue pixels, change their color, and enqueue valid neighbors. This avoids deep recursion and uses explicit queue-based traversal.

**Key insight:** Check if `originalColor == newColor` at the start. If they're the same, return immediately to avoid infinite loops. Both approaches modify the grid in-place, so visited pixels are automatically marked by the color change.

**Algorithm steps:**
1. Store the original color at `image[sr][sc]`
2. If original color equals new color, return (no work needed)
3. Traverse (DFS or BFS) from `(sr, sc)`:
   - Change current pixel to new color
   - Visit all 4 adjacent neighbors that still have the original color
4. Return the modified image

---

## ✔️ C# Solution

### DFS Approach (Recursive)

```csharp
public class FloodFillProblem
{
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
}
```

### BFS Approach (Iterative)

```csharp
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
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Early Exit Optimization

Always check `if (originalColor == newColor)` before starting the flood fill. Without this check, you'll create an infinite loop since every pixel you "fill" would still match the original color.

### ✅ 2. In-Place Modification Acts as Visited Tracking

You don't need a separate `visited` array. By changing pixels to the new color as you traverse, you automatically mark them as visited. Any future traversal checks `image[row][col] != originalColor` and skips already-processed pixels.

### ✅ 3. DFS vs BFS Trade-offs

**DFS** uses recursion (call stack), which is cleaner code but risks stack overflow on very large connected regions. **BFS** uses explicit `Queue`, which is safer for large grids and guarantees no stack overflow, but requires more code and memory for the queue.

### ✅ 4. 4-Directional Traversal Pattern

The standard grid traversal pattern is `(row±1, col)` and `(row, col±1)`. This is a reusable pattern for many grid problems: flood fill, number of islands, shortest path in maze, etc. Memorize the 4 directions: `[(-1,0), (1,0), (0,-1), (0,1)]`.

---

## ⏱️ Time Complexity

### DFS Approach

**Time: O(rows × cols)**

- In the worst case, every pixel has the same color, so you visit all `rows × cols` pixels exactly once.
- Each pixel performs constant work (color change + 4 recursive calls).

**Space: O(rows × cols)**

- Recursion depth can reach `rows × cols` in the worst case (e.g., a snake-like path through the entire grid).
- Call stack consumes space proportional to the maximum recursion depth.

### BFS Approach

**Time: O(rows × cols)**

- Same as DFS: visit each pixel at most once.
- Queue operations (enqueue/dequeue) are O(1).

**Space: O(rows × cols)**

- The queue can hold up to `rows × cols` pixels in the worst case (e.g., when the entire grid is one connected component).
- More predictable than DFS recursion stack, but same asymptotic space usage.
