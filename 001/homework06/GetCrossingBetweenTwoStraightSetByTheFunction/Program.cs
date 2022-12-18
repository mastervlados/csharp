//Задача 43: Напишите программу,
//которая найдёт точку пересечения двух прямых,
//заданных уравнениями 
//    y = k1 * x + b1, 
//    y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
using System.Text.RegularExpressions;

double GetValue(string message)
{
    string userTerm = String.Empty;
    double result = -1;
    Random random = new Random();
    string example = String.Empty;
    // Like in H2O:D Just add water! One dot can turn it to magic!
    Regex regex = new Regex(@"^-?[0.-9]+$");

    Console.Write($"> Введите значение {message}: ");

    while (true)
    {
        userTerm = Console.ReadLine() ?? "";

        if (regex.IsMatch(userTerm))
        {
            result = Convert.ToDouble(userTerm);
            break;
        }
        else
        {
            example = Convert.ToString(Math.Round((random.NextDouble() * 10), 3));
            Console.WriteLine();
            Console.Write($"Введите число правильно!\n- например {example}\n> Введите значение {message}: ");
        }
    }

    return result;
}

double[] GetCrossingBetweenTwoStraightSetByTheFunction(
    double b1, 
    double k1, 
    double b2, 
    double k2)
{
    // k1 * x + b1 = k2 * x + b2
    // k1 * x - k2 * x = b2 - b1
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

    Console.WriteLine($"> [{Convert.ToString(x)}, {Convert.ToString(y)}]");
    return new double[2] { x, y };
}

double b1 = GetValue("b1");
double k1 = GetValue("k1");
double b2 = GetValue("b2");
double k2 = GetValue("k2");

// Run method
GetCrossingBetweenTwoStraightSetByTheFunction(b1, k1, b2, k2);