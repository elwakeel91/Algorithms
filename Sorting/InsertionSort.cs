namespace MyAlgorithms
{
    public static class InsertionSort
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

        // Sorts an array of integers using insertion sort
        public static void Sort(int[] data)
        {
            // Loop through all the values in the array from the start
            for (int i = 1; i < data.Length; i++)
            {
                // Loop back from index i while the previous value is bigger
                for (int j = i; j > 0 && data[j] < data[j - 1]; j--)
                    Exchange(data, j, j - 1);
            }
        }
    }
}
