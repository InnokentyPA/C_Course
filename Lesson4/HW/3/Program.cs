//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] RandomArr(int num)
{
    int[] array1 = new int[num];
    for(int i=0; i < num; i++)
        array1[i]=new Random().Next();
    return array1;
}

void ArrOut(int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} ");
}
ArrOut(RandomArr(8));