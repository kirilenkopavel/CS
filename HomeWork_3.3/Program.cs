/**
 * C# (Знакомство с языками програмирования)
 *@author Andrey Kirilenko
 *@version 18.08.2022
 */

// Выдаёт таблицу кубов чисел от 1 до N
double inCube(int number){
    double result = Math.Pow(number, 3);
    return result;
}

void printResultTable(int lenght){
    int number = 0;
    for (int i = 0; i < lenght; i++){
        number++;
        double result = inCube(number);
        Console.WriteLine(result);
    }
}

Console.WriteLine("Введите число");
int lenght = int.Parse(Console.ReadLine());

printResultTable(lenght);


