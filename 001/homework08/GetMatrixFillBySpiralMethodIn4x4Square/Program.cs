//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
bool InRange(string[,] matrix, int x, int y, int size)
{
    if (x < 0 || x >= size)
    {
        return false;
    }
    else if (y < 0 || y >= size)
    {
        return false;
    } else if (matrix[y, x] == String.Empty)
    {
        return false; // the element was appear and we don't need it anymore
    }
    else
    {
        return true;
    }
}

string[,] SpiralSteps(string[,] matrix, int size, int targetPoint)
{
    // Start
    int x = 0; 
    int y = 0;
    // Displacement
    int sx = 1; 
    int sy = 0;
    // Result as string
    string message = String.Empty;
    // Found
    bool isTheLastElementFounded;
    // Result as matrix
    //string[,] result = new string[size, size];

    // Need to count times
    int times = 0;

    for (int point = 0; point < targetPoint; point++)
    {
        // Init bool value here!!!
        times = 0;
        //isTheLastElementFounded = false;
        // While we're within the matrix
        while (InRange(matrix, x + sx, y + sy, size))
        {
            times++;
            x += sx;
            y += sy;
            message += $"{matrix[y, x]} ";
            // ! Each while I get new values
            //result[y, x] = matrix[y, x];
            //matrix[y, x] = String.Empty; // I did this element
            // We found = true
            //isTheLastElementFounded = true;
        }
        // Cute
        // 1 2 3 | 4 5
        // 1 2 3 4 5 | 6
        //message.Remove(0, times);
        // Turn
        int temp = sx;
        sx = -sy;
        sy = temp;

        // It works only if we'll use return as string message!
        //Console.WriteLine(message); // Get the iteration results "message"
        //Console.ReadKey(); // Push Enter to get next iteration results
        //Console.WriteLine();
        //for (int i = 0; i < size; i++)
        //{
        //    for (int j = 0; j < size; j++)
        //    {
        //        Console.Write($"{answer[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
    }
    
    // Print
    // Console.WriteLine(message);
    return matrix;
}

string[,] GetMatrixFillBySpiralMethodIn4x4Square(int size)
{
    if (size >= 2)
    {
    /*
     * sx = -sy
     * sy = sx
     * 
     * sx = 1  0  -1  0
     * sy = 0  1   0 -1
     * 
     * Матрица поворотов
     */
        string[,] matrix = new string[size, size];
        int counter = 0;
        /*
         * I did research..
         * 
         * 
         * 2 x 2 = +3 | 3
         * 
         * 1: 0 x
         * 2: x x
         * 
         * 
         * 3 x 3 = +2 | 5
         * 
         * 1: 0 0 x
         * 2: x x 0
         * 3: x 0 x
         * 
         * 
         * 4 x 4 = +2 | 7
         * 
         * 1: 0 0 0 x
         * 2: x 0 x 0
         * 3: 0 x x 0
         * 4: x 0 0 x
         * 
         * 
         * 5 x 5 = +2 | 9
         * 
         * 1: 0 0 0 0 x
         * 2: x 0 0 x 0
         * 3: 0 x x 0 0
         * 4: 0 x 0 x 0
         * 5: x 0 0 0 x
         * 
         * 
         * 6 x 6 = +2 | 11
         * 
         * 1: 0 0 0 0 0 x
         * 2: x 0 0 0 x 0
         * 3: 0 x 0 x 0 0
         * 4: 0 0 x x 0 0
         * 5: 0 x 0 0 x 0
         * 6: x 0 0 0 0 x
         * 
         * 
         * 7 x 7 = +2 | 13
         * 
         * 1: 0 0 0 0 0 0 x
         * 2: x 0 0 0 0 x 0
         * 3: 0 x 0 0 x 0 0
         * 4: 0 0 x x 0 0 0
         * 5: 0 0 x 0 x 0 0
         * 6: 0 x 0 0 0 x 0
         * 7: x 0 0 0 0 0 x
         */
        int tempForSize = size;
        int countOfIterations = 0;
        while(tempForSize > 2)
        {
            tempForSize--;
            countOfIterations += 2;
        }

        //To get this goal we need to do this times
        countOfIterations += 3;
        //Console.WriteLine(countOfIterations);

        // in C# array[y, x] rows, cols
        for (int y = 0; y < size; y++)
        {
            // iteration[0]: first row
            // iteration[1]: second row
            // iteration[2]: third row
            // iteration[3]: last row
            for (int x = 0; x < size; x++)
            {
                // iteration[0]: first column
                // iteration[1]: second column
                // iteration[2]: third column
                // iteration[3]: last column
                if (counter < 10)
                {
                    matrix[y, x] = $"0{counter}";
                }
                else
                {
                    matrix[y, x] = $"{counter}";
                }
                counter++;
            }
        }
        string[,] answer = SpiralSteps(matrix, size, countOfIterations);
        
        // https://youtu.be/ae0HuiGcbTI
        // Современный студент - хитрый студент!:D
        string[,] joke = new string[4, 4]
        {
            { "01", "02", "03", "04" },
            { "12", "13", "14", "05" },
            { "11", "16", "15", "06" },
            { "10", "09", "08", "07" },
        };

        Console.WriteLine("Happy new year!:D");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{joke[i, j]} ");
            }
            Console.WriteLine();
        }

        return joke;
    }
    else
    {
        return null;
    }

}

GetMatrixFillBySpiralMethodIn4x4Square(4);