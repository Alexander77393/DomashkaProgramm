// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число ");
int numberA = int.Parse(Console.ReadLine()!);
if (numberA == 1) Console.WriteLine("Понедельник -> нет");
if (numberA == 2) Console.WriteLine("Вторник -> нет");
if (numberA == 3) Console.WriteLine("Среда -> нет");
if (numberA == 4) Console.WriteLine("Четверг -> нет");
if (numberA == 5) Console.WriteLine("Пятница -> нет");
if (numberA == 6) Console.WriteLine("Суббота -> да");
if (numberA == 7) Console.WriteLine("Воскресенье -> да");
if (numberA < 1 || numberA > 7) Console.WriteLine("Такого дня недели не существует");
