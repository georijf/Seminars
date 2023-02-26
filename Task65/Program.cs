/* Задача 65: 
Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */


void NaturalNumbers(int numberM, int numberN)
{
    if (numberM >= numberN)
    {
        Console.Write($"{numberM} ");
        NaturalNumbers(numberM - 1, numberN);
    }
}

Console.WriteLine("Введите натурельное M ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натурельное N ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);