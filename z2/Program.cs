// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Ввод данных:
Console.Write("Введите коэффициент уравнения k1 =   ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент уравнения b1 =   ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент уравнения k2 =   ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент уравнения b2 =   ");
double b2 = Convert.ToDouble(Console.ReadLine());

double CoordX = 0;
double CoordY = 0;

if (k1 != k2) // Проверка на пересекаемость
{
    CoordX = ((b2 - b1) / (k1 - k2));
    CoordY = k1 * CoordX + b1;
    Console.WriteLine($"Прямые  пересекаются в точке с координатами х = {CoordX:F2}, y = {CoordY:F2}.");
}
else
{
    Console.WriteLine("Прямые параллельны.");
}










