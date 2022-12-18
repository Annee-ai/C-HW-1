// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3 7 22 2 78] -> 76
using static Library15;
int N = InPut("Enter the number ");
int[] A = CreatAr(N);
Fill(A);
Console.WriteLine(PrintAr(A));
Console.WriteLine($"{Max(A)} = max");
Console.WriteLine($"{Min(A)} = min");
Console.WriteLine(Sub(Max(A), Min(A)));