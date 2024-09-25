using System;

namespace Algorithms.DynamicProgramming
{
    public class KnapsackProblem
    {
        public static void RunExample()
        {
            // Example weights, values, and the maximum capacity of the knapsack
            int[] weights = { 2, 3, 4, 5 };  // weights of the items
            int[] values = { 3, 4, 5, 6 };   // values of the items
            int capacity = 5;                // maximum capacity of the knapsack

            int n = weights.Length;

            // Call the knapsack algorithm and print the result
            Console.WriteLine($"Maximum value in Knapsack: {Knapsack(n, capacity, weights, values)}");
        }

        // 1. 0/1 Knapsack Problem using Dynamic Programming (Bottom-up approach)
        private static int Knapsack(int n, int W, int[] weights, int[] values)
        {
            // dp[i][w] will store the maximum value for capacity w using first i items
            int[,] dp = new int[n + 1, W + 1];

            // Build the dp array in bottom-up manner
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= W; w++)
                {
                    // Base case: If no items or weight is 0, the maximum value is 0
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                    }
                    else if (weights[i - 1] <= w)
                    {
                        // Maximize value by either including or excluding the current item
                        dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                    }
                    else
                    {
                        // Exclude the current item if it exceeds the current weight capacity
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            // The bottom-right cell of the dp array contains the maximum value for the knapsack
            return dp[n, W];
        }

        // Optional: Utility function to print the dp table (useful for understanding the algorithm)
        private static void PrintDPTable(int[,] dp, int n, int W)
        {
            Console.WriteLine("DP Table:");
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= W; w++)
                {
                    Console.Write($"{dp[i, w]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
