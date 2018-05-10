namespace MyAlgorithms
{
    // A class for a Binary Search algorithm
    public static class BinarySearch
    {
        /// <summary>
        /// Performs a search on a sorted integer array
        /// </summary>
        /// <param name="data"> Data to search through </param>
        /// <param name="number"> The number you are searching for </param>
        /// <returns> The index of the desired number or -1 if it was not found </returns>
        public static int Search(int[] data, int number)
        {
            // Initialise the minimum and maximum indicies
            int minIndex = 0;
            int maxIndex = data.Length - 1;
            int midIndex = 0;

            // If the maximum and minimum indicies are not equal
            while (maxIndex >= minIndex)
            {
                // Check the number in the middle of the array
                midIndex = ((maxIndex - minIndex) / 2) + minIndex;

                // If it's the number we're looking for
                if (data[midIndex] == number)
                    // return the index
                    return midIndex;

                // If the number we're looking for is smaller than the halfway number
                if (data[midIndex] > number)
                    // Adjust the value of the maximum index
                    maxIndex = midIndex - 1;
                else // The number is smaller
                    // Adjust the value of the minimum index
                    minIndex = midIndex + 1;
            }

            // The integer was not found
            return -1;
        }
    }
}
