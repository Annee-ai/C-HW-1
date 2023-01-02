using static System.Console;
public static class Library23
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
    public static void FillArray (int[,,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int k = 0; k < A.GetLength(2); k++)
                {
                    A[i,j,k] = new Random().Next(-100, 100);
                }
               
            }
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Печчать двумерного массива
    /// </summary>
    /// <param name="A">двумерный массив</param>
    public static void PrintArray(int[,,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int k = 0; k < A.GetLength(2); k++)
                {
                    Console.Write($"{A[i, j, k]}({i},{j},{k})\t");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

}