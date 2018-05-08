using System;
using System.Collections.Generic;

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

        // Exchange the position of two values in an array
        private static void Exchange(Node nodeA, Node nodeB)
        {
            // Store the first value in a new temporary value
            int tempValue = nodeA.value;

            // Set the first value equal to the second value
            nodeA.value = nodeB.value;

            // Set the second value equal to the temporary value
            nodeB.value = tempValue;
        }

        // A private Node class
        private class Node
        {
            // Private Variables
            public int value;                                                 // Value stored at the node
            public int parentIndex;                                           // Parent node index
            public int leftChildIndex;                                        // Left child index
            public int rightChildIndex;                                       // Right child index

            // Constructor
            public Node(int value, int index)
            {
                // Initialise the variables
                this.value = value;
                this.parentIndex = (index % 2 == 0) ? (index - 2) / 2 : (index - 1) / 2;
                this.leftChildIndex = (index * 2) + 1;
                this.rightChildIndex = (index * 2) + 2;
            }
        }

        // A Heap class that contains 'Nodes' (similar to a tree)
        private class Heap
        {
            // Array of nodes
            private Node[] mNodes;

            // Empty constructor
            public Heap()
            {
                
            }

            // Initialise the heap with an array of integers
            public void Init(int[] data)
            {
                // Initialise the size of the array of nodes
                mNodes = new Node[data.Length];

                // Initialise the first node
                mNodes[0] = new Node(data[0], 0);

                // Loop through the heap starting at the first child node
                for (int i = 1; i < data.Length; i++)
                {
                    // Create a new node
                    mNodes[i] = new Node(data[i], i);

                    // Get the index of the parent
                    int parentIndex = mNodes[i].parentIndex;

                    // Loop up the heap until the largest number is at the top
                    for (int j = i; mNodes[parentIndex].value < mNodes[j].value;)
                    {
                        // Switch the two nodes
                        Exchange(mNodes[parentIndex], mNodes[j]);

                        // If we reached the top of the tree
                        if (parentIndex == 0)
                            break;

                        // Set the old parent node as the current node
                        j = parentIndex;

                        // Set the new parent node
                        parentIndex = mNodes[j].parentIndex;
                    }
                }
            }

            // Returns the sorted array
            public void Sort(int[] data)
            {
                // Length of the array
                int n = mNodes.Length;

                // Variable to hold our sorted array
                //int[] sortedData = new int[n];
                
                // Loop through the heap from the bottom
                for (int i = n - 1; i >= 0; i--)
                {
                    // Store the value at the top of the heap at the end of the sorted array
                    data[i] = mNodes[0].value;

                    // Store the current index of the heap at the top
                    Exchange(mNodes[i], mNodes[0]);

                    // Set the value of last node to 0
                    mNodes[i].value = 0;

                    // Set the largest child index
                    int largestChildIndex = mNodes[1].value > mNodes[2].value ? 1 : 2;

                    // Loop down the tree until the largest number is at the top
                    for (int j = 0; mNodes[largestChildIndex].value > mNodes[j].value; )
                    {
                        // Switch the two nodes
                        Exchange(mNodes[largestChildIndex], mNodes[j]);

                        // Set the old parent node as the current node
                        j = largestChildIndex;

                        // Set the new children index
                        int leftChildIndex = mNodes[j].leftChildIndex;
                        int rightChildIndex = mNodes[j].rightChildIndex;

                        // If the children are out of range, break out of the loop
                        if (rightChildIndex >= n || leftChildIndex >=n)
                            break;

                        // Set the largest child index
                        largestChildIndex = mNodes[leftChildIndex].value > mNodes[rightChildIndex].value ? leftChildIndex : rightChildIndex;
                    }
                }
            }
        }
    }
}
