// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int colomn = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            Console.Write($"{arr[i, j],6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    Random n_new = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}
void MaxMin(int[,] array)
{
    int row = array.GetLength(0);
    int colomn = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            for (int k = 0; k < colomn - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int flag = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = flag;
                }
            }
        }
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
MaxMin(arr_1);
Print(arr_1);