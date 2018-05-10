using System;

namespace MyAlgorithms
{
    public static class JumpSearch
    {
        /// <summary>
        /// Performs a search on a sorted integer array
        /// </summary>
        /// <param name="data"> Data to search through </param>
        /// <param name="number"> The number you are searching for </param>
        /// <returns> The index of the desired number or -1 if it was not found </returns>
        public static int Search(int[] data, int number)
        {
            // Calculate the jump size
            int jump = (int)Math.Floor(Math.Sqrt(data.Length));

            // Variable holding the previous jump index
            int prevJump = 0;

            // Jump through the data
            for (int i = 0; i < data.Length; i += jump)
            {
                // If the current number is bigger than the number we are searching for
                if (data[i] >= number)
                {
                    // Stop jumping and perform a linear search backwards to our previous jump
                    for (int j = i; j >= prevJump; j--)
                    {
                        // If we found the number
                        if (data[j] == number)
                            // Return the index
                            return j;
                    }

                    // We didn't find the number in our linear search so it's not in the array
                    break;
                }

                // Adjust the previous jump index
                prevJump = i;
            }

            // We didn't find the number, so we return -1
            return -1;
        }
    }
}
