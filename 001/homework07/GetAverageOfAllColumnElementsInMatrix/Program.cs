//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2 
//5 9 2 3
//8 4 2 4 
// avg(1) avg(2) avg(3)
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int GetRandomDigitsNumber()
{
    int randomNumber = new Random().Next(-999, 1000); // -999 - 999

    return randomNumber;
}

int[,] GetRandomMatrix()
{
    int columns = new Random().Next(1, 10); // 1 - 9
    int rows = new Random().Next(1, 10); // 1 - 9

    int[,] randomMatrix = new int[columns, rows];

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            randomMatrix[i, j] = GetRandomDigitsNumber();
        }
    }

    return randomMatrix;
}

void GetAverageOfAllColumnElementsInMatrix(int[,] matrix)
{
    int columns = matrix.GetLength(0);
    int rows = matrix.GetLength(1);
    int[] lastRowWithAverageSums = new int[rows];

    // # * *
    // # * *
    // # * *
    // avg(#)

    Console.WriteLine();
    
    // Fill the LastRowWithAverageSums
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            lastRowWithAverageSums[i] += matrix[j, i];
        }
    }

    // Print matrix without averages
    for (int a = 0; a < columns; a++)
    {
        Console.WriteLine();
        for (int b = 0; b < rows; b++)
        {
            Console.Write($" {matrix[a, b]}");
        }
        
    }

    Console.WriteLine();

    // Print footer row with answers
    for (int k = 0; k < rows; k++)
    {
        lastRowWithAverageSums[k] /= columns;
        Console.Write($" Avg{k + 1}({lastRowWithAverageSums[k]})");
    }
}

GetAverageOfAllColumnElementsInMatrix(GetRandomMatrix());