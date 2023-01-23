// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


 Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int numA = num % 100 / 10;
if(num / 100 == 0 || num / 1000 > 0)
{
    Console.WriteLine($"{num} не трехзначное число. Введите число: ");
    
}else{
    Console.WriteLine($"Трехзначное число {num} -> {numA}");
}


