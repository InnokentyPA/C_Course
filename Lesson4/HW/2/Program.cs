//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int NumSum(int num)
{
    int Sum = 0;
    for(int i=1; num > 0; i++)
    {
        Sum += num%10;
        num /= 10;
    }
    return Sum;
}
Console.WriteLine(NumSum(753));