﻿/* Задача 25: 
Напишите цикл, который принимает 
на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую необходимо его возвести: ");
int numberB = Convert.ToInt32(Console.ReadLine());
ToDegree(numberA, numberB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {a} в стемени {b} = {result}");
}
