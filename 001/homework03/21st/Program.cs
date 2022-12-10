// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

// distanceBetweenTwoPointsIn3d = ((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)^1/2

double DistanceBetweenTwoPointsIn3d(double[] pointA, double[] pointB)
{
    if (pointA.Length == 3 && pointB.Length == 3)
    {
        // index == 0 ~ x
        // index == 1 ~ y
        // index == 2 ~ z
        double result = Math.Sqrt(
            Math.Pow(pointB[0] - pointA[0], 2) +
            Math.Pow(pointB[1] - pointA[1], 2) +
            Math.Pow(pointB[2] - pointA[2], 2));

        return Math.Round(result, 2);
    }
    else
        return 404;
}

Console.WriteLine(
    DistanceBetweenTwoPointsIn3d(
        new double[] { 3, 6, 8 }, 
        new double[] { 2, 1, -7 }));

Console.WriteLine(
    DistanceBetweenTwoPointsIn3d(
        new double[] { 7, -5, 0 },
        new double[] { 1, -1, 9 }));

Console.WriteLine(
    DistanceBetweenTwoPointsIn3d(
        new double[] { 3, 6 },
        new double[] { 2, 1, -7, 10 }));