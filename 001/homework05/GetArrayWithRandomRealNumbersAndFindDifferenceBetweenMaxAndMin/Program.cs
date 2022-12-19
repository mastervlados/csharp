//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// Examples: -2.654654 +5.46546 5 8
double GetRandomRealNumber()
{
    double randomNumber = new Random().NextDouble();

    return randomNumber;
}

void GetArrayWithRandomRealNumbersAndFindDifferenceBetweenMaxAndMin(int length)
{
    string array = String.Empty;
    int count = 0;
    double targetSum = 0;

    double[] arrayWithRandomRealNumbers = new double[length];

    for (int i = 0; i < length; i++)
    {
        arrayWithRandomRealNumbers[i] = GetRandomRealNumber();
    }

    // Important! This values can't be equal zeros!
    double maxValue = arrayWithRandomRealNumbers[0];
    double minValue = arrayWithRandomRealNumbers[1];

    for (int j = 0; j < length; j++)
    {
        array += $"{Math.Round(arrayWithRandomRealNumbers[j], 2)}  ";

        // Get compact mode
        count++;
        if (count == 7)
        {
            count = 0;
            array += "\n> ";
        }

        // WHOOOAAA!!!:D
        if (arrayWithRandomRealNumbers[j] > maxValue)
        {
            maxValue = arrayWithRandomRealNumbers[j];
        }
        else if (arrayWithRandomRealNumbers[j] < minValue)
        {
            minValue = arrayWithRandomRealNumbers[j];
        }
        else
        {
            // do nothing
        }
    }

    // Cut the tail " " (always be)
    array = array.Remove(array.Length - 2);

    targetSum = maxValue - minValue;
    targetSum = Math.Round(targetSum, 2);
    maxValue = Math.Round(maxValue, 2);
    minValue = Math.Round(minValue, 2);
    Console.WriteLine($"> {array}\nРазница между max({maxValue}) - min({minValue}) = {targetSum}");
    Console.WriteLine();
}

GetArrayWithRandomRealNumbersAndFindDifferenceBetweenMaxAndMin(4);
GetArrayWithRandomRealNumbersAndFindDifferenceBetweenMaxAndMin(8);
GetArrayWithRandomRealNumbersAndFindDifferenceBetweenMaxAndMin(16);
GetArrayWithRandomRealNumbersAndFindDifferenceBetweenMaxAndMin(32);