//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void KU(int a)
{
    if (a > 99999 || a < 10000)
    Console.WriteLine("Error");
    else if (a / 10000 == a % 10 && (a / 1000) % 10 == (a % 100) / 10)
        Console.WriteLine("Палиндром");
    else
        Console.WriteLine("Не палиндром");
}

Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
KU(a);