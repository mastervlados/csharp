//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int GetRandomThreeDigitsNumber()
{
    int randomNumber = new Random().Next(100, 1000); // 100 - 999

    return randomNumber;
}

void GetArrayWithRandomThreeDigitsNumbersAndCountOfEvenDigits()
{
    int randomLength = new Random().Next(1, 100); // 1 - 99
    string array = String.Empty;
    int count = 0;
    int targetCount = 0;

    int[] arrayWithRandomThreeDigitsNumbers = new int[randomLength];

    for (int i = 0; i < randomLength; i++)
    {
        arrayWithRandomThreeDigitsNumbers[i] = GetRandomThreeDigitsNumber();
        array += $"{arrayWithRandomThreeDigitsNumbers[i]}, ";

        // Get compact mode
        count++;
        if (count == 7)
        {
            count = 0;
            array += "\n> ";
        }

        // Easy
        if (arrayWithRandomThreeDigitsNumbers[i] % 2 == 0)
        {
            targetCount++;
        }
    }

    // Cut the tail ", " (always be)
    array = array.Remove(array.Length - 2);

    // return targetCount;
    Console.WriteLine($"> {array}\nКоличество четных чисел в массиве: {targetCount}");
    Console.WriteLine();
}

GetArrayWithRandomThreeDigitsNumbersAndCountOfEvenDigits();