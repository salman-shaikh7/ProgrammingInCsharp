using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SearchingAlgorithms
{
    public class SearchTimeComparison
    {
        public static void RunExample()
        {
            // Compare Search Times between Linear Search, Binary Search in Array, and Dictionary Search
            Console.WriteLine("Search Time Comparison: Linear Search (Array), Binary Search (Array), and Dictionary Search\n");
            CompareSearchTimes();
        }

        // Compare Search Times between Linear Search, Binary Search in Arrays, and Dictionary Search
        private static void CompareSearchTimes()
        {
            Console.WriteLine("\n-- Comparing Search Times --");
            int numbersToCheck = 10000;
            Random random = new Random();

            // Arrays and Dictionary for comparison
            int[] numbersSearchArray = new int[numbersToCheck];
            Dictionary<int, int> numbersSearchDictionary = new Dictionary<int, int>();

            // Populate both the array and dictionary with sorted data
            for (int i = 0; i < numbersToCheck; i++)
            {
                int randomNumber = random.Next();
                numbersSearchArray[i] = randomNumber;
                numbersSearchDictionary[randomNumber] = randomNumber;
            }

            // Sort the array for Binary Search
            Array.Sort(numbersSearchArray);

            // Measuring Linear Search time in Array
            Console.WriteLine("Measuring Linear Search time in Array...");
            var linearSearchTime = MeasureLinearSearchTime(random, numbersSearchArray, numbersToCheck);
            Console.WriteLine($"Linear Search (Array) took: {linearSearchTime} ticks");

            // Measuring Binary Search time in Array
            Console.WriteLine("Measuring Binary Search time in Array...");
            var binarySearchTime = MeasureBinarySearchTime(random, numbersSearchArray, numbersToCheck);
            Console.WriteLine($"Binary Search (Array) took: {binarySearchTime} ticks");

            // Measuring Dictionary Search time
            Console.WriteLine("Measuring Dictionary Search time...");
            var dictionarySearchTime = MeasureDictionarySearchTime(random, numbersSearchDictionary, numbersToCheck);
            Console.WriteLine($"Dictionary Search took: {dictionarySearchTime} ticks");

            // Conclusion
            Console.WriteLine($"\n-- Conclusion --");
            Console.WriteLine("Binary Search is faster than Linear Search in large arrays, but Dictionary Search outperforms both.");
        }

        // Method to measure Linear Search time in an array
        private static long MeasureLinearSearchTime(Random random, int[] numbersArray, int numbersToCheck)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < numbersToCheck; i++)
            {
                FindInArrayLinear(random.Next(), numbersArray);
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        // Method to measure Binary Search time in an array
        private static long MeasureBinarySearchTime(Random random, int[] numbersArray, int numbersToCheck)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < numbersToCheck; i++)
            {
                Array.BinarySearch(numbersArray, random.Next());
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        // Method to measure search time in a dictionary
        private static long MeasureDictionarySearchTime(Random random, Dictionary<int, int> numbersDictionary, int numbersToCheck)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < numbersToCheck; i++)
            {
                numbersDictionary.TryGetValue(random.Next(), out _);
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        // Method for Linear Search in an array
        private static int FindInArrayLinear(int numberToFind, int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == numberToFind)
                {
                    return i; // Element found
                }
            }
            return -1; // Element not found
        }
    }
}
