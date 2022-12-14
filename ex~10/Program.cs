// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
using static Pla;
int a = InPut("Enter the number ");
int b = InPut("Enter the degree of the number ");
int c = Pow(a, b);
Console.WriteLine(c);