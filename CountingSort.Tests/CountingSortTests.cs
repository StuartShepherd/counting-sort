namespace CountingSort.Tests;

[TestClass]
public class CountingSortTests
{
    [TestMethod]
    [DataRow(new int[] { 73, 57, 49, 99, 133, 20, 1 }, new int[] { 1, 20, 49, 57, 73, 99, 133 })]
    public void Sorts_Array_ReturnsSortedArray(int[] x, int[] expected)
    {
        var countingSort = new CountingSort();
        var actual = countingSort.Sort(x);

        Assert.IsNotNull(actual);
        CollectionAssert.AreEqual(actual, expected);
    }
}
