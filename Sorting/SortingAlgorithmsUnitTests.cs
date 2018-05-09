using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyAlgorithms.UnitTest
{
    [TestClass]
    public class SortingAlgorithmsUnitTests
    {
        [TestMethod]
        public void BubbleSort_GivenUnsortedArray_SortedArray()
        {
            // Arrange
            int[] data = new int[] { 2, 4, 3, 1 };
            int[] expectedResult = new int[] { 1, 2, 3, 4 };

            // Act
            BubbleSort.Sort(data);

            // Assert
            CollectionAssert.AreEqual(data, expectedResult);
        }

        [TestMethod]
        public void SelectionSort_GivenUnsortedArray_SortedArray()
        {
            // Arrange
            int[] data = new int[] { 2, 5, 1, 6 };
            int[] expectedResult = new int[] { 1, 2, 5, 6 };

            // Act
            SelectionSort.Sort(data);

            // Assert
            CollectionAssert.AreEqual(data, expectedResult);
        }

        [TestMethod]
        public void InsertionSort_GivenUnsortedArray_SortedArray()
        {
            // Arrange
            int[] data = new int[] { 20, 50, 10, 60 };
            int[] expectedResult = new int[] { 10, 20, 50, 60 };

            // Act
            InsertionSort.Sort(data);

            // Assert
            CollectionAssert.AreEqual(data, expectedResult);
        }

        [TestMethod]
        public void HeapSort_GivenUnsortedArray_SortedArray()
        {
            // Arrange
            int[] data = new int[] { 20, 10, 30, 40 };
            int[] expectedResult = new int[] { 10, 20, 30, 40 };

            // Act
            HeapSort.Sort(data);

            // Assert
            CollectionAssert.AreEqual(data, expectedResult);
        }

        [TestMethod]
        public void MergeSort_GivenUnsortedArray_SortedArray()
        {
            // Arrange
            int[] data = new int[] { 20, 10, 30, 40 };
            int[] expectedResult = new int[] { 10, 20, 30, 40 };

            // Act
            data = MergeSort.Sort(data);

            // Assert
            CollectionAssert.AreEqual(data, expectedResult);
        }
    }
}
