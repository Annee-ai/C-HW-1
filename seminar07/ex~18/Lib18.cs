using static System.Console;
public static  class Lib18
{
    public static int InPut( string text )
    {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
    }

/// <summary>
/// Печать двумерного массива
/// </summary>
/// <param name="A"></param>
public static void PrintA (double[,] A)
{
     for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i,j]}\t");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Рандомное заполнение двумерного массива ВЕЩЕСТВЕННЫМИ числами
/// </summary>
/// <param name="A"></param>
public static void Fill(double[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
    Console.WriteLine();
}
}