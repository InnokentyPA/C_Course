// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
int[,] NewArr(int[,] arr1, int[,] arr2)
{

    int row1 = arr1.GetLength(0);
    int column1 = arr1.GetLength(1);
    int row2 = arr2.GetLength(0);
    int column2 = arr2.GetLength(1);
    int[,] Res = new int[row1, column2];
    if (column1 != row2)
    {
         Console.WriteLine("No");
    }
    else
    {
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column2; j++)
            {

                int sum = 0;
                for (int k = 0; k < column1; k++)
                {
                    sum += arr1[i, k] * arr2[k, j];
                }
                Res[i, j] = sum;
            }
        }
    }
    return Res;
}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

Console.Write("Enter the number of rows: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column1 = int.Parse(Console.ReadLine());

int[,] arr_2 = MassNums(row1, column1, 1, 10);
Print(arr_2);

int [,]result = NewArr(arr_1, arr_2);
Print (result);