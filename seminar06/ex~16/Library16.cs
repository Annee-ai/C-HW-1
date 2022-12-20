using static System.Console;
public static class Library16
{
    public static int InPut( string text )
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int[] CreatAr(int count)
    {
        return new int [count];
    }

    public static void Main (int[] A)
    {
        // Console.Write("Введите кол-во элементов массива: ");
        // int n = int.Parse(Console.ReadLine());
        // int[] A = new int[n];
        for (int i = 0; i < A.Length; i++)
        {
            //Console.Write($"Введите элемент массива под инденксом {i} -");
            A[i] = int.Parse(Console.ReadLine());
        }
        // Console.Write("Вывод массива: ");
        // for (int i = 0; i < A.Length; i++)
        // {
        //     Console.Write(A[i]+" ");
        // }
        //Console.ReadLine();
    } 
    
    public static int MrZero (int[] A)
    {
        int result = 0;
        for (int i = 0; i < A.Length; i++)
        {
           if (A[i] > 0)
           {
            result ++;
           } 
        }
        return result;
    }
}