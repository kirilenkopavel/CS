/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 08.08.2022
 */

// Все четные числа от 1 до N
Console.WriteLine("Введите число");
int lenght = int.Parse(Console.ReadLine());

int[] array = new int[lenght];

for (int i = 0; i < lenght; i++){
    array[i] = i + 1;
    if (array[i] % 2 == 0)
        {
            Console.WriteLine(array[i]);
        }
}

