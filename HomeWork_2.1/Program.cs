/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 13.08.2022
 */

// Вывод третьего знака любого числа
Console.WriteLine("Введите любое число");
string number = Console.ReadLine();

if (number.Length < 3) {
    Console.WriteLine("Третьей цифры нет");
} else {
    Console.WriteLine(number[2]);
}
