using static System.Console;
public static class Kla
{

/// <summary>
/// Ввод числа
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
public static int InPut( string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
/// <summary>
/// Создание массива
/// </summary>
/// <param name="count"></param>
/// <returns></returns>
public static int[] CreatAr( int count)
{
  return new int [count];
}

/// <summary>
/// Заполнение массива
/// </summary>
/// <param name="array"></param>
public static void Fiil(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,10000);
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
/// Счет чисел на нечетных ПОЗИЦИЯХ
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
public static int anQuan(int[] array)
{
    int result = 0;
    int c = array.Length;
    for (int i = 0; i < c; i++)
    {
        if (i % 2 == 1)
        {
            result += array[i];
        }
    }
    return result;
}

}