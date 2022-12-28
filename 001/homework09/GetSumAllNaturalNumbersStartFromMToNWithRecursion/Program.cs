//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов
//в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
int GetSumAllNaturalNumbersStartFromMToNWithRecursion(int m, int n, int sum)
{
    if (m == n)
    {
        return sum + m;
    }
    else if (m > n)
    {
        sum += n;
        return GetSumAllNaturalNumbersStartFromMToNWithRecursion(m, n + 1, sum);
    }
    else if (m < n)
    {
        sum += m;
        return GetSumAllNaturalNumbersStartFromMToNWithRecursion(m + 1, n, sum);
    }
    else
    {
        return -1; // error
    }
}

for (int i = 1; i < 10; i++)
{
    int m = new Random().Next(-20, 20); // [-20; 20)
    int n = new Random().Next(-25, 25); // [-25; 25)
    int sum = 0;

    // Print
    Console.WriteLine($"{i} | Range: [{m}; {n}] | Sum = {GetSumAllNaturalNumbersStartFromMToNWithRecursion(m, n, sum)}");
}