//Задача 3: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
int[] RandomMegaSuperStrongArray()
{
Console.WriteLine("Input number of elements");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Input elemet's min");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Input elemet's max");
int max = int.Parse(Console.ReadLine());
int[] array = new int[num];
for(int i=0; i < num; i++)
{
array[i]=new Random().Next(min, max+1);
Console.Write($"{array[i]} ");
}
return(array);
}

void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

int Nums(int [] array)
{
int count=0;
for(int i=0; i<array.Length; i++)
{
if(array[i]>=10 && array[i]<=99)
count++;
}
return count;

}

int[]arr_1=RandomMegaSuperStrongArray();
Print(arr_1);
Console.WriteLine(Nums(arr_1));