// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumNum(int N, int M)
{
    if (N == M) return M;
    return SumNum(N, M - 1) + M;

}
Console.WriteLine(SumNum(1, 15));
Console.WriteLine(SumNum(4, 8));