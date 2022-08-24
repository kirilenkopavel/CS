/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 22.08.2022
 */

// Программа задаёт массив из 8 элементов и выводит их на экран..

// Функция создает массив из чисел.
int[] CreateArray(int value) {
    int[] array = new int[value];
    var random = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(0,100);
    }
    return array;
}

// Выводит в консоль массив
void PrintArray(int[] array){
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

Console.Write("Укажите длину массива: ");
int lenght = int.Parse(Console.ReadLine());

PrintArray(CreateArray(lenght));
