// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int MinSumRow(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int rowI = 0;
    int rowSum = 0;
    int sum = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            {
                sum += arr[i, j];
            }
        for (int j = 1; j < column; j++)
            {
                rowSum += arr[i, j];
            }
        if (sum > rowSum)
            {
            sum = rowSum;
            rowI = i + 1;
            }
    }
    return rowI;
}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
Console.WriteLine(MinSumRow(arr_1));