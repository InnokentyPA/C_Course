﻿//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
Console.WriteLine($"{a/100}{a%10}");