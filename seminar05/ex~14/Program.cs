//: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
using static Kla;

int N = InPut("Enterrrr the numberrr ");
int[] A = CreatAr(N);
Fiil(A);
Console.WriteLine(Print(A));
Console.WriteLine(anQuan(A));

