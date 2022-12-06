using static System.Console;
public static class MyLibrary
{
    //Ввод текста
    public static int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
    //Функция вывода средней цифры трёхзначного чиисла
    public static int InCenter (int a) 
{
    int result = ((a / 10) % 10);
    return result;
}
}