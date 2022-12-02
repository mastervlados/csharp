// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа покажет все чётные числа от 1 до N");

int number = 0;

Console.WriteLine(""); // br
Console.Write("Введите число: ");
if(!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Нужно ввести число!");
}
else
{
    Console.Write("> ");
    for(int i = 2; i < number; i++)
    {
        if(i % 2 == 0) Console.Write($"{i}, ");
    }
    Console.WriteLine($"{number}");
}

