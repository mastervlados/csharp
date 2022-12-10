// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string IsFiveDigitsNumberPalendrom(int number)
{
    if (number > 9999 && number < 100000)
    {
        int[] numberDigits = new int[5];
        int numberDigitsLength = numberDigits.Length;
        int digit = 0;

        for(int i = 4; i >= 0; i--)
        {
            digit = (number / (int)Math.Pow(10, i)) % 10;
            numberDigits[i] = digit; // Digits will be write as reverse sequence. It doesn't make sense!
        }

        for(int j = 0; j < numberDigitsLength; j++)
        {
            if (numberDigits[j] != numberDigits[numberDigitsLength - 1 - j] && j != 2)
            {
                return $"> {number} не является палиндромом";
            }   
        }

        return $"> {number} является палиндромом";
    }
    else
        return $"> {number} не пятизначное";

}

Console.WriteLine(IsFiveDigitsNumberPalendrom(14212));
Console.WriteLine(IsFiveDigitsNumberPalendrom(12821));
Console.WriteLine(IsFiveDigitsNumberPalendrom(23432));
Console.WriteLine(IsFiveDigitsNumberPalendrom(100000));
Console.WriteLine(IsFiveDigitsNumberPalendrom(1000));