/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 22.08.2022
 */

// Программа принимает на вход число и выдаёт сумму цифр в числе.

// Функция расчитывает сумму чисел в числе.
int SumOfNumbers(string value) {
    int result = 0;
    for(int i = 0; i < value.Length; i++) {
        int number = int.Parse(value[i].ToString());
        result = result + number;
    }
    return result;    
}
Console.Write("Введите число: ");
string number = Console.ReadLine();

Console.Write(SumOfNumbers(number));