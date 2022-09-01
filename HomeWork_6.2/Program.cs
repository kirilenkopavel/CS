/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 01.09.2022
 */

/* Программа найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

// Функция рассчитывает точку Х
double CalculatesPointX(double b1, double k1, double b2, double k2) {
    double x = (b2 - b1)/(k1 - k2);
    return x;
}

// Функция рассчитывает точку Y
double CalculatesPointY(double b1, double k1, double b2, double k2) {
    double x = CalculatesPointX(b1, k1, b2, k2);
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите значение точки b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение точки b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение точки k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение точки k2: ");
int k2 = int.Parse(Console.ReadLine());

double coordinatX = CalculatesPointX(b1, k1, b2, k2); 
double coordinatY = CalculatesPointY(b1, k1, b2, k2); 
Console.WriteLine("Координаты пересечения: х = " + coordinatX + " y = " + coordinatY);
