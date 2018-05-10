using System;

namespace MyAlgorithms
{
    public static class MergeSort
    {
        // Splits the array into blocks of 1 and returns a sorted merged block
        public static int[] Sort(int[] data)
        {
            // If the array is only 1 variable in size
            if (data.Length == 1)
                // return the array
                return data;

            // Calculate the midpoint index
            int midIndex = (data.Length) / 2;

            // Create a new array for the left block
            int[] leftBlock = new int[midIndex];
            // Fill the left block
            Array.Copy(data, 0, leftBlock, 0, leftBlock.Length);

            // Create a new array for the right block
            int[] rightBlock = new int[data.Length - leftBlock.Length];
            // Fill the right block
            Array.Copy(data, midIndex, rightBlock, 0, rightBlock.Length);

            // Recursion to break down the blocks
            leftBlock = Sort(leftBlock);
            rightBlock = Sort(rightBlock);

            // Merge the blocks
            return Merge(leftBlock, rightBlock);
        }

        // Merges two integer arrays into a sorted array
        private static int[] Merge(int[] leftBlock, int[] rightBlock)
        {
            // Holds the merged array
            int[] merged = new int[leftBlock.Length + rightBlock.Length];

            // Loop through the two arrays
            for (int i = 0, j = 0, k = 0; i < leftBlock.Length || j < rightBlock.Length; )
            {
                // If there are still numbers to check in both blocks
                if (i < leftBlock.Length && j < rightBlock.Length)
                {
                    // If the value in the left block is smaller
                    if (leftBlock[i] <= rightBlock[j])
                        // Add the value to the merged array
                        merged[k++] = leftBlock[i++];
                    else // The right block value is smaller
                         // Add the value to the merged array
                        merged[k++] = rightBlock[j++];
                }
                // Else if there are still numbers in the left block
                else if (i < leftBlock.Length)
                    // Add the value to the merged array
                    merged[k++] = leftBlock[i++];
                else // There are still number in the right block
                    // Add the value to the merged array
                    merged[k++] = rightBlock[j++];
            }

            return merged;
        }
    }
}
