namespace tests;
using Lab2CSharp;

public class UnitTest3
{
    [Fact]
    public void Test1()
    {
        double[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[] expected = { 1, 2, 3, 6, 5, 4, 7, 8, 9 };
        double[] actual = Task3.GetElementsInOrder(array);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        double[,] array = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
        double[] expected = { 1, 2, 3, 4, 8, 7, 6, 5 };
        double[] actual = Task3.GetElementsInOrder(array);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        double[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
        double[] expected = { 1, 2, 3, 6, 5, 4, 7, 8, 9, 12, 11, 10, 13, 14, 15 };
        double[] actual = Task3.GetElementsInOrder(array);
        Assert.Equal(expected, actual);
    }
}