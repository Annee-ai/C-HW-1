using static System.Console;
public static class Library06
{
public static int InPut (string text)
    {
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    }

    public static int Function(int a)
    {
    if (a > 0 && a < 8)
        if (a == 6 || a == 7 )
        {
          Console.WriteLine("Weekend!");  
        }
        else
        {
            Console.WriteLine("WeekDay!");
        }
    else
    {
        Console.WriteLine("The day doesn't exist");
    }
        return (a);
    }

}