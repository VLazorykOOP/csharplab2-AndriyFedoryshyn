namespace Lab2CSharp;

public class Task3
{
    /*
      При вирішенні завдання використовувати двовимірний масив.
      Вивести елементи матриці в наступному порядку: починаючи з 1 елемента першого рядка, до кінця, потім останній елемент другого рядка, до почтаку, 
      потім перший елемент третього рядка і до кінця і так далі.
      */
    public static double[] GetElementsInOrder(double[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        double[] resultArray = new double[rowCount * colCount];
        int index = 0;

        for (int i = 0; i < rowCount; i++)
        {
            if (i % 2 == 0) // Непарні рядки
            {
                for (int j = 0; j < colCount; j++)
                {
                    resultArray[index++] = matrix[i, j];
                }
            }
            else // Парні рядки
            {
                for (int j = colCount - 1; j >= 0; j--)
                {
                    resultArray[index++] = matrix[i, j];
                }
            }
        }
        return resultArray;
    }
}