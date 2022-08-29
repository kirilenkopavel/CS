/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 29.08.2022
 */

// Программа показывает количество чётных чисел в массиве.

// Функция создает массив из случайных трехзначных чисел.
int[] CreateArray(int value) {
    int[] array = new int[value];
    var random = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(100,1000);
    }
    Console.WriteLine("[{0}]", string.Join(", ", array)); // для отладки
    return array;
}

// Функция проверяет число на четность
bool ParityCheck(int value) {
    if (value % 2 == 0) {
        return true;
    }
    else {
        return false;
    }
}

// Функция возвращает колличество четных чисел в массиве
int SumOfEvenNumbers(int[] array) {
    int result = 0;
    for(int i = 0; i < array.Length; i++) {
        if (ParityCheck(array[i])){
            result ++;
        }
    }
    return result;
}
int[] array = CreateArray(10);
Console.WriteLine(SumOfEvenNumbers(array));
