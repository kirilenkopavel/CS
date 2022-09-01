/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 01.09.2022
 */

// Программа найдёт сумму элементов, находящихся на главной диагонали двумерного массива.

// Функция создает двумерный массив случайных чисел
int[,] CreateArray(int size) {
    int[,] array = new int[size, size];
    var random = new Random();
    for(int i = 0; i < size; i++) {
        for(int j = 0; j < size; j++) {
            array[i, j] = random.Next(-10,10);
            Console.Write("{0}\t",array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
}

// Функция считает сумму элементов, находящихся на главной диагонали двумерного массива.
int SummAlimentsMainDiagonal(int[,] array) {
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            if(i == j) { 
                result = result + array[i, j];
            }    
        }
    }
    return result;
}

int result = SummAlimentsMainDiagonal(CreateArray(4));
Console.WriteLine(result);