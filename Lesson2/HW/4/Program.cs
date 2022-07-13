//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());
if (a == 6)
Console.WriteLine("Да");
else if (a == 7)
Console.WriteLine("Да");
else if (a >= 8)
Console.WriteLine("Не существует");
else 
Console.WriteLine("Нет");