//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Write first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Write third number: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.Write("Max = ");
Console.WriteLine(max);