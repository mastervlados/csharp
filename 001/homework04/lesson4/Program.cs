// ****************************
// *** Lesson 4 - Functions ***
// ****************************

//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// План:
// 1. метод, который получает число с консоли
// 2. метод, который считает сумму от 1 до N

/*
 * 1. метод, который получает число с консоли
 */
//int GetNumber(string message)
//{
//    bool isCorrect = false;
//    int result = 0;

//    while (!isCorrect)
//    {
//        Console.WriteLine(message);

//        if(int.TryParse(Console.ReadLine(), out result) && result > 0) // !important
//        {
//            isCorrect = true;
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод. Введите число больше 0");
//        }
//    }

//    return result;
//}

/*
 * 2. метод, который считает сумму от 1 до N
 */
//int GetSum(int number)
//{
//    int sum = 0;

//    for(int i = 1; i <= number;i++)
//    {
//        sum += i;
//    }

//    return sum;
//}

//int number = GetNumber("Введите число больше 0: ");
//int sum = GetSum(number);

//Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");


//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//int CountOfDigits(int number)
//{
//    int count = 0;

//    while (number > 0)
//    {
//        count += 1;
//        number /= 10;
//    }

//    return count;
//}

//Console.WriteLine(CountOfDigits(456));
//Console.WriteLine(CountOfDigits(78));
//Console.WriteLine(CountOfDigits(89126));


//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120
//int GetSumBetweenNumbersFromOneToNumber(int number)
//{
//    int result = 1;

//	for (int i = 1; i < number; i++)
//	{
//		result += result * i;
//	}

//	return result;
//}

//Console.WriteLine(GetSumBetweenNumbersFromOneToNumber(4));
//Console.WriteLine(GetSumBetweenNumbersFromOneToNumber(5));


//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

void FillArrayRandomValuesLikeZeroOrOne(int arrayLength)
{
    int[] array = new int[arrayLength];
	string result = String.Empty;

	for (int i = 0; i < arrayLength; i++)
	{
		array[i] = new Random().Next(0, 2); // [0, 1] 'cause C# doing the value -1 in second argument
		result += $"{array[i]}, ";
    }

    // cut last two symbols ~ ", "
    result = result.Remove(result.Length - 2);


    Console.WriteLine($"> Заполнил массив из {arrayLength} елементов 1 и 0:\n[{result}]");
}
FillArrayRandomValuesLikeZeroOrOne(8);
FillArrayRandomValuesLikeZeroOrOne(10);
FillArrayRandomValuesLikeZeroOrOne(3);