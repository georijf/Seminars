/*Задача 57:
 
Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.*/

int[,] FillMatrixRnd(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 10);
        }
    }
    return matrix;
}
void PrintMatrixRnd(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[] AllNambersArray(int[,] array2D) // Переводим двумерный массив в одномерный int[,] -> int[]
{

    int arraySize = array2D.Length;   // показывает общее количество элементов в массиве array2D.Length;
    int[] array = new int[arraySize]; // создаем двумерный массив
    int count = 0;                    // объявляем счетчик для одномерного массива
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array[count] = array2D[i, j]; // каждому элементу массива array[count] 
            count++;                      // присваиваем значение элемента двумерного массива arrya2D[i, j]
        }
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
void FrequencyDictionary(int[] array)
{
    int i = 0;
    int count = 1; // одно число уже записали 
    int num = array[0];
    for (i = 1; i < array.Length; i++) // начинаем с превого индекса, так как первый уже записан
    {
        if (array[i] == num)
            count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count} раз.");
            num = array[i]; // меняем на новую цифру в масиве
            count = 1; // count обнуляем до единицы 
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз."); // для последнего цикла 
}
int[,] matrix = FillMatrixRnd(4, 4, 1, 10);
PrintMatrixRnd(matrix);
int[] array = AllNambersArray(matrix);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Array.Sort(array); // Сортировка одномерного массива и передача в метод -> void FrequencyDictionary(int[] array)
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
FrequencyDictionary(array);
