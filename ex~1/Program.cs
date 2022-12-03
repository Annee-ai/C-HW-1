// start 

using System;

Console.WriteLine("Введите значения трёх чисел");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a; 

if (a < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("max :");
Console.WriteLine(max);

// END 