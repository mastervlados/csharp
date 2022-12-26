//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет
void CheckForElementInMatrixByPosition(int i, int j)
{
	int value = 0;
    int[,] matrix = new int[3, 4] { // columns | rows
        {1, 4, 7, 2}, 
        {5, 9, 2, 3}, 
        {8, 4, 2, 4} 
    };
    int columns = matrix.GetLength(0);
    int rows = matrix.GetLength(1);

    Console.WriteLine();

    try
	{
		value = matrix[i, j];
        Console.WriteLine($"> Да, такой элемент есть! - {value}");
	}
	catch
	{
        Console.WriteLine("> Ты хорошо подумал?\nЯ вот скажу тебе все, что о тебе думаю:");
        throw; // means it shows an error!
    }
    finally
    {
        Console.WriteLine("Array:");
        for (int a = 0; a < columns; a++)
        {
            for (int b = 0; b < rows; b++)
            {
                Console.Write($" {matrix[a, b]}");
            }
            Console.WriteLine();
        }
    }
}

CheckForElementInMatrixByPosition(1, 1);
CheckForElementInMatrixByPosition(1, 7);