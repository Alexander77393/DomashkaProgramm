// // Урок 1. Знакомство с языком программирования С#

// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3


// int NumMax = 0;
// int NumMin = 0;

// Console.Write("Введите первое число: ");
// int NumberA = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int NumberB = int.Parse(Console.ReadLine()!);

// if (NumberA > NumberB)
// {
//     NumMax = NumberA;
//     NumMin = NumberB;
// }
// else
// {
//     NumMax = NumberB;
//     NumMin = NumberA;
// }

// Console.WriteLine($"Большее = {NumMax}");
// Console.WriteLine($"Меньшее = {NumMin}");


// --------------------------------------------------------------------


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int NumX = 0;


// Console.Write("Введите первое число: ");
// int NumA = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int NumB = int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье число: ");
// int NumC = int.Parse(Console.ReadLine()!);

// if (NumA > NumX)
// {
//     NumX = NumA;
// }

// if (NumB > NumX)
// {
//     NumX = NumB;
// }

// if (NumC > NumX)
// {
//     NumX = NumC;
// }

// Console.WriteLine($"Максимальное значение {NumX}");


// ------------------------------------------------------------------------------------


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4->да
// - 3->нет



// Console.Write("Введите число: ");
// int NumberA = int.Parse(Console.ReadLine()!);

// int NumberB = NumberA % 2;

// if (NumberB == 0)
// {
//     Console.WriteLine($"{NumberB} четное");
// }
// else
// {
//     Console.WriteLine($"{NumberB} нечетное");
// }


// ------------------------------------------------------------------------------------------


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.Write("Введите число: ");
// int NumberA = int.Parse(Console.ReadLine()!);

// int NumberB = 2;
// if (NumberA > 1)
// {
//     while (NumberB <= NumberA)
//     {
//         Console.WriteLine($"{NumberB} Четное число");
//         NumberB = NumberB + 2;
//     }

// }