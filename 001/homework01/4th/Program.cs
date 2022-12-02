// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа покажет какое из 3-х введенных чисел самое большое");

int numberA = 0;
int numberB = 0;
int numberС = 0;
int maxNumber; // 'cause I need to input numberA

Console.WriteLine(""); // br
Console.Write("Введите число A: ");
if(!int.TryParse(Console.ReadLine(), out numberA))
{
    Console.WriteLine("Нужно ввести число!");
}
else
{
    maxNumber = numberA; // here
    
    Console.WriteLine(""); // br
    Console.Write("Введите число B: ");
    if(!int.TryParse(Console.ReadLine(), out numberB))
    {
        Console.WriteLine("Нужно ввести число!");
    }
    else
    {
        Console.WriteLine(""); // br
        Console.Write("Введите число C: ");
        if(!int.TryParse(Console.ReadLine(), out numberС))
        {
            Console.WriteLine("Нужно ввести число!");
        }
        else
        {
            Console.WriteLine(""); // br
            if(maxNumber < numberB) maxNumber = numberB;
            if(maxNumber < numberС) maxNumber = numberС;

            Console.WriteLine($"> Среди чисел: [{numberA}, {numberB}, {numberС}] самое большое [{maxNumber}]\nЗаходите к нам еще!:D");
        }
    }
}