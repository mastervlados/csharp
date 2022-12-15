//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1,2,5,7,19 -> [1, 2, 5, 7, 19]
//6,1,33-> [6, 1, 33]

using System.Text.RegularExpressions;

// 1. Suggest input all numbers
string GetSequenceOfNumbers()
{
    bool isCorrect = false;
    string sequence = String.Empty;
    string pattern = @"(^\d*[0-9])+(,\d*[0-9]|$)";
    Regex term = new Regex(pattern);

    while (!isCorrect)
    {
        Console.Write($"> Перечислите цифры через запятую без пробелов: ");

        sequence = Console.ReadLine() ?? "";

        if (term.IsMatch(sequence))
        {
            isCorrect = true;
        }
        else
        {
            // message error
            Console.WriteLine($"> {sequence} - перечислите цифры через запятую без пробелов.");
        }
    }

    return sequence;
}

// 2. Create an array with this numbers
int[] GetArrayWithNumbersFromNumberSequence(string sequence)
{
    string[] arraySequenceOfNumbersString = sequence.Split(',');
    int[] arrayWithConvertedNumbersToInt = Array.ConvertAll(arraySequenceOfNumbersString, int.Parse);
    string result = String.Empty;

    for (int i = 0; i < arrayWithConvertedNumbersToInt.Length; i++)
    {
        result += $"{arraySequenceOfNumbersString[i]}, ";
    }

    // cut last two symbols ~ ", "
    result = result.Remove(result.Length - 2);

    Console.WriteLine($"> Держи: [{result}]"); // Show to user info

    return arrayWithConvertedNumbersToInt; // Get our created array 
}

GetArrayWithNumbersFromNumberSequence(GetSequenceOfNumbers());