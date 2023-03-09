// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetConsole(string msg)
{
    Console.WriteLine(msg);
    int userNumber;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            userNumber = number;
            break;
        }
        else Console.WriteLine("Вы ввели не число");
    }
    return userNumber;
}

int[,] InitMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

void GetMinSummString(int[,] matrix)
{
    int minSummRow = 0;
    int summRow = 0;
    int minRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSummRow += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summRow += matrix[i, j];
            if (summRow < minSummRow)
            {
                minSummRow = summRow;
                minRow = i;
            }
            summRow = 0;
        }
    }
    Console.WriteLine($"{minRow + 1} cтрока является строкой с наименьшей суммой элементов ");
}

int rows = GetConsole("Введите число строк в матрице");
int columns = GetConsole("Введите число столбцов в матрице");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
GetMinSummString(matrix);
