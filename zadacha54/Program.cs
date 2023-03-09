// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatrix(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

int rows = GetConsole("Введите число строк в матрице");
int columns = GetConsole("Введтие число стобцов в матрице");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);

