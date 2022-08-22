//Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
string ChengeNum(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}
Console.WriteLine(ChengeNum(12));