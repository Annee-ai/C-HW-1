using static System.Console;
public static class Library21
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

    /// <summary>
    /// Сортировка значений строки  массива
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public static async void RegulateArray(int[,] A)
    {
        int c = A.GetLength(0);
        int d = A.GetLength(1);
        int s = 1;
        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < d; j++)
            {
                for (int k = 0; k < d-1; k++)
                {
                    if (A[i,k] <A[i, k+1])
                {
                    s = A[i,k];
                    A[i,k] = A [i,k+1];
                    A[i,k+1] = s;
                }
                }
            }
        }
    }
}