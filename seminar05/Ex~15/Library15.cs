using static System.Console;

public static class Library15
{
    public static int InPut( string text )
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int[] CreatAr( int count)
    {
        return new int [count];
    }

    public static void Fill(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(-1200, 1500);
        }

    }

    public static string PrintAr(int[] array)
    {
        return string.Join(' ', array);
    }

    public static int Max(int[] array)
    {
         int max = 0;
         int c = array.Length;
         for (int i = 0; i < c; i++)
         {
            if (max < array[i])
            {
                max = array[i];
            }
         }
         return max;
    }
    public static int Min(int[] array)
    {
         int min = array[0];
         int c = array.Length;
         for (int i = 0; i < c; i++)
         {
            if (min > array[i])
            {
                min = array[i];
            }
         }
         return min;
    }

    public static int Sub(int a, int b)
    {
       int result = a - b;
       return result;
    }
}