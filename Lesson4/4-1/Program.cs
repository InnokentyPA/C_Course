//Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
void Length(int a)
{
    string num = a.ToString();
    Console.WriteLine(num.Length);
}
Length(1670);
//double Digit(double a,double b)
//{
//return((Math.Floor(a/(Math.Pow(10,Math.Floor(Math.Log10(a))-b+1)))%10));
//}