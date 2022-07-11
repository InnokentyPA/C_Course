Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Пн");
}
else if (a == 2)
{
    Console.WriteLine("Вт");
}
else if (a == 3)
{
    Console.WriteLine("Ср");
}
else if (a == 4)
{
    Console.WriteLine("Чт");
}
else if (a == 5)
{
    Console.WriteLine("Пт");
}
else if (a == 6)
{
    Console.WriteLine("Сб");
}
else if (a == 7)
{
    Console.WriteLine("Вс");
}
else
{
    Console.WriteLine("Error");
}