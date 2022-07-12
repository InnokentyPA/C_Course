//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());
if (a == 6)
Console.WriteLine("Выходной");
else if (a == 7)
Console.WriteLine("Выходной");
else if (a == 1)
Console.WriteLine("Будни");
else if (a == 2)
Console.WriteLine("Будни");
else if (a == 3)
Console.WriteLine("Будни");
else if (a == 4)
Console.WriteLine("Будни");
else if (a == 5)
Console.WriteLine("Будни");
else
Console.WriteLine("Error");