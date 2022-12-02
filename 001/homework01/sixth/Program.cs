// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Программа покажет четное число или нет");

int number = 0;

Console.WriteLine(""); // br
Console.Write("Введите число: ");
if(!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Нужно ввести число!");
}
else
{
    if(number % 2 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
