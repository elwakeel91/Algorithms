using System;

namespace MyAlgorithms
{
    class BubbleSort
    {
        // Exchange the position of two values in an array
        private static void Exchange<T>(T[] data, int indexA, int indexB)
        {
            // Store the first value in a new temporary value
            T temp = data[indexA];

            // Set the first value equal to the second value
            data[indexA] = data[indexB];

            // Set the second value equal to the temporary value
            data[indexB] = temp;
        }

        // Sorts an integer array using Bubble Sort
        public static void Sort(int[] data)
        {
            // Loop through the array from the start
            for (int j = 0; j < data.Length; j++)
            {
                // Loop through the array from the end
                for (int i = data.Length - 1; i > j; i--)
                {
                    // Compare the value at index (i - 1) and (i)
                    // If the bigger value is on the left
                    if (data[i - 1] > data[i])
                        // Switch their positions
                        Exchange(data, (i - 1), i);
                }
            }
        }

        static void Main(string[] args)
        {
            // Create an array of integers
            int[] data = new int[] { 5, 9, 3, 1, 2, 8, 4, 7, 6 };

            // Sort the array using Bubble Sort
            Sort(data);

            // Print the array on the screen
            Console.WriteLine(string.Join(" ", data));

            // Wait for user input
            Console.ReadKey();
        }
    }
}
