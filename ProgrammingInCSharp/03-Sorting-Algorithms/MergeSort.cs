using System;

namespace Algorithms.DivideAndConquer
{
    public class MergeSort
    {
        public static void RunExample()
        {
            // Example array to sort
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            // Perform Merge Sort
            MergeSortAlgorithm(numbers, 0, numbers.Length - 1);

            Console.WriteLine("\nSorted Array:");
            PrintArray(numbers);
        }

        // 1. Merge Sort Algorithm (Divide and Conquer)
        private static void MergeSortAlgorithm(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left + right) / 2;

                // Recursively sort the first and second halves
                MergeSortAlgorithm(arr, left, middle);
                MergeSortAlgorithm(arr, middle + 1, right);

                // Merge the sorted halves
                Merge(arr, left, middle, right);
            }
        }

        // Merge two subarrays of arr[].
        // First subarray is arr[left..middle]
        // Second subarray is arr[middle+1..right]
        private static void Merge(int[] arr, int left, int middle, int right)
        {
            // Sizes of two subarrays to be merged
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Temporary arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temporary arrays
            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[middle + 1 + j];

            // Merge the two arrays back into arr[left..right]
            int iIndex = 0, jIndex = 0;
            int kIndex = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    arr[kIndex] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    arr[kIndex] = rightArray[jIndex];
                    jIndex++;
                }
                kIndex++;
            }

            // Copy the remaining elements of leftArray, if any
            while (iIndex < n1)
            {
                arr[kIndex] = leftArray[iIndex];
                iIndex++;
                kIndex++;
            }

            // Copy the remaining elements of rightArray, if any
            while (jIndex < n2)
            {
                arr[kIndex] = rightArray[jIndex];
                jIndex++;
                kIndex++;
            }
        }

        // Utility function to print the array
        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
