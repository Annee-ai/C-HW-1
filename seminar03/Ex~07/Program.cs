// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
// Start
using static Library07;

int Num  = InPut ("Enter the number ");
int n = Num; 
int c = Pal(Num);
///Console.WriteLine(c);
if (n == c)
{
    Console.WriteLine("The number is a Palindom!Congradulation!!!");
    Console.WriteLine("Congradulation!!!");
}
else
{
    Console.WriteLine("The number isn't a Palindom!");
    Console.WriteLine("Try again");
}
