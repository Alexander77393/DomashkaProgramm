// Урок 4. Функции
// Задача 25: Напишите функцию, которая принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();

double AinB(double numA, int numB)
{
    double result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}

int IntAinB(int intNum)
{
    if (intNum < 0)
    {
        intNum = intNum * (-1); 
    }
    return intNum;
}

void Deduction()
{
    System.Console.Write("Введите число A: ");
    double numberA = Convert.ToSingle(Console.ReadLine());
    System.Console.Write("Введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    numberB = IntAinB(numberB);

    System.Console.WriteLine($"{numberA} в {numberB} степени = {AinB(numberA, numberB)}");
}

Deduction();
