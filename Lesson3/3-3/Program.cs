//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
void Skr (int a)
{
    int b = 1;
    while(b <= a)
    {
        Console.WriteLine(Math.Pow(b,2));
        b++;
    }
}
Skr(6);