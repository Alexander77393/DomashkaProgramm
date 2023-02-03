// Задача 36: Задайте одномерный массив, 

// заполненный случайными числами. Найдите сумму 

// элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(8, -10, 10);
Console.WriteLine(String.Join(" ", array));

int CountArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i += 2)
    result += array[i];
    return result;
}

Console.WriteLine($"Стоят на нечетных позициях: {CountArray(array)}");