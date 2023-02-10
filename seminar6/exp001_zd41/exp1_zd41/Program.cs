// // Задача 41: Пользователь вводит с клавиатуры M чисел.
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3
using System.Text;


void Main()
{
    Console.Clear();
    System.Console.Write("Введите строку: ");
    string inputString = Console.ReadLine()!;
    string simpleString = ReturnSimpleString(inputString!);
    System.Console.WriteLine($"Oбнаружены числа: {simpleString}");
    System.Console.WriteLine($"Положительных чисел: {SearchUpperZero(simpleString)} шт");
}

int SearchUpperZero(string stringForSearch)
{
    int countNatural = 0;
    string[] numbers = stringForSearch.Split(",");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (Convert.ToInt32(numbers[i]) > 0)
            countNatural++;
    }
    return countNatural;
}



string ReturnSimpleString(string inString)
{
    StringBuilder snake = new StringBuilder(32);
    string maybeInt = null;  

    for (int i = 0; i < inString.Length; i++)
    {
        if (inString[i] == '-') 
        {
            if (maybeInt != null && maybeInt != "-")      
            {
                snake.Append(maybeInt + ", ");
                maybeInt = "-";        
            }
            else maybeInt = "-";                 
        }
        else if (Char.IsNumber(inString[i]))
        {
            maybeInt += inString[i];
            if ((i == inString.Length - 1))
            {
                snake.Append(maybeInt);
            }
        }
        else
        {
            if (maybeInt != null && maybeInt != "-")       
            {
                snake.Append(maybeInt + ", ");
                maybeInt = null;        
            }
            else if (maybeInt != null)                      
            {
                maybeInt = null; 
            }
        }
    }
    return snake.ToString();
}

Main();

