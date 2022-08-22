// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
void BestNumbers(int M, int N)
{
    if (N % 2 == 0)
        Console.Write($"{N}, ");
    if (N <= M) return;
    BestNumbers(M, N - 1);
}
BestNumbers(4, 8);