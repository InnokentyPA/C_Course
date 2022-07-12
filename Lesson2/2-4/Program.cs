//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
void krat (int N)
{
    if (N % 7 == 0 && N % 23 == 0)
    Console.WriteLine ("Yes");
    else
    {
        Console.WriteLine ("No");
    }
}
int n = int.Parse(Console.ReadLine());

krat (n);