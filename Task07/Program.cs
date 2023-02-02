/* 7.Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает последнюю 
цифру этого числа */

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <= 999)
{
    Console.WriteLine("Число трёхзначное");
    int res = number % 10;
    Console.WriteLine($"Последняя цифра числа - это: {res}");
}
else
{
    Console.WriteLine("Число не трёхзначное");
}
