using static System.Console;
public static class Lib24
{

    public static int INPUT(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void Replica(int N)
    {
        if (N < 0)
        {
            Console.Write($"{N} - не натуральное число.");
            return;
        }
        if (N == 0)  return;
        Console.Write($"{N} ");
        Replica(N-1);
    }

}