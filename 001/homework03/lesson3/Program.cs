//Задача №17.Напишите программу, которая принимает на вход координаты точки (X и Y), //причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//             ^ (y)
//             |
//      2      |     1
//--------------------------> (x)
//      3      |     4
//             |
// 1. reference types(ссылочные типы) - class, char, arrays, list
// 2. value tupes (значимые типы) - int, long, double, datetime, struct, enum, dicimal

//int GetNumber(string message)
//{
//    bool isCorrect = false;
//    int result = 0;

//    while (!isCorrect)
//    {
//        Console.WriteLine(message);
//        if(int.TryParse(Console.ReadLine(), out result) && result != 0 )
//        {
//            isCorrect = true;
//        }
//        else
//        {
//            Console.WriteLine("Ввели неккоретное число");
//        }
//    }

//    return result;
//}

//int GetQuarter(int x, int y)
//{
//    if (x > 0 && y > 0)
//        return 1;
//    if (x < 0 && y > 0)
//        return 2;
//    if (x < 0 && y < 0)
//        return 3;

//    return 4;
//}

//int x = GetNumber("Введите число x:");
//int y = GetNumber("Введите число y:");
//int quarter = GetQuarter(x, y);

//Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в {quarter} четверти");


//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

//string RangeOfPossibleCoordinates(int quarter)
//{
//    switch (quarter)
//    {
//        case 1:
//            return "x = 0 ... +∞\ny = 0 ... +∞";
//            break;
//        case 2:
//            return "x = 0 ... -∞\ny = 0 ... +∞";
//            break;
//        case 3:
//            return "x = 0 ... -∞\ny = 0 ... -∞";
//            break;
//        case 4:
//            return "x = 0 ... +∞\ny = 0 ... -∞";
//            break;
//        default:
//            return "Нужно ввести число от 1 до 4 (четверть)";
//    }      
//}

//Console.WriteLine(RangeOfPossibleCoordinates(1));
//Console.WriteLine("");
//Console.WriteLine(RangeOfPossibleCoordinates(2));
//Console.WriteLine("");
//Console.WriteLine(RangeOfPossibleCoordinates(3));
//Console.WriteLine("");
//Console.WriteLine(RangeOfPossibleCoordinates(4));
//Console.WriteLine("");
//Console.WriteLine(RangeOfPossibleCoordinates(6));


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.//A (3,6); B(2, 1)-> 5,09
//A(7, -5); B(1, -1)-> 7,21
// d = ((x2 - x1)^2 + (y2 - y1)^2)^1/2
// Решила Юлия
//Console.WriteLine("Введите координаты X первой точки");//int x1 = Convert.ToInt32(Console.ReadLine());//Console.WriteLine("Введите координаты Y первой точки");//int y1 = Convert.ToInt32(Console.ReadLine());//Console.WriteLine("Введите координаты X второй точки");//int x2 = Convert.ToInt32(Console.ReadLine());//Console.WriteLine("Введите координаты Y второй точки");//int y2 = Convert.ToInt32(Console.ReadLine());


//double DistXY(int x1, int y1, int x2, int y2)//{//    double result = 0;//    result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));//    return result;//}//Console.WriteLine($"Расстояние между точками = {DistXY(x1, y1, x2, y2)}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел //от 1 до N.//5 -> 1, 4, 9, 16, 25.//2 -> 1,4

int number;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out number);
Console.WriteLine(""); // <br>

void GetPowOfNumber(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($" {Math.Pow(i, 2)}");
    }
}

GetPowOfNumber(number);