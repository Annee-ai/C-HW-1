using static System.Console;
public static class Bla
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

/// <summary>
/// Сумма цифр числа (+ отделение их друг от друга)
/// </summary>
/// <param name="A"></param>
/// <returns></returns>
public static int Drob(int A)
{
    int rev = 0;
    int D;
    while (A != 0)
    {
       D = A % 10;
       rev += D;
       A = A / 10; 
    }
    return rev;
}

}