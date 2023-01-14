using static System.Console;
public static class Lib25
{

    public static int INPUT(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

     public static void SumElementov(int m, int n)
        {
            if (m > 0 && n >0)
            {
            int res = 0;
            for (int i = m; i <= n; i++)
            {
                res += i;
            }
            Console.WriteLine($"Сумма натуральных элементов -> {res}");
            }
            else
            {
              Console.WriteLine($"необходимо ввести натуральные числа");
            }


        }

}