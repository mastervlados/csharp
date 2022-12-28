// ****************
// *** Lesson 5 ***
// ****************

//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

// UPDATE. Start from Lesson 5 finish at Lesson 8
// Add Lesson 5's example
// x Add homework for Lesson 7
// Add Lesson 8's example & homework08

/*
 * 1. получить размерность массива с консоли
 * 2. получить заполненный массив из рандомно-заполненных чисел
 * 3. распечатать массив - вывести на консоль
 * 4. найти сумму положительных элементов
 * 5. найти сумму отрицательных элементов
 * 6. попробовать сделать это в одном методе
 */


// 1.получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0) // All numbers will be positive
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввлели не число. Введите корректное число!");
        }
    }

    return result;
}

// 2.получить заполненный массив из рандомно-заполненных чисел
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random random = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = random.Next(-20, 21); // -20 +20
    }

    return array;
}

// 3.распечатать массив - вывести на консоль
void PrintArray(int[] array)
{
    Console.Write("Array: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($" | {array.Length}");
    Console.WriteLine();
}

// 4.найти сумму положительных элементов
//int GetSumOfPositiveNumbersInArray(int[] array)
//{
//    int result = 0; // sum of target values

//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > 0)
//        {
//            result += array[i];
//        }
//    }

//    return result;
//}

// 5.найти сумму отрицательных элементов
//int GetSumOfNegativeNumbersInArray(int[] array)
//{
//    int result = 0; // sum of target values

//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] < 0)
//        {
//            result += array[i];
//        }
//    }

//    return result;
//}

// ***********************************
// **** C# Кортежи | Tuple (Тюпл) ****
// ***********************************
/*
 * Кортэж это несколько значений, сколько хочу через запятую
 * (int, bool, double, string, char, etc)
 */

// 6.попробовать сделать это в одном методе
/*
 * @int = positiveSum
 * @int = negativeSum
 */
(int, int) GetSumsPositiveNegativeNumbersInArray(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positiveSum += array[i];
        }
        else if (array[i] < 0)
        {
            negativeSum += array[i];
        }
        else
        {
            // Do nothing.
        }
    }

    // !!! Important
    // !!! Keeping the sequence - return each value
    return (positiveSum, negativeSum);
}

int dimension = GetNumber("Input dimension of the future array:");
int[] array = InitArray(dimension);
PrintArray(array);
//int positiveSum = GetSumOfPositiveNumbersInArray(array); 
//int negativeSum = GetSumOfNegativeNumbersInArray(array);
//Console.WriteLine($"Получены результаты:\n> Сумма отрицательных чисел = {negativeSum}\n> Сумма положительных чисел = {positiveSum}");
// ***********************************
// **** Get values from the Tuple ****
// ***********************************
(int positiveSumFromTuple, int negativeSumFromTuple) = GetSumsPositiveNegativeNumbersInArray(array);
// ***********************
// **** Tuple | Usage ****
// ***********************
Console.WriteLine($"Получены результаты:\n> Сумма отрицательных чисел = {negativeSumFromTuple}\n> Сумма положительных чисел = {positiveSumFromTuple}");
