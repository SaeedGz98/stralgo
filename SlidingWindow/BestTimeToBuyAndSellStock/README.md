# 🔹 Best Time to Buy and Sell Stock — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/best-time-to-buy-and-sell-stock

---

## 👉 Problem Summary

You are given an array `prices` where `prices[i]` is the price of a stock on day `i`.

You want to maximize profit by choosing a **single day to buy** and a **different later day to sell**.

Return the maximum profit you can achieve. If no profit is possible, return `0`.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Maximize profit with one transaction"**
**"Must buy before you sell (order matters)"**

Immediately trigger this thought:

🔔 **Two Pointers: Left = minimum buy price, Right = current sell price**

**Why?** You need to track the **lowest price so far** (best buy point) and compare it with every future price (potential sell point).

This screams **sliding window with two pointers**:
- Left pointer = cheapest price seen so far
- Right pointer = scans forward looking for max profit

---

## 🧠 Idea → Why Sliding Window?

The key insight: **You can only sell after you buy.**

As you scan the prices:
- Track the **lowest price** seen so far (best buy point)
- For each price, calculate the profit if you sold today
- Update the maximum profit

When you find a lower price than your current buy point, **update it** — this becomes your new potential buy point.

This is a **single-pass sliding window** approach where:
- `left` = buy day (minimum price)
- `right` = sell day (current day)

---

## ✔️ C# Solution

```csharp
public static int MaxProfit(int[] prices)
{
    int left = 0, right = 1;
    int maxProfit = 0;

    while (right < prices.Length)
    {
        if (prices[left] < prices[right])
        {
            int profit = prices[right] - prices[left];
            maxProfit = Math.Max(maxProfit, profit);
        }
        else
        {
            left = right;
        }

        right++;
    }

    return maxProfit;
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Think Minimum Price First

Always ask:

**"What's the cheapest price I've seen so far?"**

This is your buy point. Every price after that is a potential sell point.

### ✅ 2. Use Two Pointers (Sliding Window)

- `left` tracks the minimum price (buy day)
- `right` scans forward (potential sell day)
- When you find a lower price, move `left` to `right`

### ✅ 3. Only Update Left When Needed

Don't update the buy point unless you find a **strictly lower** price. Otherwise, just calculate profit and move right forward.

### ✅ 4. No Profit? Return 0

If prices only decrease, max profit stays `0` — which is correct.

---

## ⏱️ Time Complexity

**Time: O(n)**

- You scan the array once.
- Each operation (comparison, max calculation) is O(1).

**Space: O(1)**

- Only uses a few variables regardless of input size.
