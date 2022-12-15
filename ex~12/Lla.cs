using static System.Console;
public static class Lla
{
    public static int InPut(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
/// <summary>
/// Создание массива.
/// </summary>
/// <param name="count"></param>
/// <returns></returns>
public static int[] CreatAr(int count)
{
    return new int[count];
}

/// <summary>
/// Заполнение масссива
/// </summary>
/// <param name="array"></param>
public static void Fill(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,15);
    }
}

/// <summary>
/// Печать массива
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
public static string Print(int[] array)
{
    return String.Join(' ', array);
}

/// <summary>
/// Возведение числа а, в степень b
/// </summary>
/// <param name="a"></param>
/// <param name="b"></param>
/// <returns></returns>
public static int Pow( int a, int b)
{
   int res = 1;
   for (int i = 0; i < b; i++)
   {
    res = res * a;
   }
   return res;
}
/// <summary>
/// число из 15-ой сисстемы в 10-ую
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
public static int Sum(int[] value)
{
    int result = 0;
    int c = value.Length;
    for (int i = 0; i < c; i++)
    {
        result += value[i] * Pow(15, c - 1 - i);
    }
    return i;
}
}