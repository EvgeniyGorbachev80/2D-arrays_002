// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
Console.WriteLine();

int[,] array = new int[4, 4];
FillArray(array);
Console.WriteLine("Прямоугольный двумерный массив:");
PrintArray(array);
Console.WriteLine();
MinSumElements(array);

void MinSumElements(int[,] array) // Функция вывода номера строки (не индекса) с наименьшей суммой элементов.
{
    int sumElements = 0;
    int minElements = 0;
    int minSumElements = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minElements += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumElements += array[i, j];
        if (sumElements < minElements)
        {
            minElements = sumElements;
            minSumElements = i;
        }
        sumElements = 0;
    }
    Console.WriteLine($"Наименьшей сумме элементов соответствует: {minSumElements + 1} строка");
    Console.WriteLine();
}

void PrintArray(int[,] array) // Функция вывода двумерного массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array) // Функция заполнения массива рандомно числами от 1 до 9.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}