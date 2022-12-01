/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double ReadData(string line)
{
    Console.WriteLine(line);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

(double x, double y) FindIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

double b10 = ReadData("Введите координату b1:");
double k10 = ReadData("Введите координату k1:");
double b20 = ReadData("Введите координату b2:");
double k20 = ReadData("Введите координату k2:");


if ((k10 - k20) == 0)
    Console.WriteLine("Прямые не пересекаются");
else
{
    (double x1, double y1) = FindIntersection(b10, k10, b20, k20);
    Console.WriteLine($"Координата пересечения прямых  {Math.Round(x1)};  {Math.Round(y1)}");
}
