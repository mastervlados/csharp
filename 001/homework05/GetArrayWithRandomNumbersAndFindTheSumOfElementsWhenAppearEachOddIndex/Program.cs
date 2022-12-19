//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0
int GetRandomDigitsNumber()
{
    int randomNumber = new Random().Next(-999, 1000); // -999 - 999

    return randomNumber;
}

void GetArrayWithRandomNumbersAndFindTheSumOfElementsWhenAppearEachOddIndex(int length)
{
    string array = String.Empty;
    int count = 0;
    int targetSum = 0;

    int[] arrayWithRandomDigitsNumbers = new int[length];

    for (int i = 0; i < length; i++)
    {
        arrayWithRandomDigitsNumbers[i] = GetRandomDigitsNumber();
        array += $"{arrayWithRandomDigitsNumbers[i]}, ";

        // Get compact mode
        count++;
        if (count == 7)
        {
            count = 0;
            array += "\n> ";
        }

        // Too easy!:D
        if (i % 2 != 0)
        {
            targetSum += arrayWithRandomDigitsNumbers[i];
        }
    }

    // Cut the tail ", " (always be)
    array = array.Remove(array.Length - 2);

    // return targetSum;
    Console.WriteLine($"> {array}\nСумма элементов, стоящих на нечётных позициях: {targetSum}");
    Console.WriteLine();
}

GetArrayWithRandomNumbersAndFindTheSumOfElementsWhenAppearEachOddIndex(4);
GetArrayWithRandomNumbersAndFindTheSumOfElementsWhenAppearEachOddIndex(8);
GetArrayWithRandomNumbersAndFindTheSumOfElementsWhenAppearEachOddIndex(16);
GetArrayWithRandomNumbersAndFindTheSumOfElementsWhenAppearEachOddIndex(32);