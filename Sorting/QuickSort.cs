namespace MyAlgorithms
{
    public static class QuickSort
    {
        // Sorts an integer array using Quick Sort
        public static void Sort(int[] data, int firstIndex, int lastIndex)
        {
            // If there is more than one value to sort
            if (firstIndex < lastIndex)
            {
                // Place the pivot in the correct position
                int pivotIndex = PivotIndex(data, firstIndex, lastIndex);

                // Perform quick sort on the left of the pivot
                Sort(data, firstIndex, pivotIndex - 1);
                // Perform quick sort on the right of the pivot
                Sort(data, pivotIndex + 1, lastIndex);
            }
        }

        // Places the pivot in the correct position and returns it's new index
        private static int PivotIndex(int[] data, int firstIndex, int lastIndex)
        {
            // Set the pivot value
            int pivot = data[lastIndex];

            // Initialise the index of the last number in the array we sorted
            int sortedIndex = firstIndex - 1;

            // Loop through the array and keep track of the index of the numbers smaller than the pivot value
            for (int i = firstIndex; i < lastIndex; i++)
            {
                // If the current number is smaller than the pivot
                if (data[i] <= pivot)
                {
                    // Move the current vale to the smaller number index
                    Exchange(data, ++sortedIndex, i);
                }
            }

            // Move the pivot to the correct position
            Exchange(data, lastIndex, ++sortedIndex);

            // Return the new pivot index
            return sortedIndex;
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
