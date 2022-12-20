using static System.Console;
public static class Library16
{
    /// <summary>
    /// Ввод числа
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static int InPut( string text )
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Создание массива
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public static int[] CreatAr(int count)
    {
        return new int [count];
    }

    /// <summary>
    /// Ввод данных массива с консоли
    /// </summary>
    /// <param name="A"></param>
    public static void Main (int[] A)
    {
        // Console.Write("Введите кол-во элементов массива: ");
        // int n = int.Parse(Console.ReadLine());
        // int[] A = new int[n];
        for (int i = 0; i < A.Length; i++)
        {
            //Console.Write($"Введите элемент массива под инденксом {i} -");
            A[i] = int.Parse(Console.ReadLine());
        }
        // Console.Write("Вывод массива: ");
        // for (int i = 0; i < A.Length; i++)
        // {
        //     Console.Write(A[i]+" ");
        // }
        //Console.ReadLine();
    } 
    
    /// <summary>
    /// Количество положительных чисел массива 
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public static int MrZero (int[] A)
    {
        int result = 0;
        for (int i = 0; i < A.Length; i++)
        {
           if (A[i] > 0)
           {
            result ++;
           } 
        }
        return result;
    }
}