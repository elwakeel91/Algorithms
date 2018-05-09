using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyAlgorithms.UnitTest
{
    [TestClass]
    public class SearchingAlgorithmsUnitTests
    {
        [TestMethod]
        public void LinearSearch_NumberFound_Two()
        {
            // Arrange
            int[] data = new int[] { 1, 2, 3, 4, 5 };
            int searchNumber = 3;
            int result = 0;
            int expectedResult = 2;

            // Act
            result = LinearSearch.Search(data, searchNumber);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void LinearSearch_NumberNotFound_MinusOne()
        {
            // Arrange
            int[] data = new int[] { 1, 2, 3, 4, 5 };
            int searchNumber = 10;
            int result = 0;
            int expectedResult = -1;

            // Act
            result = LinearSearch.Search(data, searchNumber);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void BinarySearch_NumberFound_Three()
        {
            // Arrange
            int[] data = new int[] { 1, 2, 3, 4, 5 };
            int searchNumber = 4;
            int result = 0;
            int expectedResult = 3;

            // Act
            result = BinarySearch.Search(data, searchNumber);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void BinarySearch_NumberNotFound_MinusOne()
        {
            // Arrange
            int[] data = new int[] { 1, 2, 3, 4, 5 };
            int searchNumber = 10;
            int result = 0;
            int expectedResult = -1;

            // Act
            result = BinarySearch.Search(data, searchNumber);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
