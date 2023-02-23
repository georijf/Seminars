/*Задача 53: 
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/


void ReplacemenMatrix(int[,] matrixMassIn) // Создали метод который меняет строки
{
    for (int i = 0; i < matrixMassIn.GetLength(1); i++) // количество итераций ровно количеству столбцов
    { // в переменную temp записываем нулевой строке значение i сторбца. если не надо переменную использовать дальше то,
        int temp = matrixMassIn[0, i]; // Объявляем переменную котрая создается в цикле ближе к ее использованию 
        matrixMassIn[0, i] = matrixMassIn[matrixMassIn.GetLength(0) - 1, i]; // в ячейку matrixMassIn[0, i]
                                                                             // записываем новое значение элемента строки i столбца matrixMassIn[matrixMassIn.GetLength(0) - 1, i] 
        matrixMassIn[matrixMassIn.GetLength(0) - 1, i] = temp; // Ячейку matrixMassIn[matrixMassIn.GetLength(0) - 1, i]
                                                               // записываем в переменную temp в 17 строку и итерация продолжается. 
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}
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

int[,] matrix = CreateMatrixRndInt(4, 5, 0, 255); // Генерируем массив
PrintMatrix(matrix);                              // Распечатываем массив
Console.WriteLine();
ReplacemenMatrix(matrix); // переворачиваем и вызываем новый сгенерированный массив
PrintMatrix(matrix);      // Вывод нового массива 