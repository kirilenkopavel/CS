/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 29.08.2022
 */

// Программа находит сумму элементов, стоящих на нечётных позициях.

// Функция создает массив из случайных чисел.
int[] CreateArray(int value) {
    int[] array = new int[value];
    var random = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(0,100);
    }
    Console.WriteLine("[{0}]", string.Join(", ", array)); // для отладки
    return array;
}

// Функция возвращает сумму элементов стоящих на нечетных позициях в массиве
int SumOfOddNumbers(int[] array) {
    int result = 0;
    for(int i = 1; i < array.Length; i+=2){
        result = result + array[i];
    }
    return result;
}

int[] array = CreateArray(10);
Console.WriteLine(SumOfOddNumbers(array));

