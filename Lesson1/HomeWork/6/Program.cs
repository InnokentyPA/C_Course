﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
Console.WriteLine("Чётное");
else
Console.WriteLine("Нечётное");