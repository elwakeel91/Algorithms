namespace MyAlgorithms
{
    public static class HeapSort
    {
        // Return a sorted integer array using Heap Sort
        public static void Sort(int[] data)
        {
            Heap heap = new Heap();
            heap.Init(data);
            heap.Sort(data);
        }

        // A Heap class that contains 'Nodes' (similar to a tree)
        private class Heap
        {
            // Array of nodes
            private int[] mNodes;

            // Empty constructor
            public Heap()
            {

            }

            // Initialise the heap with an array of integers
            public void Init(int[] data)
            {
                // Initialise the size of the array of nodes
                mNodes = new int[data.Length];

                // Initialise the first node
                mNodes[0] = data[0];

                // Loop through the heap starting at the first child node
                for (int i = 1; i < data.Length; i++)
                {
                    // Create a new node
                    mNodes[i] = data[i];

                    // Get the index of the parent
                    int parentIndex = GetParent(i);

                    // Loop up the heap until the largest number is at the top
                    for (int j = i; mNodes[parentIndex] < mNodes[j];)
                    {
                        // Switch the two nodes
                        Exchange(mNodes, parentIndex, j);

                        // If we reached the top of the tree
                        if (parentIndex == 0)
                            break;

                        // Set the old parent node as the current node
                        j = parentIndex;

                        // Set the new parent node
                        parentIndex = GetParent(j);
                    }
                }
            }

            // Returns the sorted array
            public void Sort(int[] data)
            {
                // Length of the array
                int n = data.Length;

                // Loop through the nodes from the bottom
                for (int i = n - 1; i >= 0; i--)
                {
                    // Store the value at the top of the heap onto the end of the sorted array
                    data[i] = mNodes[0];

                    // Copy the current node onto the top
                    Exchange(mNodes, i, 0);

                    // Set the value of the current node to zero so we don't use it again
                    mNodes[i] = 0;

                    // Get the the index of the largest child at the top of the heap
                    int largestChildIndex = mNodes[1] > mNodes[2] ? 1 : 2;

                    // Loop down the heap only if the child is larger than the parent and bubble the parent down
                    for (int j = 0; mNodes[largestChildIndex] > mNodes[j];)
                    {
                        // Switch the two nodes
                        Exchange(mNodes, largestChildIndex, j);

                        // Set the old parent node as the current node
                        j = largestChildIndex;

                        // Set the new children indicies
                        int leftChildIndex = (j * 2) + 1;
                        int rightChildIndex = (j * 2) + 2;

                        // If both children are out of range, break out of the loop
                        if (rightChildIndex >= n && leftChildIndex >= n)
                            break;

                        // Else if only the left child is out of range
                        else if (rightChildIndex < n && leftChildIndex >= n)
                            // Choose the right child as the new largest child
                            largestChildIndex = rightChildIndex;

                        // Else if only the right child is out of range
                        else if (rightChildIndex >= n && leftChildIndex < n)
                            // Choose the left child as the new largest child
                            largestChildIndex = leftChildIndex;

                        else // Find the new largest child
                            largestChildIndex = mNodes[leftChildIndex] > mNodes[rightChildIndex] ? leftChildIndex : rightChildIndex;
                    }
                }
            }

            // Get the parent index of a node
            private static int GetParent(int index)
            {
                return (index % 2 == 0) ? (index - 2) / 2 : (index - 1) / 2;
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
}
