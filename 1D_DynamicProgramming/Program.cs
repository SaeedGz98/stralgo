using _1D_DynamicProgramming.MaximumProductSubarray;
using _1D_DynamicProgramming.MaximumSubarray;
using System;

int result = MaximumSubarrayProblem.MaxSubArray([-2, -1, -3]);
int result2 = MaximumProductSubarrayProblem.MaxProduct([0, 10, 10, 10, 10, 10, 10, 10, 10, 10, -10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 0]);
int result3 = MaximumProductSubarrayProblem.MaxProduct2([0, 10, 10, 10, 10, 10, 10, 10, 10, 10, -10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 0]);

Console.WriteLine(result);