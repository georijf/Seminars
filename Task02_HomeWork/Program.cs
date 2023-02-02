/* Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число 
большее, а какое меньшее. */

Console.Write("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if (numb1 > numb2)
{
    Console.WriteLine($"Первое число ({numb1}) больше, чем второе {numb2}");
}
else if (numb1 < numb2)
{
    Console.WriteLine($"Второе число ({numb2}) больше, чем первое ({numb1})");
}
else
{
    Console.WriteLine("Числа равны друг другу");
}