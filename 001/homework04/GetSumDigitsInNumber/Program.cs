//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetSumDigitsInNumber(int number)
{
    int digit = 0;
    int result = 0;

    while (number > 0)
    {
        digit = number % 10; // 2 5 4
        number /= 10;
        result += digit; // 2 + 5 = 7 + 4 = 11
    }

    return result;
}

Console.WriteLine(GetSumDigitsInNumber(452));
Console.WriteLine(GetSumDigitsInNumber(82));
Console.WriteLine(GetSumDigitsInNumber(9012));
