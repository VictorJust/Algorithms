using NUnit.Framework;

namespace Sorting.Tests
{
    public class BubbleSortTests
    {
        [Test]
        public void BubbleSort_Returns_Sorted_Array()
        {
            // Arrange
            int[] arr = { 5, 9, 1, 8, 6, 3, 7, 2, 4 };
            int[] sortedArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            BubbleSort.Sort(arr);

            // Assert
            Assert.AreEqual(arr, sortedArr);
        }

        [Test]
        public void BubbleSort_SortArrayWithDuplicateElements()
        {
            // Arrange
            int[] array = { 4, 2, 7, 2, 1, 4, 6, 7 };
            int[] expected = { 1, 2, 2, 4, 4, 6, 7, 7 };

            // Act
            QuickSort.Sort(array, 0, array.Length - 1);

            // Assert
            Assert.AreEqual(expected, array);
        }

        [Test]
        public void BubbleSort_SortArrayWithNegativeElements()
        {
            // Arrange
            int[] array = { -3, -7, 2, -1, 5, 0, -4 };
            int[] expected = { -7, -4, -3, -1, 0, 2, 5 };

            // Act
            QuickSort.Sort(array, 0, array.Length - 1);

            // Assert
            Assert.AreEqual(expected, array);
        }
    }
}