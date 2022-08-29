/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 29.08.2022
 */

// Программа находит разницу между максимальным и минимальным элементов массива.

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

// Функция находит максимальный элемент из массива
int MaxOfNumber(int[] array) {
    int maxNumber = array[0];
    for(int i = 0; i < array.Length; i++){
        if(array[i] > maxNumber){
            maxNumber = array[i];
        }    
    }
    return maxNumber;
}

// Функция находит минимальным элемент из массива
int MinOfNumber(int[] array) {
    int minNumber = array[0];
    for(int i = 0; i < array.Length; i++){
        if(array[i] < minNumber){
            minNumber = array[i];
        }    
    }
    return minNumber;
}

int[] array = CreateArray(10);
int result = MaxOfNumber(array) - MinOfNumber(array);
Console.WriteLine(result);
