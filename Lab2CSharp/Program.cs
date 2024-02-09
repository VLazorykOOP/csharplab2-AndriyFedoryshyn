
namespace Lab2CSharp;

internal class Program
{
    public static double[] GetArrayFromUser(int n)
    {
        double[] array = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter {i + 1} element: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        return array;
    }
    //get 2d array from user
    public static double[,] Get2DArrayFromUser(int n, int m)
    {
        double[,] array = new double[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Enter {i + 1}x{j + 1} element: ");
                array[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        return array;
    }
    //get jagged array from user
    static double[][] GetJaggedArrayFromUser(int n)
    {
        double[][] jaggedArray = new double[n][];
        int k=0;
        for (int i = 0; i < n; i++)
        {
            k++;
            for(int j = 0; j < k; j++)
            {
                Console.Write($"Enter {i + 1}x{j + 1} element: ");
                jaggedArray[i][j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        return jaggedArray;
    }
    //print array
    public static void PrintArray(double[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
    //print 2d array
    public static void Print2DArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Lab 2 CSharp");
        Console.WriteLine("Select task to do: ");
        Console.WriteLine("1. Task 1");
        Console.WriteLine("2. Task 2");
        Console.WriteLine("3. Task 3");
        Console.WriteLine("4. Task 4");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("Task 1");
                Console.WriteLine("Select array type: ");
                Console.WriteLine("1. 1D array");
                Console.WriteLine("2. 2D array");
                int arrayType = Convert.ToInt32(Console.ReadLine());
                if (arrayType == 1)
                {
                    Console.Write("Enter array size: ");
                    int len = Convert.ToInt32(Console.ReadLine());
                    double[] array = GetArrayFromUser(len);
                    Task1.GetOddElements(array);
                    Console.WriteLine("Odd elements: ");
                    PrintArray(Task1.GetOddElements(array));
                }
                else if (arrayType == 2)
                {
                    Console.Write("Enter array size n: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter array size m: ");
                    int col = Convert.ToInt32(Console.ReadLine());
                    double[,] array = Get2DArrayFromUser(row, col);
                    Task1.GetOddElements(array);
                    Console.WriteLine("Odd elements: ");
                    PrintArray(Task1.GetOddElements(array));
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                break;
            case 2:
                Console.WriteLine("Task 2");
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                double[] array2 = GetArrayFromUser(size);
                Console.WriteLine("Max negative element: ");
                Console.WriteLine(Task2.GetMaxNegativeElement(array2));
                break;
            case 3:
                Console.WriteLine("Task 3");
                //2d array
                Console.Write("Enter rows count: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter columns count: ");
                int cols = Convert.ToInt32(Console.ReadLine());
                double[,] array3 = Get2DArrayFromUser(rows, cols);
                Console.WriteLine("Array: ");
                Print2DArray(array3);
                Console.WriteLine("Elements in order: ");
                PrintArray(Task3.GetElementsInOrder(array3));
                break;
            case 4:
                Console.WriteLine("Input number of rows in jagged array:");
                int n = Convert.ToInt32(Console.ReadLine());
                double[][] jaggedArray = GetJaggedArrayFromUser(n);
                double[] rowSums = Task4.CalculateRowSums(jaggedArray);
                Console.WriteLine("Sum of elem of each row:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Row {i + 1}: {rowSums[i]}");
                }
                double maxSum = Task4.FindMax(rowSums);

                Console.WriteLine($"Max sum of elem of row: {maxSum}");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

    }
}

