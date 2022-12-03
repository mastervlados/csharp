//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
void GetSecondNumberFromThreeDigitNumber(int number)
{
    int result = (number % 100 - number % 10) / 10;
    Console.WriteLine(result);
}

GetSecondNumberFromThreeDigitNumber(456);
GetSecondNumberFromThreeDigitNumber(782);
GetSecondNumberFromThreeDigitNumber(918);

//// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//// 5, 25  ->  да
//// -4, 16  ->  да
//// 25, 5  ->  да
//// 8,9  ->  нет
// void CheckPow(int x, int y)
// {
//    int powX = (int)Math.Pow(x, 2);
//    int powY = (int)Math.Pow(y, 2);

//    if (powX == y)
//        Console.WriteLine($"> х = {x} в квадрате будет y = {y}, извлекаем корень получаем обратно {Math.Abs(x)}");
//    else
//    {
//        if (powY == x)
//            Console.WriteLine($"> y = {y} в квадрате будет х = {x}, извлекаем корень получаем обратно {Math.Abs(y)}");
//        else
//            Console.WriteLine("> нет");
//    }

//}

//CheckPow(5, 25);
//CheckPow(-4, 16);
//CheckPow(25, 5);
//CheckPow(8, 9);


//// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//// 7 и 23.
//// 14 -> нет 
//// 46 -> нет 
//// 161 -> да
//void CheckNumber(int number)
//{
//    if (number % 7 == 0 && number % 23 == 0) Console.WriteLine($"> {number} - да");
//    else Console.WriteLine($"> {number} - нет");
//}

//CheckNumber(14);
//CheckNumber(46);
//CheckNumber(161);


//// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//// 34, 5 -> не кратно, остаток 4 
//// 16, 4 -> кратно

//void CompareNums(int x, int y)
//{
//    int result = x % y;
//    if (result == 0) Console.WriteLine($"Число {x} кратно числу {y}");
//    else Console.WriteLine($"Остаток от деления: {result}");
//}

//CompareNums(13, 2);


//// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//int GetRandomNumber()
//{
//    return new Random().Next(100, 1000); // 100 ... 999
//}

//void ShowRandomNumber(int number)
//{
//    Console.WriteLine($"Случайное трехзначное число: {number}");
//    string str = number.ToString();
//    Console.WriteLine($"> {str[0]}{str[2]}");
//}

//ShowRandomNumber(GetRandomNumber());


//void ShowRandomNumberSecond(int number)
//{
//    Console.WriteLine($"Случайное трехзначное число: {number}");
//    int result = ((number / 100) * 10) + (number % 10);
//    Console.WriteLine($"> {result}");
//}

//ShowRandomNumberSecond(GetRandomNumber());


//int GetRandomNumber(int left, int right)
//{
//    Random rand = new GetRandomNumber();
//    int number = rand.Next(left, right + 1); // [left, right)
//    return number;
//}

//int GetMaxDigitOfNumber(int number)
//{
//    int firstDigit = number / 10;
//    int secondDigit = number % 10;

//    if (firstDigit > secondDigit)
//        return firstDigit;
//    else
//        return secondDigit;
//}

//int number = GetRandomNumber(10, 99);

//Console.WriteLine($"Сгенерированное число: {number}");

//int maxDigit = GetMaxDigitOfNumber(number);

//Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");