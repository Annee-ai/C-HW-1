// Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
//и выводит на экран десятичное представление числа, записанного в СС по основанию 15
//N: 3 [9, 4, 12] => 2097
using static Lla;

int N = InPut(" Enter the number 'N' ");
int[] A = CreatAr(N);
Fill(A);
Console.WriteLine(Print(A));
Console.WriteLine(Sum(A));
