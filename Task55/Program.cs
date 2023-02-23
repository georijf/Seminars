/*Задача 55: 
Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, 
если это невозможно, программа должна вывести 
сообщение для пользователя.*/

int[,] matrixGenerate = CreateMatrixRndInt(4, 4, 0, 255); // Генерируем массив
PrintMatrix(matrixGenerate);                              // Распечатываем
Console.WriteLine();                                      // Печатаем пробел

if (IsSquareMatrix(matrixGenerate)) // Добавляем проверку которая на вход получает 
                                    // сгенерированную матрицу (matrixGenerate)
{
    PrintMatrix(ReplacementMatrix(matrixGenerate)); // если (true) то сразу печать и 
}                                                 // метод разворота (ReplacementMatrix(matrixGenerate)
else                                              // иначе 
{                                                 // Console.WriteLine("Невозможно обработать массив!");
    Console.WriteLine("Невозможно обработать массив!");
}

bool IsSquareMatrix(int[,] matrix) // из bool метода возвращается либо (true) либо (false) 
{
    return matrix.GetLength(0) == matrix.GetLength(1); // проверяем матрицу на равенство строк и столбцов
}

int[,] ReplacementMatrix(int[,] matrix)
{ // реализовали с помощью дополнительного массива new int[matrix.GetLength(0), matrix.GetLength(1)
    int[,] tempMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)]; // с размером соответствующей матрицы 
    for (int i = 0; i < matrix.GetLength(0); i++) // при помощи двойной итерации строки i 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // и столбцы j
        {
            tempMatrix[j, i] = matrix[i, j]; // индексы поменяли местами [j, i]
        }
    }
    return tempMatrix; // вернули новый массив и передали в качестве 
}                    // параметра в метод печати PrintMatrix(ReplacementMatrix(matrixGenerate));


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
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
