// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. (Цифры считать справа налево).

// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int numA = num / 100;

numA = Math.Abs(numA);
if (numA < 1 )
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else{
    numA %= 10;
    Console.WriteLine($"{num} третье число {numA}");
}