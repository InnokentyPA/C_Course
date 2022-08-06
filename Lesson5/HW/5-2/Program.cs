//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 89, 6] -> 0
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}
int NiceNum(int[] arr)
{
    int size = arr.Length;
    int OTBET = 0;
    for (int i = 0; i < size; i+=2)
    {
        OTBET += arr[i];
    }
    return OTBET;
}
int[] arr_1 = MassNums(9);
Print(arr_1);
Console.WriteLine(NiceNum(arr_1));