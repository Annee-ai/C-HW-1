using static System.Console;
/// <summary>
/// Библиотека к заданию про палиндром.
/// </summary>;
public static class Library07
{
/// <summary>
/// Ввод числа в программу
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
public static int InPut (string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int Pal (int a)
    {
        int rev = 0;
        int digit;
        while (a != 0)
        {
            digit = a % 10;
            rev =  (rev * 10) + digit;
            a = a / 10;
        }
        return rev;
    }
}