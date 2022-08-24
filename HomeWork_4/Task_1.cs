/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 22.08.2022
 */

// Возводит число A в натуральную степень B.

// Функция расчитывает результат возведнеия в степень.
double Exponentiation(int a, int b){
    double result = Math.Pow(a, b);
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write(Exponentiation(numberA, numberB));
