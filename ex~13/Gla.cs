using static System.Console;
public static class Gla
{
/// <summary>
/// Ввод кол-ва чисел в массиве
/// </summary>
/// <param name="text"></param>
/// <returns></returns>    
 public static int InPut(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
/// <summary>
/// Создание массива
/// </summary>
/// <param name="count"></param>
/// <returns></returns>
public static int[] CreatAR(int count)
{
    return new int [count];
}

/// <summary>
/// Заполнение массива
/// </summary>
/// <param name="array"></param>
public static void Fill(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = Random.Shared.Next(100,999);
    }
}

/// <summary>
/// печать массива
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
public static string Print(int[] array)
{
    return String.Join(' ', array);
}

/// <summary>
/// Кол-во чётных чисел массива
/// </summary>
/// <param name="value"></param>
/// <returns></returns>
public static int Quan(int[] value)
{
    int result = 0;
    int c = value.Length;
    for (int i = 0; i < c; i++)
    { 
         if (value [i] % 2 == 0)
     {
        result = result + 1;
     }
    }
 return result;
} 
    
}
