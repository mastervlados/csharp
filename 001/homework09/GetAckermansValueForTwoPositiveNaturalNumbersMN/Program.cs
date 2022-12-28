//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
// ! numbers > 0
int GetAckermansValueForTwoPositiveNaturalNumbersMN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return GetAckermansValueForTwoPositiveNaturalNumbersMN(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return GetAckermansValueForTwoPositiveNaturalNumbersMN(m - 1, GetAckermansValueForTwoPositiveNaturalNumbersMN(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}

for (int i = 1; i < 10; i++)
{
    int m = new Random().Next(1, 4); // [1; 4)
    int n = new Random().Next(1, 4); // [1; 4)
    
    // Print
    Console.WriteLine($"{i} | A({m}, {n}) = {GetAckermansValueForTwoPositiveNaturalNumbersMN(m, n)}");
}