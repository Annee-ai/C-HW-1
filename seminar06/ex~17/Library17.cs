using static System.Console;
public static class Library17
{
    public static void AllInPut()
    {
        Console.Write("Введите значение b1 - ");
        double b1 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение k1 - ");
        double k1 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b2 - ");
        double b2 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение k2 - ");
        int k2 = int.Parse(Console.ReadLine());
        Console.Write($"x = {(b2-b1)/(k1-k2)};");
        Console.WriteLine();
        Console.Write($"y = {k1*(b2-b1)/(k1-k2)+b1};");
    }

}