namespace MyAlgorithms
{
    // A class for a Linear Search algorithm
    public static class LinearSearch
    {
        /// <summary>
        /// Performs a search on an integer array
        /// </summary>
        /// <param name="data"> Integer array to search through </param>
        /// <param name="number"> The number you are searching for </param>
        /// <returns> The index of the desired value or -1 if it was not found </returns>
        public static int Search(int[] data, int number)
        {
            // Loop through the array
            for (int i = 0; i < data.Length; i++)
            {
                // If the value matches the number in the array
                if (data[i] == number)
                    // The number is found, return the index
                    return i;
            }

            // The number was NOT found
            return -1;
        }
    }
}
