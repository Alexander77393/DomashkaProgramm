// Задача 21

// Напишите программу, которая принимает на вход координаты

// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.Write("Введите координат x1: ");
int x1=int.Parse(Console.ReadLine()!);
Console.Write("Введите координат y1: ");
int y1=int.Parse(Console.ReadLine()!);
Console.Write("Введите координат d1: ");
int d1=int.Parse(Console.ReadLine()!);

Console.Write("Введите координат x2: ");
int x2=int.Parse(Console.ReadLine()!);
Console.Write("Введите координат y2: ");
int y2=int.Parse(Console.ReadLine()!);
Console.Write("Введите координат d2: ");
int d2=int.Parse(Console.ReadLine()!);

double result=Math.Sqrt((Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((d2-d1),2)));

Console.WriteLine($"Расстояние между точками {result:F2}");