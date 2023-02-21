/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. */


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void SquareAddNambers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2) // проход сразу по четным числам строк += 2
    {                                                 // провека на четность не потребуется
        for (int j = 0; j < matrix.GetLength(1); j += 2) // проход сразу по четным числам столбцов += 2
            matrix[i, j] *= matrix[i, j]; // возводим в квадрат перемножаем 
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine($"{'V',14}");
SquareAddNambers(array2D);
PrintMatrix(array2D);