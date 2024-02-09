namespace tests;
using Lab2CSharp;

public class UnitTest1
{
    //Test task1 with 1D array
    [Fact]
    public void Test1()
    {
        double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] expected = { 1, 3, 5, 7, 9 };
        double[] actual = Task1.GetOddElements(array);
        Assert.Equal(expected, actual);
    }

    //test with 0 elements
    [Fact]
    public void Test2()
    {
        double[] array = { };
        double[] expected = { };
        double[] actual = Task1.GetOddElements(array);
        Assert.Equal(expected, actual);
    }

    //test with 1 element
    [Fact]
    public void Test3()
    {
        double[] array = { 1 };
        double[] expected = { 1 };
        double[] actual = Task1.GetOddElements(array);
        Assert.Equal(expected, actual);
    }
    //Test task1 with 2D array
    [Fact]
    public void Test4()
    {
        double[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[] expected = { 1, 3, 5, 7, 9 };
        double[] actual = Task1.GetOddElements(array);
        Assert.Equal(expected, actual);
    }
    //test with 0 elements
    [Fact]
    public void Test5()
    {
        double[,] array = { };
        double[] expected = { };
        double[] actual = Task1.GetOddElements(array);
        Assert.Equal(expected, actual);
    }
    //test with 1 element
    [Fact]
    public void Test6()
    {
        double[,] array = { { 1 } };
        double[] expected = { 1 };
        double[] actual = Task1.GetOddElements(array);
        Assert.Equal(expected, actual);
    }
}