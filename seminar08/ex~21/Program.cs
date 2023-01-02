// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
using static Library21;
int m = InPut("Введите количество строк массива m = ");
int n = InPut("Введите количество столбцов массива n = ");
int[,] A = new int[m,n];
FillArray(A);
PrintArray(A);
RegulateArray(A);
Console.WriteLine("итог:");
PrintArray(A);
