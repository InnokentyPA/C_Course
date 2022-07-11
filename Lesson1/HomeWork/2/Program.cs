//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Write first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write second number: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write("Max = ");
    Console.WriteLine(a);
    Console.Write("Min = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(b);
    Console.Write("Min = ");
    Console.WriteLine(a);
}