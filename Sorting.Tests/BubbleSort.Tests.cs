using NUnit.Framework;

namespace Sorting.Tests
{
    public class Tests
    {
        [Test]
        public void Sort_Returns_Sorted_Array()
        {
            // Arrange
            int[] arr = { 5, 9, 1, 8, 6, 3, 7, 2, 4 };
            int[] sortedArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            BubbleSort.Sort(arr);

            // Assert
            Assert.AreEqual(arr, sortedArr);
        }
    }
}