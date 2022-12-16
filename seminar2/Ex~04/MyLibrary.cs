using static System.Console;
/// <summary>
/// Моя первая Библиотека
/// </summary>
public static class MyLibrary
{
    
    /// <summary>
    /// Enter the text!
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
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