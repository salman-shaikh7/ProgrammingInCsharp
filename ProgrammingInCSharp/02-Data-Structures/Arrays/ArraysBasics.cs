using System;

namespace DataStructures.Arrays
{
    public class ArraysBasics
    {
        public static void RunExample()
        {
            // 1. Array Declaration, Initialization, and Access
            ArrayDeclarationInitializationAccess();

            // 2. Single-Dimensional and Multi-Dimensional Arrays
            SingleAndMultiDimensionalArrays();

            // 3. Jagged Arrays
            JaggedArraysExample();

            // 4. Array Traversal (for and foreach)
            ArrayTraversalExample();

            // 5. Array Methods (Sort and Reverse)
            ArrayMethodsExample();

            Console.WriteLine("\n-- Arrays Basics Examples Completed --");
        }

        // 1. Array Declaration, Initialization, and Access
        private static void ArrayDeclarationInitializationAccess()
        {
            Console.WriteLine("\n-- Array Declaration, Initialization, and Access --");

            // Declaration of an array with a fixed size, but uninitialized values (all initialized to default 0)
            int[] numbersFixedSize = new int[5];
            numbersFixedSize[0] = 10;
            numbersFixedSize[1] = 20;

            Console.WriteLine("Fixed size array with some initialized values:");
            for (int i = 0; i < numbersFixedSize.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbersFixedSize[i]}");
            }

            // Declaration of an array with known values at the time of initialization
            int[] numbersWithValues = { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nArray with known values:");
            foreach (int number in numbersWithValues)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Declaration of an array and initialization later
            int[] laterInitializedArray;
            laterInitializedArray = new int[] { 7, 8, 9 };
            Console.WriteLine("\nArray declared and initialized later:");
            foreach (int number in laterInitializedArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Array declared with only a fixed size
            string[] stringArray = new string[3];
            stringArray[0] = "Hello";
            stringArray[1] = "World";
            Console.WriteLine("\nArray with fixed size and initialized later:");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }
        }

        // 2. Single-Dimensional and Multi-Dimensional Arrays
        private static void SingleAndMultiDimensionalArrays()
        {
            Console.WriteLine("\n-- Single-Dimensional and Multi-Dimensional Arrays --");

            // Single-Dimensional Array
            int[] singleDimArray = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Single-Dimensional Array:");
            for (int i = 0; i < singleDimArray.Length; i++)
            {
                Console.Write(singleDimArray[i] + " ");
            }
            Console.WriteLine();

            // Multi-Dimensional Array (2D Array)
            int[,] multiDimArray = new int[2, 3] // 2 rows and 3 columns
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            Console.WriteLine("\nMulti-Dimensional Array (2D):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(multiDimArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Accessing elements in a 2D array
            int element = multiDimArray[1, 2];
            Console.WriteLine($"Element at (1, 2): {element}");
        }

        // 3. Jagged Arrays Example
        private static void JaggedArraysExample()
        {
            Console.WriteLine("\n-- Jagged Arrays Example --");

            // Declaring a jagged array (array of arrays)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Traversing the jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Row {i + 1}:");
                foreach (int number in jaggedArray[i])
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            // Accessing specific elements in a jagged array
            int specificElement = jaggedArray[1][2];
            Console.WriteLine($"Element at jaggedArray[1][2]: {specificElement}");
        }

        // 4. Array Traversal (for and foreach)
        private static void ArrayTraversalExample()
        {
            Console.WriteLine("\n-- Array Traversal (for and foreach) --");

            int[] numbers = { 10, 20, 30, 40, 50 };

            // Traversing using a for loop
            Console.WriteLine("Using for loop:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            // Traversing using a foreach loop
            Console.WriteLine("\nUsing foreach loop:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // 5. Array Methods (Sort and Reverse)
        private static void ArrayMethodsExample()
        {
            Console.WriteLine("\n-- Array Methods: Sort and Reverse --");

            int[] numbers = { 5, 3, 8, 1, 4 };

            // Sorting the array
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Reversing the array
            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
