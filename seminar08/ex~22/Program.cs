﻿//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
using static Libary22;
int m = InPut("Введите количество строк массива m = ");
int n = InPut("Введите количество столбцов массива n = ");
int[,] A = new int[m,n];
FillArray(A);
PrintArray(A);
SumStroki(A);