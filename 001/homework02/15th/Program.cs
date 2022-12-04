//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
// day off - это выходной день
void IsThisDayOff(int dayNumber)
{
    string[] days = new string[8] {
        "Дни недели", // Title 
        "Понедельник", // 1
        "Вторник", // 2
        "Среда",  // 3
        "Четверг", // 4
        "Пятница", // 5
        "Суббота", // 6
        "Воскресенье" // 7
    };

    if(dayNumber == 6 || dayNumber == 7)
        Console.WriteLine($"Да, {days[dayNumber]} является выходным днем.");
    else if(dayNumber >= 1 && dayNumber <= 5) // [1, 5]
        Console.WriteLine($"Нет, {days[dayNumber]} является рабочим днем.");
    else
        Console.WriteLine($"{days[0]}: в следующий раз напишите порядковый номер.");
}

IsThisDayOff(6);
IsThisDayOff(7);
IsThisDayOff(1);
IsThisDayOff(8);
IsThisDayOff(-6);