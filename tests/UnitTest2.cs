namespace tests;
using Lab2CSharp;

public class UnitTest2
{
    //Test task2 with 1D array
    [Fact]
    public void Test1()
    {
        double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double expected = double.MinValue;
        double actual = Task2.GetMaxNegativeElement(array);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        double[] array = { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
        double expected = -1;
        double actual = Task2.GetMaxNegativeElement(array);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -10 };
        double expected = -10;
        double actual = Task2.GetMaxNegativeElement(array);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -12, -122, -8, -14, -15, -16, -17, -18, -19, -20 };
        double expected = -8;
        double actual = Task2.GetMaxNegativeElement(array);
        Assert.Equal(expected, actual);
    }
}