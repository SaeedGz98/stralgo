﻿namespace Greedy.JumpGame
{
    public static class JumpGameProblem
    {
        public static bool CanJump(int[] nums)
        {
            int goal = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] + i >= goal)
                {
                    goal = i;
                }
            }

            return goal == 0;
        }
    }
}