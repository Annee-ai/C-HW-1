﻿//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9 //m = 3, n = 2 -> A(m,n) = 29
using static Lib27;
int m = INPUT("Введите натуральное число ");
int n = INPUT("Введите натуральное число ");
Console.WriteLine(Akker(m, n));