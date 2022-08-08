/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 08.08.2022
 */

// Максимальое из двух чисел
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > max)
{
max = number2;
}
Console.WriteLine("Большее число: " + max);



