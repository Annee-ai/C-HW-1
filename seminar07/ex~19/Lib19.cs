using static System.Console;
public static class Lib19
{

    public static int InPut( string text )
    {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
    }
    public static void Main (int[,] A)
    {
        // полный вариант в Library16
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
            {
            Console.Write($"Введите элемент массива под инденксом {i},{j} -");
            A[i,j] = int.Parse(Console.ReadLine());
            }
                
        Console.WriteLine("Вывод массива: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i,j]}\t");
            }
         Console.WriteLine();
        }
     } 

    public static void From (int[,] A)
    {
        Console.Write($"Введите инденкс i- ");
        int i = int.Parse(Console.ReadLine());
        Console.Write($"Введите инденкс j- ");
        int j = int.Parse(Console.ReadLine());
        if (i < 0 | A.GetLength(0) < i && j < 0| A.GetLength(1)< j)
        {
            Console.WriteLine($"{A[i,j]} --> такого числа нет");
        }
        else
        {
            Console.WriteLine(A[i,j]);
        }
    }
}