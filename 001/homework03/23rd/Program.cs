// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowSequenceWithCubeOfNumbersFromOneToN(int number)
{
    bool isNumberPositive;
    string sequence = "";

    if (number >= 0)
        isNumberPositive = true;
    else
        isNumberPositive = false;

    if (isNumberPositive)
    {
        for (int i = 1; i <= number; i++)
            sequence += $"{Math.Pow(i, 3)}, ";
    }
    else
    {
        for (int i = number; i <= 1; i++)
        {
            if (i != 0)
                sequence += $"{Math.Pow(i, 3)}, ";
        }
    }

    Console.WriteLine($"{number} > {sequence.Remove(sequence.Length - 2)}");
}

ShowSequenceWithCubeOfNumbersFromOneToN(3);
ShowSequenceWithCubeOfNumbersFromOneToN(5);
ShowSequenceWithCubeOfNumbersFromOneToN(-8);