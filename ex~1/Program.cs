// start 

using System;

Console.WriteLine("Введите значения трёх чисел");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int Max (int a, int b, int c) 
{
    int res = a;
    if ( b > res) res = b;
    if ( c > res)  res = c;
    return res;
}
int max = Max (a, b, c);
Console.WriteLine("max :");
Console.WriteLine(max);

// END 