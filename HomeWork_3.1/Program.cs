/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 18.08.2022
 */

// Проверка является ли число полиндромным
Console.WriteLine("Введите  любое пятизначное число");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3]){
    Console.WriteLine("Число является полиндромным");
} else{
    Console.WriteLine("Число не является полиндромным");
}

