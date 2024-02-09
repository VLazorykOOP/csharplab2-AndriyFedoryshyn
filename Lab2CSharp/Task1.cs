namespace Lab2CSharp;

public class Task1
{
    /*
    Завдання з масивами вирішити двома способами,
    використовуючи одновимірний масив, а потім двовимірний. Розмірність
    масиву вводиться з клавіатури.
    Task1. Вивести на екран номери всіх непарних елементів. 
     */

    public static double[] GetOddElements(double[] array)
    {
        List<double> oddElements = new List<double>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                oddElements.Add(array[i]);
            }
        }
        return oddElements.ToArray();
    }

    //get odd elements from 2d array
    public static double[] GetOddElements(double[,] array)
    {
        List<double> oddElements = new List<double>();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] % 2 != 0)
                {
                    oddElements.Add(array[i, j]);
                }
            }
        }
        return oddElements.ToArray();
    }

}

