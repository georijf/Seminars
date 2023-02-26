/* Задача 66: 

Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


void SumNaturalElements(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (numberM++);
    SumNaturalElements(numberM, numberN, sum);
}

Console.Write("Введите начальное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
SumNaturalElements(numberM, numberN, 0);