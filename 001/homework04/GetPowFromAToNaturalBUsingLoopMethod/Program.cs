//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16

double GetPowFromAToNaturalBUsingLoopMethod(double a, int b)
{
    double result = 1;

	for (int i = 0; i < b; i++)
	{
		result *= a;
	}

	return result;
}

Console.WriteLine(GetPowFromAToNaturalBUsingLoopMethod(3, 5));
Console.WriteLine(GetPowFromAToNaturalBUsingLoopMethod(2, 4));
Console.WriteLine(GetPowFromAToNaturalBUsingLoopMethod(2.25, 4));