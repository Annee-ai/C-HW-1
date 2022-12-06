//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
//Start
 using static MyLibrary; //подключение библиотеки

int Num = Input("Enter a three-digit number ");
int count = Num.ToString().Length;
if (count < 3 || count>3 )
{
    Console.WriteLine("You have't entered a three-digit number.");
}
else
{
    Console.WriteLine(InCenter(Num));
}
