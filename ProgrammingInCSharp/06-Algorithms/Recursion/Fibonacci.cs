using System;
using System.Collections.Generic;

namespace Algorithms.Recursion
{
    public class Fibonacci
    {
        public static void RunExample()
        {
            int n = 10; // Example input

            // 1. Recursive Fibonacci (Exponential Time O(2^n))
            Console.WriteLine($"Recursive Fibonacci of {n}: {RecursiveFibonacci(n)}");

            // 2. Iterative Fibonacci (Linear Time O(n))
            Console.WriteLine($"Iterative Fibonacci of {n}: {IterativeFibonacci(n)}");

            // 3. Memoized Recursive Fibonacci (Optimized to O(n))
            Console.WriteLine($"Memoized Fibonacci of {n}: {MemoizedFibonacci(n)}");
        }

        // 1. Recursive Fibonacci (Exponential Time O(2^n))
        private static int RecursiveFibonacci(int n)
        {
            if (n <= 1)
            {
                return n; // Base cases: Fibonacci(0) = 0, Fibonacci(1) = 1
            }

            // Recursive calls
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        // 2. Iterative Fibonacci (Linear Time O(n))
        private static int IterativeFibonacci(int n)
        {
            if (n <= 1)
            {
                return n; // Base cases: Fibonacci(0) = 0, Fibonacci(1) = 1
            }

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b; // Fibonacci(i) = Fibonacci(i-1) + Fibonacci(i-2)
                a = b;
                b = c;
            }
            return c;
        }

        // 3. Memoized Recursive Fibonacci (Optimized to O(n))
        private static Dictionary<int, int> memo = new Dictionary<int, int>();

        private static int MemoizedFibonacci(int n)
        {
            if (n <= 1)
            {
                return n; // Base cases: Fibonacci(0) = 0, Fibonacci(1) = 1
            }

            // Check if the result is already calculated
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            // Recursive calls with memoization
            memo[n] = MemoizedFibonacci(n - 1) + MemoizedFibonacci(n - 2);
            return memo[n];
        }
    }
}
