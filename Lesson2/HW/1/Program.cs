//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());
int q = (a / 10);
Console.WriteLine(q % 10);