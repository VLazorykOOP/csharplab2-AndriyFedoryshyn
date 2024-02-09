namespace Lab2CSharp;

public class Task4
{
    /*
    Дано східчастий масив з n рядків, у рядках по mj (j=1..n) елементів.
    Підрахувати суму елементів кожного рядка і записати дані в
    новий масив. Знайти максимальний елемент нового масиву.
    */
    

    public static double[] CalculateRowSums(double[][] jaggedArray)
    {
        double[] rowSums = new double[jaggedArray.Length];

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            double sum = 0;

            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                sum += jaggedArray[i][j];
            }

            rowSums[i] = sum;
        }

        return rowSums;
    }

    public static double FindMax(double[] array)
    {
        double max = array[0];

        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
