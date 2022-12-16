using static System.Console;
public static class Library

{
    // Ввод текста
    public static int Input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int MkAr(int a, int b)
    {
        int result = 0;
        if (b < 3)
        {
            Console.WriteLine("There isn't third digit.");
        }
        else
        {
            int c = 1;
            for (int i = b; i > 3; i--)
            {
                c = c * 10;
            }
            result = ( a / c ) % 10;
        }
        return result;
    }
}