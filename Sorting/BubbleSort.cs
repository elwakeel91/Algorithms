namespace MyAlgorithms
{
    public static class BubbleSort
    {
        // Sorts an integer array using Bubble Sort
        public static void Sort(int[] data)
        {
            // Loop through the array from the start
            for (int j = 0; j < data.Length - 1; j++)
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
    }
}
