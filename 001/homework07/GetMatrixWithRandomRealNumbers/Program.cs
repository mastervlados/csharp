//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
double GetRandomRealNumber()
{
    double randomNumber = new Random().NextDouble();
    
    randomNumber = Math.Round(randomNumber, 2);

    return randomNumber;
}

double[,] GetMatrixWithRandomRealNumbers()
{
    int columns = new Random().Next(1, 10); // 1 - 9
    int rows = new Random().Next(1, 10); // 1 - 9

    double[,] randomMatrix = new double[rows, columns]; // I was no right!!! firstly we need input rows, after this - columns!!!:D

    string array = String.Empty;

    Console.WriteLine($"> m(columns) = {columns}, n(rows) = {rows}");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomMatrix[i, j] = GetRandomRealNumber();
            array += $" ({randomMatrix[i, j]}) ";
        }
        array += "\n";
    }

    Console.WriteLine(array);

    return randomMatrix;
}

GetMatrixWithRandomRealNumbers();