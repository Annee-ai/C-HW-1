using static System.Console;
public static class Libary22
{
     public static int InPut( string text )
    {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
    }

    /// <summary>
    /// Заполнение двумерного массива
    /// </summary>
    /// <param name="A">двумерный массив</param>
    public static void FillArray (int[,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
               A[i,j] = new Random().Next(-10, 10);
            }
        }
        Console.WriteLine();
    }
    
    /// <summary>
    /// Печчать двумерного массива
    /// </summary>
    /// <param name="A">двумерный массив</param>
    public static void PrintArray(int[,] A)
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

    public static void SumStroki(int[,] A)
    {
        int sum = 0;
        int s = 12500;
        int tem = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                sum += A[i, j];
            }
            if (sum < s)
            {
                s = sum;
                tem += 1;
            }
        }
            Console.WriteLine("Строка с наименьшей суммой элементов:");
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[tem, j]}\t");
            }
    }
}