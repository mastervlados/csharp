//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetRandomDigitsNumber()
{
    int randomNumber = new Random().Next(-9, 10); // -9 - 9

    return randomNumber;
}

int[,] GetRandomRectangularMatrix()
{
    string array = String.Empty;
    int columns = new Random().Next(1, 10); // 1 - 9
    int rows = new Random().Next(1, 10); // 1 - 9

    // i != j
    // j != i

    while ((columns == rows) == true)
    {
        // UPDATE
        columns = new Random().Next(1, 10); // 1 - 9
        rows = new Random().Next(1, 10); // 1 - 9
    }

    int[,] randomRectangularMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        array += $"{i} |";
        for (int j = 0; j < columns; j++)
        {
            randomRectangularMatrix[i, j] = GetRandomDigitsNumber();
            array += $" {randomRectangularMatrix[i, j]} ";
        }
        array += "\n";
    }

    // Print
    Console.WriteLine(array);

    return randomRectangularMatrix;
}

int GetNumberOfTheRowWithSmallestSumOfElementsInRectangularMatrix(int[,] matrix)
{
    //Программа считает сумму элементов в каждой строке
    //и выдаёт номер строки с наименьшей суммой элементов: 1 строка
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] rowsSums = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            rowsSums[i] += matrix[i, j];
        }
    }

    int minTargetValue = rowsSums[0];

    for (int k = 0; k < rows; k++)
    {
        if (minTargetValue > rowsSums[k])
        {
            minTargetValue = rowsSums[k];
        }
    }

    Console.WriteLine($"> Номер строки с наименьшей суммой элементов: {Array.IndexOf(rowsSums, minTargetValue) + 1} значение: {minTargetValue}");

    return minTargetValue;
}

GetNumberOfTheRowWithSmallestSumOfElementsInRectangularMatrix(GetRandomRectangularMatrix());