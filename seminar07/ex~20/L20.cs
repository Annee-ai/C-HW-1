using static System.Console;
public static class L20
{

    public static int InPut( string text )
    {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
    }
    /// <summary>
    /// Заполнение двумерного массива
    /// </summary>
    /// <param name="A"></param>
    public static void Fill(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i,j] = new Random().Next(0, 1500);
        }
    }
    Console.WriteLine();
}
    
     /// <summary>
     /// Печать двумерного массива
     /// </summary>
     /// <param name="A">двумерный массив</param>
     public static void PrintA (int[,] A)
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
     public static void Arf (int[,] A, int m)
     {
        int c = A.GetLength(0);
        int s = A.GetLength(1);
        for (int j = 0; j < s; j++)
        {
            double sum = 0;
            for (int i = 0; i < c; i++)
            {
                sum = sum + A[i,j];
            }
            Console.Write($"Среднее арифметическое столбца {j} = {sum / m}.");
            Console.WriteLine();
           
        }
        
     }
}