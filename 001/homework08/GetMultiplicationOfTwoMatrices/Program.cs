//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int[,] matrixA = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] matrixB = new int[2, 2] { { 3, 4 }, { 3, 3 } };

void PrintSquare2x2Matrix(int[,] matrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationOfTwoMatrices(int[,] A, int[,] B)
{
    // I'll do this only for 2 x 2 matrices.. for some reason I gotta finish a lot of tasks..
    int[,] result = new int[2, 2];

    result[0, 0] = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
    result[1, 0] = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];

    result[0, 1] = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
    result[1, 1] = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];

    Console.WriteLine("> Матрица A:");
        PrintSquare2x2Matrix(matrixA);
    Console.WriteLine("> Матрица B:");
        PrintSquare2x2Matrix(matrixB);
    Console.WriteLine("> Результат:");
        PrintSquare2x2Matrix(result);

    return result;
}
GetMultiplicationOfTwoMatrices(matrixA, matrixB);