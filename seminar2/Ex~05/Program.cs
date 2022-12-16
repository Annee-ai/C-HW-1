//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
 using static Library; 

 int Num = Input("Enter a number: ");
 int count = Num.ToString().Length;
 Console.WriteLine(MkAr(Num, count));
