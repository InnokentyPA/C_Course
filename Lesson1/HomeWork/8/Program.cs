//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите кличество элементов массива: ");
int a = int.Parse(Console.ReadLine());
int[] n = new int[a];
int i = 0;
int resoult = 0;
while (i < a)
{
    if (n[i] % 2 == 0) resoult = n[i];
    i++;
}
Console.WriteLine(resoult);