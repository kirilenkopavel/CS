/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 08.08.2022
 */

// Является ли число четным
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}