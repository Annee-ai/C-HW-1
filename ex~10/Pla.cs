using static System.Console;

/// <summary>
/// Моя вторая Библиотека!
/// </summary>
public static class Pla
{
/// <summary>
/// Ввод числа, очередная репетиция!
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
public static int InPut(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

public static int Pow( int a, int b)
{
   int res = a;
   for (int i = 0; i < b; i++)
   {
    res *= a;
   }
   return res;
}
}