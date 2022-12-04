//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
void ShowThirdNumberOfNumber(int number)
{
    int thirdNumber = -1;

    if(number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }

        thirdNumber = number % 10;

        Console.WriteLine($"Третья цифра = {thirdNumber}");
    }
    else 
        Console.WriteLine($"У числа {number} - третьей цифры нет!");
}

ShowThirdNumberOfNumber(645);
ShowThirdNumberOfNumber(78);
ShowThirdNumberOfNumber(32679);
ShowThirdNumberOfNumber(3297932);
ShowThirdNumberOfNumber(999);