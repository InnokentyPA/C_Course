//3: Напишите программу, которая будет создавать копию заданного массива(вещественные числа) с помощью поэлементного копирования.
void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}
void Copy(double[] arr_1)
{
    double[] copy = new double[arr_1.Length];
    for (int i = 0; i < arr_1.Length; i++)
    {
        copy[i] = arr_1[i];
    }

    Console.WriteLine(String.Join(", ", copy));
}

double[] arr_1 = MassNums(6);
Print(arr_1);
Copy(arr_1);
