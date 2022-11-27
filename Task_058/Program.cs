// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArray(array);
PrintArray2D(array);
Console.WriteLine();
FillArray(secondArray);
PrintArray2D(secondArray);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");

int[,] result = ProductTwoMatrix(array, secondArray, resultArray);
PrintArray2D(resultArray);
Console.WriteLine();

int[,] ProductTwoMatrix(int[,] array, int[,] secondArray, int[,] resultArray) // Функция нахождения произведение двух матриц. 
{
    if (array.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
        return array;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] += array[i, k] * secondArray[k, j];
            }

        }
    }
    return resultArray;
}

void FillArray(int[,] array) // Функция заполнения массива рандомными числами от 1 до 9.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array) // Функция вывода двумерного массива в терминал. 
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