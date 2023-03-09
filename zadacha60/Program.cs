// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InitBook()
{
    Random rnd = new Random();
    int[,,] book = new int[2, 2, 2];
    int random = rnd.Next(10, 21);
    for (int i = 0; i < book.GetLength(0); i++)
    {
        for (int j = 0; j < book.GetLength(1); j++)
        {
            for (int k = 0; k < book.GetLength(2); k++)
            {
                book[i, j, k] = random;
                random += rnd.Next(1, 10);
            }
        }
    }
    return book;
}
void PrintBook(int[,,] book)
{
    for (int i = 0; i < book.GetLength(0); i++)
    {
        for (int j = 0; j < book.GetLength(1); j++)
        {
            for (int k = 0; k < book.GetLength(2); k++)
            {
                Console.Write($"{book[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] book = InitBook();
PrintBook(book);
