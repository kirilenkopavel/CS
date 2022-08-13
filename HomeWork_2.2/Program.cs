/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 13.08.2022
 */

// Проверка является ли день выходным
Console.WriteLine("Введите  номер дня недели");
int number = int.Parse(Console.ReadLine());

if (number <= 0 | number > 7) {
    Console.WriteLine("Такого дня недели нет");
}
else if (number == 6 | number == 7) {
    Console.WriteLine("Выходной день");
}
else {
    Console.WriteLine("Будний день");
}

