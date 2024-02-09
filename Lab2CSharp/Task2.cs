namespace Lab2CSharp;

public class Task2
{
    /*
    При вирішенні завдання використовувати одновимірний масив. 
    Знайти максимум з від’ємних елементів.
    */
    public static double GetMaxNegativeElement(double[] array)
    {
        double max = double.MinValue;
        foreach (var element in array)
        {
            if (element < 0 && element > max)
            {
                max = element;
            }
        }
        return max;
    }
}