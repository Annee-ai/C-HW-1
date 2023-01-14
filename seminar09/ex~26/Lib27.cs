using static System.Console;
public static class Lib27
{

    public static int INPUT(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }


    public static int Akker (int m, int n)
    {
        if ( m == 0)
        {
            return n + 1;
        }
        if (m > 0 && n == 0)
        {
            return Akker(m - 1, 1);
        }
        if (m > 0 && n > 0)
        {
            return Akker(m-1, Akker(m, n-1));
        }
        return 1;
    }
}