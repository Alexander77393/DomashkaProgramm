// Задача 34: Задайте массив заполненный случайными положительными 

// трёхзначными числами. Напишите программу, которая покажет количество

// чётных чисел в массиве. 

// [345, 897, 568, 234] -> 2

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

int[] array = GetArray(4, 100 , 999);
Console.WriteLine(String.Join(" ", array));

int CountArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

Console.WriteLine($"Колличество четных чисел в массиве: {CountArray(array)}");