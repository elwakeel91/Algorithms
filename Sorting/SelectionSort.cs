namespace MyAlgorithms
{
    public static class SelectionSort
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

        // Sorts an integer array using Selection Sort
        public static void Sort(int[] data)
        {
            // Loop through the array from the start
            for (int i = 0; i < data.Length - 1; i++)
            {
                // Set the index of the smallest value to the current index
                int smallestNumberIndex = i;

                // Loop through the remaining values in the array
                for (int j = i + 1; j < data.Length; j++)
                {
                    // If the current value is less than the smallest value
                    if (data[j] < data[smallestNumberIndex])
                        // Set the smallest number index to the current index
                        smallestNumberIndex = j;
                }

                // Check if the index of the smallest number changed after the inner loop
                if (smallestNumberIndex != i)
                    // Switch the current value with the smallest number
                    Exchange(data, i, smallestNumberIndex);
            }
        }
    }
}
