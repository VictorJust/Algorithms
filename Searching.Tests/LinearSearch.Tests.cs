namespace LinearSearch.Tests;

using NUnit.Framework;
using Searching;

public class Tests
{
    [Test]
    public void Search_ReturnsCorrectIndex()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };
        int value = 3;

        // Act
        int index = LinearSearch.Search(arr, value);

        // Assert
        Assert.AreEqual(2, index);
    }

    [Test]
    public void Search_ReturnsNegativeOneIfNotFound()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };
        int value = 6;

        // Act
        int index = LinearSearch.Search(arr, value);

        // Assert
        Assert.AreEqual(-1, index);
    }
}
