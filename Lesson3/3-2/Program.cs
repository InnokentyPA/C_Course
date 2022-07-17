//Задача 2: Напишите программу, которая 
//принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
//AB = √(xb - xa)2 + (yb - ya)2
//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double Distanse(double x1, double y1, double x2, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 -x2,2) + Math.Pow(y1 - y2,2)),4);
}
Console.WriteLine(Distanse(3, 6, 2, 1));