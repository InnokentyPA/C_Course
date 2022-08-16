//1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите кол-во чисел: ");
int num = int.Parse(Console.ReadLine());
int a = 0;
int Pos = 0;
for (int i = 0; i < num; i++)
{
    Console.WriteLine("Введите число: ");
    a = int.Parse(Console.ReadLine());
    if (a > 0) Pos++;
}
Console.WriteLine($" Кол-во чисел больше 0 -> {Pos} ");


//int CountNum()
//{
//    int count = 0;
//    string word;
//
//    while (true)
//    {
//        Console.Write("Output any number: ");
//        word = Console.ReadLine();
//
//        if (word == "") return count;
//        else if (int.Parse(word) > 0) count += 1;        
//    }
//}

//Console.Write(CountNum());


// ----------------------------------------2 вариант

//int Check(int num)
//{
//    int count = 0;
//    
//    for (int i = 1; i <= num; i++)
//    {
//       Console.Write($"Число {i}: ");
//        int a = int.Parse(Console.ReadLine());
//        if (a > 0) count++;
//    }
//    return count;
//}

//Console.Write("Сколько чисел хотели бы ввести?: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Количество чисел больше 0: {Check(a)}");