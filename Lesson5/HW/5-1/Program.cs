//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
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
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int NiceNum(int[] arr)
{
    int size = arr.Length;
    int OTBET = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) OTBET += 1;
    }
    return OTBET;
}
int[] arr_1 = MassNums(8);
Print(arr_1);
Console.WriteLine(NiceNum(arr_1));