﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы 
//каждого элемента.
using static Library23;
int m = InPut("Введите количество строк массива m = ");
int n = InPut("Введите количество столбцов массива n = ");
int k = InPut("Введите третье значение k = ");
int[,,] A = new int[m,n,k];
FillArray(A);
PrintArray(A);