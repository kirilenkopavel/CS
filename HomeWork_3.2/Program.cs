/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 18.08.2022
 */

// Находит расстояние между двумя точками в 3D пространстве.

// Функция рассчитывает расстояние
double distance(double x1, double y1, double z1, double x2, double y2, double z2){
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return d;
}

// Вывод в консоль
void print(double result) {
    Console.WriteLine(result);
}

Console.WriteLine("Введите  координату х точки А");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите  координату y точки А");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите  координату z точки А");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите  координату х точки B");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите  координату y точки B");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите  координату z точки B");
double z2 = double.Parse(Console.ReadLine());

print(distance(x1, y1, z1, x2, y2, z2));
