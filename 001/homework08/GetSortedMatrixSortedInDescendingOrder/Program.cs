//Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
int GetRandomDigitsNumber()
{
    int randomNumber = new Random().Next(-99, 100); // -99 - 99

    return randomNumber;
}

int[,] GetRandomMatrix()
{
    int rows = new Random().Next(3, 5); // 3 - 4
    int columns = new Random().Next(3, 5); // 3 - 4

    int[,] randomMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomMatrix[i, j] = GetRandomDigitsNumber();
        }
    }

    return randomMatrix;
}

void PrintMatrix(int[,] matrix)
{
    int m = matrix.GetLength(0); // rows
    int n = matrix.GetLength(1); // columns

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetSortedMatrixSortedInDescendingOrder()
{
    int[,] matrixAfter = GetRandomMatrix();
    int m = matrixAfter.GetLength(0); // rows
    int n = matrixAfter.GetLength(1); // columns
    int[,] matrixBefore = new int[m, n];
    Array.Copy(matrixAfter, matrixBefore, matrixAfter.Length);

    // Sorted option:
    // Each row in decreasing order
    // input: row like this (1 4 7 2)
    // output: that row like this (7 4 2 1)
    // I'll use the bubble sort 

    int temp = 0;

    for (int i = 0; i < m; i++)
    {
        // 0 0
        // 0 1
        // 0 2
        // 0 3
        for (int sort = 0; sort < n - 1; sort++)
        {
            if (matrixAfter[i, sort] > matrixAfter[i, sort + 1])
            {
                temp = matrixAfter[i, sort + 1];
                matrixAfter[i, sort + 1] = matrixAfter[i, sort];
                matrixAfter[i, sort] = temp;
            }
        }
    }

    // Print
    Console.WriteLine("> Был задан массив:");
    PrintMatrix(matrixBefore);
    Console.WriteLine("> Hell Done! Получился вот такой массив:");
    PrintMatrix(matrixAfter);

    return matrixAfter;
}

GetSortedMatrixSortedInDescendingOrder();

// I spent 6 hours but still have no idea.. It doesn't work correcty
// I need to reverse each row - how?
// I need to sort it.. I used the bubble sort my first time..