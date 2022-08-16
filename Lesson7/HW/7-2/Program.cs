//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
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
string PosElem(int[,] arr)
{
    Console.Write("Введите номер строки: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int column = int.Parse(Console.ReadLine());
    if (arr.GetLength(0) < row || arr.GetLength(1) < column)
        return "No";
    else
        return $"{arr[row - 1, column - 1]}";
}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);
Console.WriteLine(PosElem(arr_1));
