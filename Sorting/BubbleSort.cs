using System;

namespace MyAlgorithms
{
    class BubbleSort
    {
        // Exchange the position of two values in an array
        private static void Exchange<T>(T[] data, int indexA, int indexB)
        {
            T temp = data[indexA];
            data[indexA] = data[indexB];
            data[indexB] = temp;
        }

        // Sorts an integer array using Bubble Sort
        public static void Sort(int[] data)
        {
            // The index of the two values we'll compare
            int indexA = 0;
            int indexB = 0;

            // Loop through the array from the start
            for (int j = 0; j < data.Length; j++)
            {
                // Loop through the array from the end
                for (int i = data.Length - 1; i > j; i--)
                {
                    // Get the index of the two values we'll compare
                    indexA = i - 1;
                    indexB = i;

                    // If the first value is bigger than the second value
                    if (data[indexA] > data[indexB])
                        // Switch their positions
                        Exchange(data, indexA, indexB);
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
