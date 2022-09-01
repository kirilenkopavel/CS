/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 01.09.2022
 */

// Программа считает, сколько чисел больше 0 ввёл пользователь.

// Функция определяет является ли число больше 0.
bool ComparisonWithZero(int number) {
    bool result = false;
    if(number > 0){
        result = true;
    }
    return result;
}

// Функция переводит строку чисел в массив.
int[] StringToArrayInt(String value) {
    int[] numberArray = new int[value.Length];
    for(int i = 0; i < value.Length; i++) {
        int number = int.Parse(value[i].ToString());
        numberArray[i] = number;
    }
    return numberArray;    
}

// Функция считает колличество положительных чисел в массиве.
int SummPositiveNumbers(int[] array) {
    int result = 0;
    for(int i = 0; i < array.Length; i++) {
        if(ComparisonWithZero(array[i])) {
            result++;
        }
    }
    return result;
}

Console.Write("Введите произвольные положительные числа в строку: ");
String stringNumber = Console.ReadLine();

int[] numberArray = StringToArrayInt(stringNumber);
int result = SummPositiveNumbers(numberArray);
Console.WriteLine(result);
