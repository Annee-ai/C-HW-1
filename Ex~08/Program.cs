//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (0,0); B (1,1), -> ~1.4
//A (2,4); B (0,7) -> ~3.6
//Start
Console.WriteLine("Enter the coordinates of the first point А: ");
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates of the second point B: ");
int b1 = Convert.ToInt32(Console.ReadLine());
int b2= Convert.ToInt32(Console.ReadLine());

int A = (b1-a1);
int B = (b2-a2);
Double A1 = Math.Pow(A,2);
Console.WriteLine(A1);
Double B1 = Math.Pow(B,2);
Console.WriteLine(B1);
Double i = Math.Sqrt((A1 + B1));
Console.WriteLine(i);