//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// 1. Method will be get a sequence of numbers that user input
// 2. Method will sum need value
using System.Text.RegularExpressions;

string InputSequenceOfNaturalNumbers()
{
    string result = String.Empty;
    string sequenceOfNumbers = String.Empty;
    string userInputTheNextTerm = String.Empty;
    Regex regex = new Regex(@"^-?[0-9]+$");

    Console.WriteLine("> Введите нужное кол-во чисел через пробел.\nВы можете вводить положительные/отрицательные целые числа:");
    Console.WriteLine();

    while (true)
    {
        Console.Write("~ ");
        userInputTheNextTerm = Console.ReadLine() ?? "x";

        // I need to be confident
        // that user input a number with/without '-' symbol
        if (regex.IsMatch(userInputTheNextTerm))
        {
            // Using ',' symbol as a separator
            sequenceOfNumbers += $"{userInputTheNextTerm}, ";

            // Using `Ctrl + Space` to fill my variable
            // Make string empty for the next iteration
            userInputTheNextTerm = String.Empty;
        }
        else
        {
            break;
        }
    }

    // Needs to cut the last ", "
    int sequenceLength = sequenceOfNumbers.Length;
    // Be confident that we have enough indexes in the string
    if(sequenceLength > 2)
    {
        // Put the last two sumbols to a tail
        string tail = sequenceOfNumbers.Substring(sequenceLength - 2);

        if (tail == ", ")
        {
            // Cut the tail
            result = sequenceOfNumbers.Remove(sequenceOfNumbers.Length - 2);

            // Show result
            Console.WriteLine($"> Вы ввели последовательность чисел:\n{result}");
        } 
    } 
    else
    {
        // User created an emty string
        Console.WriteLine("> Пустой ввод, попробуйте еще раз!");
    }
   

    

    return result;
}

int GetSumOfAllNumbersFromSequenceThatMoreZero(string sequence)
{
    if (!string.IsNullOrEmpty(sequence))
    {
        int[] arrayWithConvertedNumbersToInt = Array.ConvertAll(sequence.Split(", "), int.Parse);
        int countOfPositiveNumbers = 0;

        for (int i = 0; i < arrayWithConvertedNumbersToInt.Length; i++)
        {
            if (arrayWithConvertedNumbersToInt[i] > 0)
            {
                countOfPositiveNumbers++;
            }
        }

        Console.WriteLine();

        // Need to know the last decimal
        string[] resultOptions = new string[5]
        {
        "чисел", // 0
        "число", // 1
        "числа", // 2
        "числа", // 3
        "числа" // 4 < ~ 0
        };
        int magicIndex = -1;
        int lastDigitInCountOfPositiveNumbers = -1;

        if (countOfPositiveNumbers > 20)
        {
            // We will doing less this value to get the last digit
            lastDigitInCountOfPositiveNumbers = countOfPositiveNumbers % 10;
        }
        else
        {
            lastDigitInCountOfPositiveNumbers = countOfPositiveNumbers;
        }
        

        switch (lastDigitInCountOfPositiveNumbers)
        {
            case 1:
                magicIndex = lastDigitInCountOfPositiveNumbers;
                break;
            case 2:
                magicIndex = lastDigitInCountOfPositiveNumbers;
                break;
            case 3:
                magicIndex = lastDigitInCountOfPositiveNumbers;
                break;
            case 4:
                magicIndex = lastDigitInCountOfPositiveNumbers;
                break;
            default:
                magicIndex = 0;
                break;
        }

        Console.WriteLine($"> Я нашел {countOfPositiveNumbers} {resultOptions[magicIndex]} больше нуля!");

        return countOfPositiveNumbers;
    }

    Console.WriteLine("> Мне попалась пустая строка!");
    return -1;
}

GetSumOfAllNumbersFromSequenceThatMoreZero(InputSequenceOfNaturalNumbers());