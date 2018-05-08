using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgorithms
{
    public static class MergeSort
    {
        public static int[] Sort(int[] data)
        {
            // If the array is only 1 variable in size
            if (data.Length == 1)
                // return the array
                return data;

            // Calculate the midpoint index
            int midIndex = (data.Length - 1) / 2;

            // Create a new array for the left block
            int[] leftBlock = new int[midIndex + 1];
            // Fill the left block
            Array.Copy(data, 0, leftBlock, 0, leftBlock.Length);

            // Create a new array for the right block
            int[] rightBlock = new int[data.Length - leftBlock.Length];
            // Fill the right block
            Array.Copy(data, (midIndex + 1), rightBlock, 0, rightBlock.Length);

            // Recursion to break down the blocks
            leftBlock = Sort(leftBlock);
            rightBlock = Sort(rightBlock);

            // Merge the blocks
            Merge(leftBlock, rightBlock);
        }

        private static void Merge(int[] leftBlock, int[] rightBlock)
        {

        }
    }
}
