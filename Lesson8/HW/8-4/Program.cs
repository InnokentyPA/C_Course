// Задача 3. *
// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных. Значения элементов массива 0..9
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
int[,] MassNum(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int CountArr(int[,] arr, int n)
{
    int count = 0;
    foreach (int ar in arr)
    {
        if (ar == n)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNum(row, column, 1, 11);

Console.Write("Enter a number for counting:");
int n = int.Parse(Console.ReadLine());

Print(arr_1);
Console.WriteLine($"Total {n} in arr: {CountArr(arr_1, n)}");