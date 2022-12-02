// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа сравнит 2 числа и покажет какое из них больше, а какое меньше");

int numberA = 0;
int numberB = 0;

Console.WriteLine(""); // br
Console.Write("Введите число A: ");
if(!int.TryParse(Console.ReadLine(), out numberA))
{
    Console.WriteLine("Нужно ввести число!");
}
else
{
    Console.WriteLine(""); // br
    Console.Write("Введите число B: ");
    if(!int.TryParse(Console.ReadLine(), out numberB))
    {
        Console.WriteLine("Нужно ввести число!");
    }
    else
    {
        Console.WriteLine(""); // br
        // Fix problem
        // case can only be used with a constant!
        if(numberA > numberB)
        {
            Console.WriteLine($"> Число {numberA} больше числа {numberB}.");
        }
        if(numberA < numberB)
        {
            Console.WriteLine($"> Число {numberB} больше числа {numberA}.");
        }
        if(numberA == numberB)
        {
            Console.WriteLine($"> {numberA}, {numberB} равны!");
        }
    }
}

// int getNumber(string message)
// {
//     bool isCorrect = false;
//     int result = 0;

//     while(!isCorrect)
//     {
//         Console.WriteLine(message);
//         if(int.TryParse(Console.ReadLine(), out result))
//         {
//             return result;
//         }
//         else
//             Console.WriteLine("Введите не число");
//     }

//     return result;
// }


// Console.WriteLine("Введите число");
// string numberString = Console.ReadLine() ?? ""; // check for null
// int number = Convert.ToInt32(numberString);

// int result = number * number;

// Console.WriteLine($"Квадрат числа: {number} = {result}");