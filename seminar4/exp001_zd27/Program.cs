// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

long IntToAbs(long intNum)
{
    if (intNum < 0)
    {
        intNum = intNum * (-1);
    }
    return intNum;
}

long SumOfNumber(long Number)
{
    long Sum = 0;
    while (Number > 0)
    {
        Sum = Sum + Number % 10;
        Number = Number / 10;
    }
    return Sum;
}

void Deduction()
{
    Console.Clear();
    Console.Write("Введите число: ");
    long inputNumber = Convert.ToInt64(Console.ReadLine());
    inputNumber = IntToAbs(inputNumber);
    Console.WriteLine($"Сумма цифр {inputNumber} = {SumOfNumber(inputNumber)}");
}

Deduction();