//Задача 64: Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// 1.Get N-Number via console
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0) // All numbers will be positive
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввлели не число. Введите корректное число!");
        }
    }

    return result;
}

int GetAllNaturalNumbersFromNToOneWithRecursion(int number)
{
    if (number == 0 || number == 1)
    {
        Console.Write("1 ");
        return 1;
    }
    else if (number > 1)
    {
        Console.Write($"{number} ");
        return GetAllNaturalNumbersFromNToOneWithRecursion(number - 1);
    } else
    {
        return -1; // error
    }
}

int number = GetNumber("Input you natural number: ");
GetAllNaturalNumbersFromNToOneWithRecursion(number);