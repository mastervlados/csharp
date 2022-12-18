//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// 1. получения числа (размерность)
// 2. инициализация массива
// 3. печать массива
// 4. перевернуть массив

int GetNumber(string message)
{
	int result;
	while (true)
	{
		Console.WriteLine(message);

		if (int.TryParse(Console.ReadLine(), out result))
		{
			break;
		}
		else
		{
			Console.WriteLine("Input number.");
		}
	}
	return result;
}

int[] InitArray(int dimension)
{
	Random rnd = new Random();
	int[] array = new int[dimension];

	for (int i = 0; i < dimension; i++)
	{
		array[i] = rnd.Next(1, 10);
	}

	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}


int[] ReverseArray(int[] array)
{
	int[] result = new int[array.Length];
	int count = 0;

	for (int i = array.Length - 1; i >= 0; i--)
	{
		result[count] = array[i];
		count++;
	}
	return result;
}


int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);

int[] result = ReverseArray(array);
PrintArray(result);

// **********************
// *** Array Core F12 ***
// **********************
// ******************************
// *** Встроенный класс Array ***
// ******************************
Array.Reverse(result);
PrintArray(result);
// ******************************
// ******************************

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// (НЕ РАБОТАЕТ)

//bool IsTriangularWithNextSides(int a, int b, int c)
//{
//	int[] triangularSides = new int[3] { a, b, c };

//	for (int i = 0; i < triangularSides.Length; i++)
//	{
//		for (int j = 0; j < triangularSides.Length; j++)
//		{
//			if (triangularSides[i] > triangularSides[j] && i != j)
//			{
//				return false;
//			}
//		}
//	}

//	return true;
//}

//Console.WriteLine(IsTriangularWithNextSides(80, 10, 15));
//Console.WriteLine(IsTriangularWithNextSides(8, 10, 15));
//Console.WriteLine(IsTriangularWithNextSides(3, 3, 3));

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

//string GetBinaryFromDecimal(int decimalNumber)
//{
//    // 11 % 2 = 5.5 = 1
//    // 5 % 2 = 2.5 = 1
//    // 2 % 2 = 1 = 0
//    // 1 % 2 = 0.5 = 1
//    int number = decimalNumber;
//    int remainderDividingOnNumberByTwo = 0;
//    string result = String.Empty;

//    while (number >= 1)
//    {
//        remainderDividingOnNumberByTwo = number % 2;
//        number /= 2;
//        if (remainderDividingOnNumberByTwo != 0)
//        {
//            result += "1";
//        }
//        else
//        {
//            result += "0";
//        }
//    }

//    return new string (result.Reverse().ToArray());
//}

//Console.WriteLine(GetBinaryFromDecimal(11));
//Console.WriteLine(GetBinaryFromDecimal(158));

// ***************************
// ***************************
// ***************************
// Регулярные выражения
// Искать сервисы для JS и C#
// https://regex101.com/
// ***************************
// ***************************
// ***************************
// **************************************************************
// **************************************************************
// **************************************************************
// Каждый офисный файл можно превратить в архив
// Удалить расширение и проставить .zip для экселей и вордов
// **************************************************************
// **************************************************************
// **************************************************************