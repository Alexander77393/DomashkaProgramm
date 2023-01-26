// Задача 19

// Напишите программу, которая принимает на

// вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


while (true)
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    if ((number / 10000) < 1)
    {
        Console.WriteLine($"неверно, введите число: ");
        continue;
    }
    else
    {
        int result = number;
        int count;
        int numberA = 0;
        while (number > 0)
        {
            count = number % 10;
            numberA = numberA * 10 + count;
            number = number / 10;
        }
        if (result == numberA)
        {
            Console.WriteLine($" {result} это число палиндром");
            break;
        }
        else
        {
            Console.WriteLine($" {result} не палиндром");
            break;
        }
    }
}