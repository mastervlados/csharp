//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

int[,,] GetTriangularMatrixWithUniqueTwoDigitNumbers()
{
    int x = new Random().Next(2, 5); // 2 - 4
    int y = new Random().Next(2, 5); // 2 - 4
    int z = new Random().Next(2, 5); // 2 - 4
    int twoDigitNumberCounter = 10; // !NB <100

    int[,,] triangularMatrixWithUniqueTwoDigitNumbers = new int[x, y, z];

    int xLength = triangularMatrixWithUniqueTwoDigitNumbers.GetLength(0);
    int yLength = triangularMatrixWithUniqueTwoDigitNumbers.GetLength(1);
    int zLength = triangularMatrixWithUniqueTwoDigitNumbers.GetLength(2);

    Console.WriteLine($"> Массив размером {xLength} x {yLength} x {zLength}:");

    for (int i = 0; i < xLength; i++)
    {
        for (int j = 0; j < yLength; j++)
        {
            for (int k = 0; k < zLength; k++)
            {
                triangularMatrixWithUniqueTwoDigitNumbers[i, j, k] = twoDigitNumberCounter;
                // Console.WriteLine(triangularMatrixWithUniqueTwoDigitNumbers[i, j, k]);
                twoDigitNumberCounter++;
                if (twoDigitNumberCounter > 99)
                {
                    break;
                }
            }
        }
    }

    return triangularMatrixWithUniqueTwoDigitNumbers;
}

void PrintTriangularMatrixLineByLineMethodWithIndexesEachElements()
{
    // NB!= myString += value;
    // Good = Console.WriteLine(line);
    try
    {
        int[,,] matrix = GetTriangularMatrixWithUniqueTwoDigitNumbers();

        int xLength = matrix.GetLength(0);
        int yLength = matrix.GetLength(1);
        int zLength = matrix.GetLength(2);

        int maxRowPower = xLength;
        int countRowPower = 0;

        for (int i = 0; i < xLength; i++)
        {
            for (int j = 0; j < yLength; j++)
            {
                for (int k = 0; k < zLength; k++)
                {
                    countRowPower++;

                    // Print array using the method
                    // 66(0, 0, 0)
                    Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");

                    if (countRowPower == maxRowPower)
                    {
                        Console.WriteLine();
                        countRowPower = 0;
                    }
                }
            }
        }
        
    }
    catch
    {
        Console.WriteLine("> Простите..\nНачальник сказал наполнять массив только десячиными числами.\nОни закончились..");
        throw;
    }
}

PrintTriangularMatrixLineByLineMethodWithIndexesEachElements();