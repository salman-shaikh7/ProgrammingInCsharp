using System;

namespace IntroductionToProgramming
{
    public class ControlStructures
    {
        public static void RunExample()
        {
            // 1. If-Else Example
            IfElseExample();

            // 2. Switch-Case Example
            SwitchCaseExample();

            // 3. For Loop Example
            ForLoopExample();

            // 4. While Loop Example
            WhileLoopExample();

            // 5. Do-While Loop Example
            DoWhileLoopExample();

            // 6. Nested Loops Example
            NestedLoopExample();

            // 7. Break and Continue Example
            BreakAndContinueExample();

            Console.WriteLine("\n-- Control Structures Examples Completed --");
        }

        // 1. Conditional Statements: if-else
        private static void IfElseExample()
        {
            Console.WriteLine("\n-- If-Else Example --");

            int number = 15;

            if (number > 10)
            {
                Console.WriteLine($"{number} is greater than 10.");
            }
            else if (number == 10)
            {
                Console.WriteLine($"{number} is equal to 10.");
            }
            else
            {
                Console.WriteLine($"{number} is less than 10.");
            }
        }

        // 2. Switch-Case Example
        private static void SwitchCaseExample()
        {
            Console.WriteLine("\n-- Switch-Case Example --");

            int dayOfWeek = 3;

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }
        }

        // 3. For Loop Example
        private static void ForLoopExample()
        {
            Console.WriteLine("\n-- For Loop Example: Counting from 1 to 5 --");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 4. While Loop Example
        private static void WhileLoopExample()
        {
            Console.WriteLine("\n-- While Loop Example: Counting down from 5 to 1 --");

            int count = 5;
            while (count > 0)
            {
                Console.WriteLine(count);
                count--;
            }
        }

        // 5. Do-While Loop Example
        private static void DoWhileLoopExample()
        {
            Console.WriteLine("\n-- Do-While Loop Example --");

            int number = 0;
            do
            {
                Console.WriteLine($"Number is {number}");
                number++;
            } while (number < 5);
        }

        // 6. Nested Loops Example
        private static void NestedLoopExample()
        {
            Console.WriteLine("\n-- Nested Loop Example --");

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }
        }

        // 7. Break and Continue Example
        private static void BreakAndContinueExample()
        {
            Console.WriteLine("\n-- Break and Continue Example --");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Breaking at 5");
                    break; // Exit the loop when i is 5
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine($"Skipping even number: {i}");
                    continue; // Skip the rest of this loop iteration for even numbers
                }

                Console.WriteLine(i); // Only odd numbers will be printed before 5
            }
        }
    }
}
