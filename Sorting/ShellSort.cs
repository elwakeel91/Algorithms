namespace MyAlgorithms
{
    public static class ShellSort
    {
        // Sort an integer array using Shell Sort
        public static void Sort(int[] data)
        {
            // Start with a gap size of n / 2 and half the gap every iteration
            for (int gap = data.Length / 2; gap > 0; gap /= 2)
            {
                // Loop through the data starting at the gap size and increment by one
                for (int i = gap; i < data.Length; i++)
                {
                    // Loop to keep shifting the value to the left while it's smaller than the comparison value
                    for (int k = i, j = i - gap; j >= 0 && data[k] < data[j]; k = j, j -= gap)
                    {
                        // Exchange their positions
                        Exchange(data, k, j);
                    }
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
