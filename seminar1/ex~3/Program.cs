//START
Console.WriteLine("Введите значениe");
int N = Convert.ToInt32(Console.ReadLine());
for ( int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.ReadKey();