namespace tests;
using Lab2CSharp;

public class UnitTest4
{
    [Fact]
    public void Test1()
    {
        double[][] array = new double[4][];
        array[0] = new double[] { 1};
        array[1] = new double[] { 2, 3 };
        array[2] = new double[] { 4, 5, 6 };
        array[3] = new double[] { 7, 8, 9, 10 };
        double[] expected = { 1, 5, 15, 34 };
        double[] actual = Task4.CalculateRowSums(array);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        double[][] array = new double[4][];
        array[0] = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array[1] = new double[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array[2] = new double[] { 4, 5, 6, 7, 8, 9, 10 };
        array[3] = new double[] { 7, 8, 9, 10 };
        double[] expected = { 55, 54, 49, 34 };
        double[] actual = Task4.CalculateRowSums(array);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        double[][] array = new double[4][];
        array[0] = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array[1] = new double[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array[2] = new double[] { 4, 5, 6, 7, 8, 9, 10 };
        array[3] = new double[] { 7, 8, 9, 10 };
        double expected = 55;
        double actual = Task4.FindMax(Task4.CalculateRowSums(array));
        Assert.Equal(expected, actual);
    }

    [Fact]
     public void Test4()
    {
        double[][] array = new double[4][];
        array[0] = new double[] { 1};
        array[1] = new double[] { 2, 3 };
        array[2] = new double[] { 4, 5, 6 };
        array[3] = new double[] { 7, 8, 9, 10 };
        double expected = 34 ;
        double actual = Task4.FindMax(Task4.CalculateRowSums(array));
        Assert.Equal(expected, actual);
    }
    
}