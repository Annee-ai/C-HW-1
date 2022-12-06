using static System.Console;
public static class Library06
{
public static int InPut (string text)
    {
    Console.WriteLine(text);
    return Convert.ToUInt32(Console.ReadLine());
    }

    public static int Function(int a)
    {
        if (a< 1 || a > 7 )
        {
          Console.WriteLine("The day doesn't exist");  
        }
        else if (1 <= a <= 5 )
        {
            
        }
        
    }
}