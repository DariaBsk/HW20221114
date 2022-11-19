// Задача 43: Напишите программу, которая найдёт
// точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double CoordinatesX(double k01, double k02, double b01, double b02)
{
    double coordinatesX = (b02-b01)/(k01-k02);
    return coordinatesX;
}

double CoordinatesY(double coordinatesX, double k01, double b01)
{
    double coordinatesY = k01*coordinatesX+b01;
    return coordinatesY;
}


Console.WriteLine("Введите данные прямых m и n. ");

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают.");
}
else if(k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые не пересекаются, они параллельны.");
}
else
{
    double coordinsX = CoordinatesX(k1, k2, b1, b2);
    double coordinsY = CoordinatesY(coordinsX, k1, b1);

    Console.WriteLine($"Координаты точки пересечения прямых m и n: ({coordinsX}; {coordinsY})");
}
