/* Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).
645-> 5
78->третьей цифры нет
32679 -> 6 */


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = (number / 100) % 10;

if (thirdDigit == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}


/* Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    if (number < 1000)
    {
        int three = number % 100;
        int tow = three % 10;
        Console.Write(tow);
    }
} */